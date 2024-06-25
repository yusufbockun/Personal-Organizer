using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Media;
using System.Linq;

namespace Personal_Organizer_OOP_Project
{
    public partial class Reminder : Form, IReminderObserver
    {
        private SoundPlayer player = new SoundPlayer();
        private List<IReminder> reminders;
        private Dictionary<string, IReminderFactory> reminderFactories;
        private Timer reminderTimer;

        public Reminder()
        {
            InitializeComponent();

            // initialize the reminder list and observer
            reminders = new List<IReminder>();
            if(MainVariables.user_type == "admin")
            {
                buttonDown.Visible = true;
            }

            // factories
            reminderFactories = new Dictionary<string, IReminderFactory>
            {
                { "Meeting", new MeetingReminderFactory() },
                { "Task", new TaskReminderFactory() }
            };

            // set up the combo box with reminder types
            cmbReminderType.Items.Add("Meeting");
            cmbReminderType.Items.Add("Task");

            // observer
            ReminderObserver.Attach(this);

            // ListView
            listViewReminders.View = View.Details;
            listViewReminders.Columns.Add("Type", 100);
            listViewReminders.Columns.Add("Date", 100);
            listViewReminders.Columns.Add("Time", 100);
            listViewReminders.Columns.Add("Summary", 150);
            listViewReminders.Columns.Add("Description", 250);

            // event handler for ListView selection changes
            listViewReminders.SelectedIndexChanged += ListViewReminders_SelectedIndexChanged;

            // the format of the timePicker to show only time
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;

            // the reminder timer
            reminderTimer = new Timer();
            reminderTimer.Interval = 1000;
            reminderTimer.Tick += ReminderTimer_Tick;
            reminderTimer.Start();
        }

        public void ReminderTimer_Tick(object sender, EventArgs e)
        {
            reminders.OrderBy(r => r.Date);
            // if any reminders are due
            foreach (var reminder in reminders)
            {   
                if (DateTime.Now.Date == reminder.Date.Date && DateTime.Now.Hour == reminder.Date.Hour && DateTime.Now.Minute == reminder.Date.Minute && DateTime.Now.Second == reminder.Date.Second && !reminder.IsNotified)
                {
                    Notify(reminder, true);
                    reminder.IsNotified = true;
                }
                if (reminder.Date > DateTime.Now)
                {
                    Notify(reminder, false);
                    break;
                }
            }
        }

