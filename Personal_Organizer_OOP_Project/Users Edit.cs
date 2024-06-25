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

namespace Personal_Organizer_OOP_Project
{
    public partial class Users_Edit : Form
    {
        string oldpassword;
        private TextBox activeTextBox;

        private int m_selected_index, currentPreWordsIndex;

        // string to hold previous texts in active textbox
        private List<string> preWords = new List<string>();

        Image pp;

        // Base64 format to image converter function
        public Image Base64ToImage(string b64string)
        {
            byte[] imageBytes = Convert.FromBase64String(b64string);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        // Image to Base64 format converter function
        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, format);
                    byte[] imageByte = ms.ToArray();
                    string b64string = Convert.ToBase64String(imageByte);
                    return b64string;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error converting image to base64", ex);
            }
        }
        public Users_Edit(int selected_index)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(UserInfo_KeyDown);
            preWords = new List<string>();
            m_selected_index = selected_index;
            cmbBox_userType.SelectedItem = MainVariables.personalsInfo[m_selected_index][0];
            txt_name.Text = MainVariables.personalsInfo[m_selected_index][1];
            txt_surname.Text = MainVariables.personalsInfo[m_selected_index][2];
            txt_username.Text = MainVariables.personalsInfo[m_selected_index][3];
            txt_phoneNumber.Text = MainVariables.personalsInfo[m_selected_index][4];
            txt_eMail.Text = MainVariables.personalsInfo[m_selected_index][5];
            txt_adresses.Text = MainVariables.personalsInfo[m_selected_index][6];
            txtPass.Text = MainVariables.personalsInfo[m_selected_index][7];
            oldpassword = MainVariables.personalsInfo[m_selected_index][7];

        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (MainVariables.personalsInfo.Where((person, index) => index != m_selected_index).Any(person => person[3] == txt_username.Text))
            {
                MessageBox.Show("This username is already in use please choose another one", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //7 personallerin bütün değişken tip sayısıdır.
            MainVariables.personalsInfo[m_selected_index][0] = cmbBox_userType.SelectedItem.ToString();
            MainVariables.personalsInfo[m_selected_index][1] = txt_name.Text;
            MainVariables.personalsInfo[m_selected_index][2] = txt_surname.Text;
            MainVariables.personalsInfo[m_selected_index][3] = txt_username.Text;
            MainVariables.personalsInfo[m_selected_index][4] = txt_phoneNumber.Text;
            MainVariables.personalsInfo[m_selected_index][5] = txt_eMail.Text;
            MainVariables.personalsInfo[m_selected_index][6] = txt_adresses.Text;
            MainVariables.personalsInfo[m_selected_index][7] = txtPass.Text;
            if (uploadedPhoto.BackgroundImage != null)
            {
                try
                {
                    using (var bitMap = new Bitmap(uploadedPhoto.BackgroundImage))
                    {
                        MainVariables.personalsInfo[m_selected_index][8] = ImageToBase64(bitMap, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a photo.", "Photo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MainVariables.writeCSV("personalsInfo.csv");
            if (oldpassword != txtPass.Text)
            {
                DialogResult result = MessageBox.Show("Do you want to send the new password as Email?", "Email", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Mails.sendMail(MainVariables.personalsInfo[m_selected_index][6], txtPass.Text);
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            this.Close();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_changePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|ALL Files(*.*)|*.";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Image pp = Image.FromFile(dialog.FileName);
                    uploadedPhoto.BackgroundImage = pp;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occurred!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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

        private void Users_Edit_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MainVariables.personalsInfo[m_selected_index][8]))
            {
                Image pp = Base64ToImage(MainVariables.personalsInfo[m_selected_index][8]);
                uploadedPhoto.BackgroundImage = pp;
            }
            else
            {
                uploadedPhoto.BackgroundImage = null;
            }
        }

        // Function to handle undo and redo
        private void UserInfo_KeyDown(object sender, KeyEventArgs eventArgs)
        {
            if (eventArgs.KeyCode == Keys.Space)
            {
                string temp = activeTextBox.Text;
                if (activeTextBox != null)
                {
                    string newWord = "";
                    int size = temp.Count();
                    for (int i = size - 1; i >= -1; i--)
                    {
                        if (i == -1 || temp[i] == ' ')
                        {
                            for (int j = currentPreWordsIndex + 1; j < preWords.Count() - 1; j++)
                            {
                                preWords.RemoveAt(j + 1);
                            }
                            preWords.Add(newWord);
                            currentPreWordsIndex = preWords.Count() - 1;
                            newWord = "";
                            break;
                        }
                        else
                        {
                            newWord = temp[i] + newWord;
                        }
                    }
                }
                activeTextBox.AppendText(" ");
            }
            if (eventArgs.Control && eventArgs.KeyCode == Keys.Z)
            {
                if (activeTextBox != null)
                {
                    if (preWords.Count() != 0 && currentPreWordsIndex > -1)
                    {
                        activeTextBox.Text = "";
                        for (int i = 0; i <= currentPreWordsIndex; i++)
                        {
                            activeTextBox.Text += preWords[i];
                            activeTextBox.Text += " ";
                        }
                        currentPreWordsIndex -= 1;
                        eventArgs.SuppressKeyPress = true;
                    }
                    else
                    {
                        MessageBox.Show("This field is empty or does not have undo functionality", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No active text box", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (eventArgs.Control && eventArgs.KeyCode == Keys.Y)
            {
                if (activeTextBox != null && preWords.Count > 0 && currentPreWordsIndex < preWords.Count() - 1)
                {
                    currentPreWordsIndex += 1;
                    activeTextBox.Text = "";
                    for (int i = 0; i <= currentPreWordsIndex; i++)
                    {
                        activeTextBox.Text += preWords[i];
                        activeTextBox.Text += " ";
                    }
                    eventArgs.SuppressKeyPress = true;
                }
                else if (activeTextBox == null)
                {
                    MessageBox.Show("No active text box", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("No actions to redo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Updates activeTextBox with current textbox 
        private void textBoxEnter(object sender, EventArgs e)
        {
            activeTextBox = sender as TextBox;
        }

        // Updates activeTextBox to null to prevent unnecessary changes
        private void textBoxLeave(object sender, EventArgs e)
        {
            if (activeTextBox == sender)
            {
                preWords.Clear();
                activeTextBox = null;
            }
        }
    }
}