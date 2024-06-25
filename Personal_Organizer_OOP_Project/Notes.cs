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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organizer_OOP_Project
{
    public partial class Notes : Form
    {
        int index = -1;
        int userIndex;
        bool found = false;
        public Notes()
        {
            InitializeComponent();
            if(MainVariables.user_type == "admin")
            {
                buttonDown.Visible = true;
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
                        MainVariables.noteslist = records;
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
                        foreach (var record in MainVariables.noteslist)
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

        private void Notes_Load(object sender, EventArgs e)
        {
            readCSV("noteslist.csv");
            for (int i = 0; i < MainVariables.noteslist.Count; i++)
            {
                if(MainVariables.user_name == MainVariables.noteslist[i][0])
                {
                    found = true;
                    for (int j = 1; j < MainVariables.noteslist[i].Count; j++)
                    {
                        listBox1.Items.Add(MainVariables.noteslist[i][j]);
                    }
                }
            }
            if (!found)
            {
                MainVariables.noteslist.Add(new List<string>());
                MainVariables.noteslist[MainVariables.noteslist.Count - 1].Add(MainVariables.user_name);
                writeCSV("noteslist.csv");
                userIndex = MainVariables.noteslist.Count - 1;
            }
            else
            {
                for (int i = 0; i < MainVariables.noteslist.Count; i++)
                {
                    if (MainVariables.user_name == MainVariables.noteslist[i][0])
                    {
                        userIndex = i;
                    }
                }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            buttonDone.Visible = true;
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Enter your note here...";
            buttonCancel.Visible = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a note to update.");
            }
            else
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                textBox1.ForeColor = Color.Black;
                index = listBox1.SelectedIndex;
                textBox1.Visible = true;
                buttonUpdate.Visible = true;
                buttonCancel.Visible = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a note to delete.");
            }
            else
            {
                MainVariables.noteslist[userIndex].RemoveAt(listBox1.SelectedIndex + 1);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                writeCSV("noteslist.csv");
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox1.Text == "Enter your note here...")
            {
                MessageBox.Show("Please enter a note.");
                return;
            }
            listBox1.Items.Add(textBox1.Text);
            MainVariables.noteslist[userIndex].Add(textBox1.Text);
            writeCSV("noteslist.csv");
            textBox1.Visible = false;
            buttonDone.Visible = false;
            textBox1.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            buttonUpdate.Visible = false;
            textBox1.Visible = false;
            listBox1.Items[index] = textBox1.Text;
            MainVariables.noteslist[userIndex][index + 1] = textBox1.Text;
            writeCSV("noteslist.csv");
            textBox1.Text = "";
            buttonCancel.Visible = false;
            index = -1;

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Enter your note here...")
            {
                textBox1.ForeColor = Color.Black;
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Gray;
                textBox1.Text = "Enter your note here...";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonCancel.Visible = false;
            textBox1.Text = "";
            textBox1.Visible = false;
            buttonDone.Visible = false;
            buttonUpdate.Visible = false;
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Labelc5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "noteslist.csv");
            File.Copy("noteslist.csv", filePath, true);
        }
    }
}