        public static void readCSV(string filename)
        {
            try
            {
                using (var streamReader = new StreamReader(new FileStream(filename, FileMode.Open)))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        Delimiter = ",",
                        HasHeaderRecord = false
                    };

                    using (var csv = new CsvReader(streamReader, config))
                    {
                        var records = new List<List<string>>();
                        while (csv.Read())
                        {
                            var record = new List<string>();
                            for (int i = 0; csv.TryGetField<string>(i, out var field); i++)
                            {
                                record.Add(field);
                            }
                            records.Add(record);
                        }
                        MainVariables.reminderlist = records;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Dosya bulunamadı: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
        }

        public static void writeCSV(string filename)
        {
            try
            {
                // Dosyayı sıfırlayarak tüm kayıtları yeniden yaz
                using (var streamWriter = new StreamWriter(new FileStream(filename, FileMode.Create, FileAccess.Write)))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        Delimiter = ",",
                        HasHeaderRecord = false
                    };

                    using (var csv = new CsvWriter(streamWriter, config))
                    {
                        foreach (var record in MainVariables.reminderlist)
                        {
                            foreach (var field in record)
                            {
                                csv.WriteField(field);
                            }
                            csv.NextRecord();
                        }
                    }
                }
                Console.WriteLine($"Veriler başarıyla {filename} dosyasına yazıldı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void ListViewReminders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewReminders.SelectedItems.Count > 0)
            {
                var selectedItem = listViewReminders.SelectedItems[0];
                var reminder = reminders[selectedItem.Index];
                datePicker.Value = reminder.Date.Date;
                timePicker.Value = reminder.Date;
                txtSummary.Text = reminder.Summary;
                txtDescription.Text = reminder.Description;

                if (reminder is MeetingReminder)
                {
                    cmbReminderType.SelectedItem = "Meeting";
                }
                else if (reminder is TaskReminder)
                {
                    cmbReminderType.SelectedItem = "Task";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbReminderType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a reminder type.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSummary.Text))
            {
                MessageBox.Show("Please enter a summary.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

            // create the reminder
            string selectedType = cmbReminderType.SelectedItem.ToString();
            IReminderFactory factory = reminderFactories[selectedType];
            IReminder reminder = factory.CreateReminder();
            reminder.Date = datePicker.Value.Date + timePicker.Value.TimeOfDay;
            reminder.Summary = txtSummary.Text;
            reminder.Description = txtDescription.Text;
            reminders.Add(reminder);
            MainVariables.reminderlist.Add(new List<string> { MainVariables.user_name, reminder.Type, reminder.Date.ToShortDateString(), reminder.Date.ToShortTimeString(), reminder.Summary, reminder.Description});
            writeCSV("reminderlist.csv");
            UpdateReminderList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listViewReminders.SelectedItems.Count > 0)
            {
                var selectedItem = listViewReminders.SelectedItems[0];
                var reminder = reminders[selectedItem.Index];

                string selectedType = cmbReminderType.SelectedItem.ToString();
                IReminderFactory factory = reminderFactories[selectedType];
                IReminder updatedReminder = factory.CreateReminder();
                updatedReminder.Date = datePicker.Value.Date + timePicker.Value.TimeOfDay;
                updatedReminder.Summary = txtSummary.Text;
                updatedReminder.Description = txtDescription.Text;

                reminders[selectedItem.Index] = updatedReminder;

                UpdateReminderList();

                selectedItem.Selected = true;
            }
            else
            {
                MessageBox.Show("Please select a reminder to update.");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewReminders.SelectedItems.Count > 0)
            {
                bool found = false;
                var reminderCopy = new List<IReminder>(reminders);
                var reminderlistCopy = new List<List<string>>(MainVariables.reminderlist);
                var selectedItem = listViewReminders.SelectedItems[0];
                foreach(var reminder in reminderCopy)
                {
                    foreach (var reminderlist in reminderlistCopy)
                    {
                        if (reminderlist[1] == reminder.Type && reminderlist[2] == reminder.Date.ToShortDateString() && reminderlist[4] == reminder.Summary && reminderlist[5] == reminder.Description)
                        {
                            var index = MainVariables.reminderlist.FindIndex(x => x.SequenceEqual(reminderlist));
                            if (index >= 0)
                            {
                                MainVariables.reminderlist.RemoveAt(index);
                            }
                            reminders.Remove(reminder);
                            found = true;
                            break;
                        }
                    }
                    if (found)
                    {
                        break;
                    }
                }
                UpdateReminderList();
                writeCSV("reminderlist.csv");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            reminders.Clear();
            UpdateReminderList();
        }

        private void UpdateReminderList()
        {
            listViewReminders.Items.Clear();
            foreach (var reminder in reminders)
            {
                var item = new ListViewItem(reminder.Type);
                item.SubItems.Add(reminder.Date.ToShortDateString());
                item.SubItems.Add(reminder.Date.ToShortTimeString());
                item.SubItems.Add(reminder.Summary);
                item.SubItems.Add(reminder.Description);
                listViewReminders.Items.Add(item);
            }
        }

        private void ShakeWindow(Form form)
        {
            const int shakeMagnitude = 10;
            const int shakeDuration = 2000; 
            const int shakeInterval = 50; 

            Point originalPosition = form.Location;
            DateTime startTime = DateTime.Now;

            while ((DateTime.Now - startTime).TotalMilliseconds < shakeDuration)
            {
                form.Location = new Point(originalPosition.X + shakeMagnitude, originalPosition.Y);
                System.Threading.Thread.Sleep(shakeInterval);

                form.Location = new Point(originalPosition.X - shakeMagnitude, originalPosition.Y);
                System.Threading.Thread.Sleep(shakeInterval);
            }

            form.Location = originalPosition; 
        }

        public void Notify(IReminder reminder, bool alarm)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            mainForm.setReminderLabel(reminder.Display);
            if (alarm)
            {
                player.SoundLocation = "alarm.wav";
                player.Play();
            }
        }

        List<List<string>> list = new List<List<string>>();

        private void Reminder_Load(object sender, EventArgs e)
        {
            readCSV("reminderlist.csv");
            for (int i = 0; i < MainVariables.reminderlist.Count; i++)
            {
                if (MainVariables.user_name == MainVariables.reminderlist[i][0])
                {
                    list.Add(MainVariables.reminderlist[i]);
                }
            }
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                listViewReminders.Items.Add(new ListViewItem(new string[] { list[i][1], list[i][2], list[i][3], list[i][4], list[i][5] }));
                if (list[i][1] == "Meeting")
                {
                    reminders.Add(new MeetingReminder { Date = DateTime.Parse(list[i][2] + " " + list[i][3]), Summary = list[i][4], Description = list[i][5] });
                }
                else if (list[i][1] == "Task")
                {
                    reminders.Add(new TaskReminder { Date = DateTime.Parse(list[i][2] + " " + list[i][3]), Summary = list[i][4], Description = list[i][5] });
                }
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void IReminderObserver.Notify(IReminder reminder, string summary)
        {
            throw new NotImplementedException();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "reminderlist.csv");
            File.Copy("reminderlist.csv", filePath, true);
        }
    }
    public interface IReminder
    {
        string Type { get; }
        DateTime Date { get; set; }
        string Summary { get; set; }
        string Description { get; set; }
        string Display { get; }
        bool IsNotified { get; set; }
    }

    public class MeetingReminder : IReminder
    {
        public string Type => "Meeting";
        public DateTime Date { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public bool IsNotified { get; set; }
        public string Display => $"Meeting: {Date.ToShortDateString()} {Date.ToShortTimeString()} - {Summary} - {Description}";
    }

    public class TaskReminder : IReminder
    {
        public string Type => "Task";
        public DateTime Date { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public bool IsNotified { get; set; }

        public string Display => $"Task: {Date.ToShortDateString()} {Date.ToShortTimeString()} - {Summary} - {Description}";
    }

    public interface IReminderFactory
    {
        IReminder CreateReminder();
    }

    public class MeetingReminderFactory : IReminderFactory
    {
        public IReminder CreateReminder()
        {
            return new MeetingReminder();
        }
    }

    public class TaskReminderFactory : IReminderFactory
    {
        public IReminder CreateReminder()
        {
            return new TaskReminder();
        }
    }

    public interface IReminderObserver
    {
        void Notify(IReminder reminder, string summary);
    }

    public static class ReminderObserver
    {
        private static List<IReminderObserver> observers = new List<IReminderObserver>();

        public static void Attach(IReminderObserver observer)
        {
            observers.Add(observer);
        }

        public static void Detach(IReminderObserver observer)
        {
            observers.Remove(observer);
        }

        public static void Notify(IReminder reminder)
        {
            foreach (var observer in observers)
            {
                observer.Notify(reminder, "Some summary text");
            }
        }
    }
}
