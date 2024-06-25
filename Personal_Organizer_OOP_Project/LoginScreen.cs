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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure about exiting this masterpiece ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MainVariables.menuQuit = true;
                MainVariables.all_Quit = true;
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void chkBox_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtBox_pass.UseSystemPasswordChar= !txtBox_pass.UseSystemPasswordChar;
        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            MainVariables.registerScreenIsOpen= true;

            this.Close();

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            bool personHasAccount = false;
            foreach (var personal_infos in MainVariables.personalsInfo)
            {

                 //3. index personalın username'ine denk geliyor
                 //7.index personalın passwword'üne denk geliyor
                if (personal_infos[3] == txtBox_userName.Text && personal_infos[7] == txtBox_pass.Text)
                {
                    //personal kayıtlı
                    personHasAccount=true;
                    //user_type ı personal info olarak belirledik
                    MainVariables.user_type= personal_infos[0];
                    MainVariables.user_name = personal_infos[3];
                    MainVariables.email = personal_infos[6];
                    break;
                }
            }

            if (personHasAccount)
            {
                MainVariables.menuQuit = true;
                this.Close();
            }

            else
            {
                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtBox_userName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)&& !char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }
        private void readCSV(string filename)
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
                        MainVariables.personalsInfo = records;
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


    }
}
