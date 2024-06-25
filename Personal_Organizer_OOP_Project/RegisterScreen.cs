using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Personal_Organizer_OOP_Project
{
    public partial class RegisterScreen : Form
    {
        string imageLocation;

        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageByte = ms.ToArray();
                string b64string = Convert.ToBase64String(imageByte);
                return b64string;
            }
        }


        public RegisterScreen()
        {
            InitializeComponent();
            imageLocation = "";
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {

            MainVariables.menuQuit = true;
            MainVariables.all_Quit= true;
            
            this.Close();
        }

        private void btn_backMenu_Click(object sender, EventArgs e)
        {
            MainVariables.registerScreenIsOpen = false;

            this.Close();

        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled= true;
            }
        }


        private void txt_surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool IsValidEmail(string email)
        {
            // Regex pattern for valid email address
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // Tüm metin kutularının dolu olup olmadığını kontrol et
            if (!string.IsNullOrWhiteSpace(txt_name.Text) &&
                !string.IsNullOrWhiteSpace(txt_surname.Text) &&
                !string.IsNullOrWhiteSpace(txt_username.Text) &&
                txt_phoneNumber.Text.Length == 15 &&
                !string.IsNullOrWhiteSpace(txt_adresses.Text) &&
                IsValidEmail(txt_eMail.Text) &&
                !string.IsNullOrWhiteSpace(txtPass.Text)&&
                imageLocation!=""
                )
            {



                // Eğer personalInfo listesi boşsa veya null ise, başlat ve ilk kullanıcıyı ekle
                if (MainVariables.personalsInfo == null || MainVariables.personalsInfo.Count == 0)
                {
                    MainVariables.personalsInfo = new List<List<string>>()
                {
                new List<string>(){"admin",txt_name.Text, txt_surname.Text, txt_username.Text, txt_phoneNumber.Text, txt_adresses.Text, txt_eMail.Text, txtPass.Text,imageLocation}
            };
                    MessageBox.Show("Successfully registered.", "Register", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    MainVariables.writeCSV("personalsInfo.csv");
                    MainVariables.registerScreenIsOpen = false;
                    this.Close();
                }
                else
                {

                   if(MainVariables.personalsInfo.Any(person => person[3] == txt_username.Text))
                    {
                        MessageBox.Show("This username is already in use please choose another one", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Listeye yeni kullanıcıyı ekle
                    MainVariables.personalsInfo.Add(new List<string>() {"user",txt_name.Text, txt_surname.Text, txt_username.Text, txt_phoneNumber.Text, txt_adresses.Text, txt_eMail.Text, txtPass.Text,imageLocation });
                    MessageBox.Show("Successfully registered.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainVariables.writeCSV("personalsInfo.csv");

                    MainVariables.registerScreenIsOpen = false;
                    this.Close();
                }
            }
            else
            {
                // Eğer herhangi bir metin kutusu boşsa, kullanıcıya bir mesaj göster
                MessageBox.Show("Please fill every box correctly.", "Missing or incorrect info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_uploadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog= new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|ALL Files(*.*)|*.";
                if(dialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    Image pp = Image.FromFile(dialog.FileName);
                    imageLocation = ImageToBase64(pp, System.Drawing.Imaging.ImageFormat.Jpeg);
                    show_photo.ImageLocation = dialog.FileName;
                    
                }
                
            }
            catch(Exception)
            { 
            MessageBox.Show("An Error Occurred!!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }


}
