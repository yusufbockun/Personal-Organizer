using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organizer_OOP_Project
{
    public partial class Mails : Form
    {
        public Mails()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                        MainVariables.emaillist = records;
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
                        foreach (var record in MainVariables.emaillist)
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

        List<List<string>> list = new List<List<string>>();

        private void Mails_Load(object sender, EventArgs e)
        {
            readCSV("emaillist.csv");
            for (int i = 0; i < MainVariables.emaillist.Count; i++)
            {
                if(MainVariables.emaillist[i][1] == MainVariables.email)
                {
                    list.Add(MainVariables.emaillist[i]);
                }
            }
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                listBox1.Items.Add((list[i][4] == "unread" ? "(Unread)" : "(Read)") + " From: " + list[i][0] + "; About: " + list[i][2]); 
            }
        }

        public static void sendMail(string email, string password) {
            readCSV("emaillist.csv");
            MainVariables.emaillist.Add(new List<string> { MainVariables.email, email, "Password Change", "Your new password is " + password, "unread" });
            writeCSV("emaillist.csv");
        }   
        private void buttonRead_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                buttonDelete.Visible = false;
                buttonMarkUnread.Visible = false;
                buttonMarkRead.Visible = false;
                buttonBack.Visible = true;
                textBoxAbout.Visible = true;
                textBoxFromToWho.Visible = true;
                textBoxMail.Visible = true;
                textBoxFromToWho.Text = "From: " + list[listBox1.SelectedIndex][0] + "; To: " + list[listBox1.SelectedIndex][1];
                textBoxAbout.Text = list[listBox1.SelectedIndex][2];
                textBoxMail.Text = list[listBox1.SelectedIndex][3];
                list[listBox1.SelectedIndex][4] = "read";
                listBox1.Items[listBox1.SelectedIndex] = "(Read)" + listBox1.Items[listBox1.SelectedIndex].ToString().Replace("(Unread)", "");
                writeCSV("emaillist.csv");
            }
            else
            {
                MessageBox.Show("Please select a mail to read");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a mail to delete.");
            }
            else
            {
                MainVariables.emaillist.Find(x => x.SequenceEqual(list[listBox1.SelectedIndex])).Clear();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                writeCSV("emaillist.csv");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            textBoxAbout.Text = "";
            textBoxFromToWho.Text = "";
            textBoxMail.Text = "";
            textBoxAbout.Visible = false;
            textBoxFromToWho.Visible = false;
            textBoxMail.Visible = false;
            textBoxAbout.Visible = false;
            buttonBack.Visible = false;
            buttonDelete.Visible = true;
            buttonMarkUnread.Visible = true;
            buttonMarkRead.Visible = true;
        }

        private void buttonMarkUnread_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                MainVariables.emaillist.Find(x => x.SequenceEqual(list[listBox1.SelectedIndex]))[4] = "unread";
                list[listBox1.SelectedIndex][4] = "unread";
                listBox1.Items[listBox1.SelectedIndex] = "(Unread)" + listBox1.Items[listBox1.SelectedIndex].ToString().Replace("(Read)", "");
                writeCSV("emaillist.csv");
            }
            else
            {
                MessageBox.Show("Please select a mail to mark as unread");
            }
        }

        private void buttonMarkRead_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                MainVariables.emaillist.Find(x => x.SequenceEqual(list[listBox1.SelectedIndex]))[4] = "read";
                list[listBox1.SelectedIndex][4] = "read";
                listBox1.Items[listBox1.SelectedIndex] = "(Read)" + listBox1.Items[listBox1.SelectedIndex].ToString().Replace("(Unread)", "");
                writeCSV("emaillist.csv");
            }
            else
            {
                MessageBox.Show("Please select a mail to mark as read");
            }
        }
    }
}
