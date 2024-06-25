using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organizer_OOP_Project
{
    public partial class Salary_Calc : Form
    {
        List<int> cocuk = new List<int>();
        Dictionary<string, float> il = new Dictionary<string, float>();
        float katsayi = 1;
        public Salary_Calc()
        {
            InitializeComponent();
            if (MainVariables.user_type == "admin")
            {
                buttonDown.Visible = true;
            }
        }
        private void Salary_Calc_Load(object sender, EventArgs e)
        {
            il.Clear();
            il.Add("istanbul", 0.3f);
            il.Add("ankara", 0.2f);
            il.Add("izmir", 0.2f);
            il.Add("kocaeli", 0.1f);
            il.Add("sakarya", 0.1f);
            il.Add("düzce", 0.1f);
            il.Add("bolu", 0.1f);
            il.Add("yalova", 0.1f);
            il.Add("edirne", 0.1f);
            il.Add("kırklareli", 0.1f);
            il.Add("tekirdağ", 0.1f);
            il.Add("trabzon", 0.05f);
            il.Add("ordu", 0.05f);
            il.Add("giresun", 0.05f);
            il.Add("rize", 0.05f);
            il.Add("artvin", 0.05f);
            il.Add("gümüşhane", 0.05f);
            il.Add("bursa", 0.05f);
            il.Add("eskişehir", 0.05f);
            il.Add("bilecik", 0.05f);
            il.Add("aydın", 0.05f);
            il.Add("denizli", 0.05f);
            il.Add("muğla", 0.05f);
            il.Add("adana", 0.05f);
            il.Add("mersin", 0.05f);
            il.Add("balıkesir", 0.05f);
            il.Add("çanakkale", 0.05f);
            il.Add("antalya", 0.05f);
            il.Add("ısparta", 0.05f);
            il.Add("burdur", 0.05f);
            readCSV("salary.csv");
            foreach (List<string> item in MainVariables.salarylist)
            {
                if (item[0] == MainVariables.user_name)
                {
                    comboBox2.Text = item[1];
                    comboBox1.Text = item[2];
                    numericDeneyim.Value = Int32.Parse(item[3]);
                    checkedListBox1.SetItemChecked(0, Boolean.Parse(item[4]));
                    checkedListBox1.SetItemChecked(1, Boolean.Parse(item[5]));
                    checkedListBox1.SetItemChecked(2, Boolean.Parse(item[6]));
                    checkedListBox1.SetItemChecked(3, Boolean.Parse(item[7]));
                    checkedListBox1.SetItemChecked(4, Boolean.Parse(item[8]));
                    radioBelgIng.Checked = Boolean.Parse(item[9]);
                    radioMez.Checked = Boolean.Parse(item[10]);
                    comboBox1.SelectedIndex = Int32.Parse(item[11]);
                    checkEsCalısmıyor.Checked = Boolean.Parse(item[12]);
                    numeric06.Value = Int32.Parse(item[13]);
                    numeric718.Value = Int32.Parse(item[14]);
                    numericUni.Value = Int32.Parse(item[15]);
                    numericDiger.Value = Int32.Parse(item[16]);
                    labelKatsayi.Text = item[17];
                    labelUcret.Text = item[18];
                    break;
                }
            }
            maasHesapla();
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
                        MainVariables.salarylist = records;
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
                        foreach (var record in MainVariables.salarylist)
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

        void maasHesapla()
        {
            int maas = Int32.Parse(labelBaz.Text.Split(' ')[4]);
            katsayi = 1;

            //İl

            foreach (KeyValuePair<string, float> item in il)
            {
                if (item.Key == comboBox2.Text.ToLower())
                {
                    katsayi += item.Value;
                    break;
                }
            }

            //Deneyim

            if ((int)numericDeneyim.Value < 2)
            {
                katsayi += 0;
            }
            else if ((int)numericDeneyim.Value < 5)
            {
                katsayi += 0.6f;
            }
            else if ((int)numericDeneyim.Value < 10)
            {
                katsayi += 1;
            }
            else if ((int)numericDeneyim.Value < 15)
            {
                katsayi += 1.2f;
            }
            else if ((int)numericDeneyim.Value < 20)
            {
                katsayi += 1.35f;
            }
            else
            {
                katsayi += 1.5f;
            }

            //Eğitim
            // ilgili yüksek 0 doktora 1 doç 2 ilgisiz yüksek 3 dokdoç 4
            // 2 > 1 > 4 > 0 > 3

            if (checkedListBox1.GetItemChecked(2))
            {
                katsayi += 0.35f;
            }
            else if (checkedListBox1.GetItemChecked(1))
            {
                katsayi += 0.30f;
            }
            else if (checkedListBox1.GetItemChecked(4))
            {
                katsayi += 0.15f;
            }
            else if (checkedListBox1.GetItemChecked(0))
            {
                katsayi += 0.10f;
            }
            else if (checkedListBox1.GetItemChecked(3))
            {
                katsayi += 0.05f;
            }

            //Dil

            if (radioBelgIng.Checked || radioMez.Checked)
            {
                katsayi += 0.2f;
            }
            katsayi += (float)numericDiger.Value / 20;

            //Yöneticilik
            /*
                0 Yönetici görevi yok
                1 Takım Lideri
                2 Grup Yöneticisi
                3 Teknik Yönetici
                4 Yazılım Mimarı
                5 Proje Yöneticisi
                6 Direktör
                7 Projeler Yöneticisi
                8 CTO
                9 Genel Müdür
                10 Bilgi İşlem Sorumlusu (5 ve daha az personel)
                11 Bilgi İşlem Müdürü (5 ve daha az personel)
                12 Bilgi İşlem Sorumlusu (5'ten fazla personel)
                13 Bilgi İşlem Müdürü (5'ten fazla personel)
             */
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    katsayi += 0;
                    break;
                case 1:
                    katsayi += 0.5f;
                    break;
                case 2:
                    katsayi += 0.5f;
                    break;
                case 3:
                    katsayi += 0.5f;
                    break;
                case 4:
                    katsayi += 0.5f;
                    break;
                case 5:
                    katsayi += 0.75f;
                    break;
                case 6:
                    katsayi += 0.85f;
                    break;
                case 7:
                    katsayi += 0.85f;
                    break;
                case 8:
                    katsayi += 1;
                    break;
                case 9:
                    katsayi += 1;
                    break;
                case 10:
                    katsayi += 0.4f;
                    break;
                case 11:
                    katsayi += 0.4f;
                    break;
                case 12:
                    katsayi += 0.6f;
                    break;
                case 13:
                    katsayi += 0.6f;
                    break;
            }

            //Aile Durumu

            if (checkEsCalısmıyor.Checked)
            {
                katsayi += 0.2f;
            }
            cocuk.Clear();
            for (int i = 0; i < numeric06.Value; i++)
                cocuk.Add(5);
            for (int i = 0; i < numeric718.Value; i++)
                cocuk.Add(17);
            for (int i = 0; i < numericUni.Value; i++)
                cocuk.Add(22);
            int cocukSayisi = (int)numeric06.Value + (int)numeric718.Value + (int)numericUni.Value;
            bubbleSort(cocuk.ToArray(), cocukSayisi);
            if (cocukSayisi > 2)
            {
                switch (cocuk[cocukSayisi - 1])
                {
                    case 5:
                        katsayi += 0.2f;
                        break;
                    case 17:
                        katsayi += 0.30f;
                        break;
                    case 22:
                        katsayi += 0.4f;
                        break;
                }
                switch (cocuk[cocukSayisi - 2])
                {
                    case 5:
                        katsayi += 0.2f;
                        break;
                    case 17:
                        katsayi += 0.30f;
                        break;
                    case 22:
                        katsayi += 0.4f;
                        break;
                }

            }
            else
            {
                foreach (int item in cocuk)
                {
                    switch (item)
                    {
                        case 5:
                            katsayi += 0.2f;
                            break;
                        case 17:
                            katsayi += 0.30f;
                            break;
                        case 22:
                            katsayi += 0.4f;
                            break;
                    }
                }
            }
            labelKatsayi.Text = "Ücret katsayısı= " + katsayi.ToString();
            float son = maas * katsayi;
            if (MainVariables.user_type == "part-time user")
            {
                son = (maas * katsayi) / 2;
            }
            labelUcret.Text = "Alacağınız en az ücret= " + son.ToString() + " tl";

            bool found = false;
            foreach (List<string> item in MainVariables.salarylist)
            {
                if (item[0] == MainVariables.user_name)
                {
                    found = true;
                    MainVariables.salarylist.Remove(item);
                    MainVariables.salarylist.Add(new List<string> { MainVariables.user_name, comboBox2.Text, comboBox1.Text, numericDeneyim.Value.ToString(), checkedListBox1.GetItemChecked(0).ToString(), checkedListBox1.GetItemChecked(1).ToString(), checkedListBox1.GetItemChecked(2).ToString(), checkedListBox1.GetItemChecked(3).ToString(), checkedListBox1.GetItemChecked(4).ToString(), radioBelgIng.Checked.ToString(), radioMez.Checked.ToString(), comboBox1.SelectedIndex.ToString(), checkEsCalısmıyor.Checked.ToString(), numeric06.Value.ToString(), numeric718.Value.ToString(), numericUni.Value.ToString(), numericDiger.Value.ToString(), labelKatsayi.Text, labelUcret.Text });
                    break;
                }
            }
            if (!found)
            {
                MainVariables.salarylist.Add(new List<string> { MainVariables.user_name, comboBox2.Text, comboBox1.Text, numericDeneyim.Value.ToString(), checkedListBox1.GetItemChecked(0).ToString(), checkedListBox1.GetItemChecked(1).ToString(), checkedListBox1.GetItemChecked(2).ToString(), checkedListBox1.GetItemChecked(3).ToString(), checkedListBox1.GetItemChecked(4).ToString(), radioBelgIng.Checked.ToString(), radioMez.Checked.ToString(), comboBox1.SelectedIndex.ToString(), checkEsCalısmıyor.Checked.ToString(), numeric06.Value.ToString(), numeric718.Value.ToString(), numericUni.Value.ToString(), numericDiger.Value.ToString(), labelKatsayi.Text, labelUcret.Text });
            }
            writeCSV("salary.csv");
        }

        private void numericDeneyim_ValueChanged(object sender, EventArgs e)
        {
            maasHesapla();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            maasHesapla();
        }

        private void numericDiger_ValueChanged(object sender, EventArgs e)
        {
            maasHesapla();
        }

        private void radioBelgIng_CheckedChanged(object sender, EventArgs e)
        {
            maasHesapla();
        }

        private void radioMez_CheckedChanged(object sender, EventArgs e)
        {
            maasHesapla();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            maasHesapla();
        }

        private void checkEsCalısmıyor_CheckedChanged(object sender, EventArgs e)
        {
            maasHesapla();
        }

        private void numericCocuk_ValueChanged(object sender, EventArgs e)
        {
            maasHesapla();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            maasHesapla();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            maasHesapla();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static void bubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {

                        // Swap arr[j] and arr[j+1]
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were
                // swapped by inner loop, then break
                if (swapped == false)
                    break;
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "salary.csv");
            File.Copy("salary.csv", filePath, true);
        }
    }
}
