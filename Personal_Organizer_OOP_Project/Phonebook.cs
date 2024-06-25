using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using System.IO;

namespace Personal_Organizer_OOP_Project
{

    public partial class Phonebook : Form
    {
        private int selectedRowIndex = -1;
        public Phonebook()
        {
            InitializeComponent();
            if (MainVariables.user_type == "admin")
            {
                buttonDown.Visible = true;
            }
        }
        //program csdekiyle aynı sadece list değişik
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
                        MainVariables.phonebooklist = records;
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
        //program csdekiyle aynı sadece list değişik
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
                        foreach (var record in MainVariables.phonebooklist)
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
        //regex
        private bool IsValidEmail(string email)
        {
            // Regex pattern for valid email address
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        //açılıştaki yükleme
        private void Phonebook_Load(object sender, EventArgs e)
        {
            readCSV("phonebook.csv");
            for (int i = 0; i < MainVariables.phonebooklist.Count; i++)
            {
                dataGridView1.Rows.Add(MainVariables.phonebooklist[i][0] , MainVariables.phonebooklist[i][1], MainVariables.phonebooklist[i][2], MainVariables.phonebooklist[i][3]);
            }
        }
        //exit button operator
        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //kişi ekleme
        private void btnreg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) | string.IsNullOrEmpty(textBox2.Text) | string.IsNullOrEmpty(maskedTextBox1.Text) | string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("please fill the blank boxes");
            }
            else if (IsValidEmail(textBox2.Text)==false)
            {
                MessageBox.Show("you entered the incorrect email", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (maskedTextBox1.Text.Length != 15)
            {
                MessageBox.Show("you entered the incorrect phone number", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MainVariables.phonebooklist.Add(new List<string>() {textBox1.Text,textBox2.Text, maskedTextBox1.Text, textBox4.Text });
                writeCSV("phonebook.csv");
                MessageBox.Show("Succesfully created");
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, maskedTextBox1.Text, textBox4.Text );
            }

        }
        //kişi çıkarma
        private void btndel_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count)
            {
                if (!dataGridView1.Rows[selectedRowIndex].IsNewRow)
                {
                    // DataGridView'den satırı sil
                    dataGridView1.Rows.RemoveAt(selectedRowIndex);

                    // Listeden satırı sil
                    MainVariables.phonebooklist.RemoveAt(selectedRowIndex);

                    // Index'i sıfırla
                    selectedRowIndex = -1;

                    //dosyaya yaz
                    writeCSV("phonebook.csv");
                }
            }
            else
            {
                MessageBox.Show("please select row to delete.");
            }
        }
        // kişi güncelleme
        private void btnup_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count)
            {
                if (!dataGridView1.Rows[selectedRowIndex].IsNewRow)
                {
                    if (string.IsNullOrEmpty(textBox1.Text) | string.IsNullOrEmpty(textBox2.Text) | string.IsNullOrEmpty(maskedTextBox1.Text) | string.IsNullOrEmpty(textBox4.Text))
                    {
                        MessageBox.Show("please fill the blank boxes");
                    }
                    else {

                        if (IsValidEmail(textBox2.Text) == false)
                        {
                            MessageBox.Show("you entered the incorrect email", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else if (maskedTextBox1.Text.Length != 15 | maskedTextBox1.Text == "")
                        {
                            MessageBox.Show("you entered the incorrect phone number", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            // DataGridView'deki satırı değiştir
                            dataGridView1.Rows[selectedRowIndex].Cells[0].Value = textBox1.Text;
                            dataGridView1.Rows[selectedRowIndex].Cells[1].Value = textBox2.Text;
                            dataGridView1.Rows[selectedRowIndex].Cells[2].Value = maskedTextBox1.Text;
                            dataGridView1.Rows[selectedRowIndex].Cells[3].Value = textBox4.Text;
                            //listedeki elemanları değiştir
                            MainVariables.phonebooklist[selectedRowIndex][0] = textBox1.Text;
                            MainVariables.phonebooklist[selectedRowIndex][1] = textBox2.Text;
                            MainVariables.phonebooklist[selectedRowIndex][2] = maskedTextBox1.Text;
                            MainVariables.phonebooklist[selectedRowIndex][3] = textBox4.Text;
                            // Index'i sıfırla
                            selectedRowIndex = -1;

                            //dosyaya yaz
                            writeCSV("phonebook.csv");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("please select row to update.");
            }
        }
        // index alma
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır index'i mi kontrol edin
            {
                selectedRowIndex = e.RowIndex;
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "phonebook.csv");
            File.Copy("phonebook.csv", filePath, true);
        }
    }
}
