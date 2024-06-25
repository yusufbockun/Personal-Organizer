using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organizer_OOP_Project
{
    public partial class UserInfo : Form
    {
        private TextBox activeTextBox;

        private int inf_selected_index, currentPreWordsIndex;

        // string to hold previous texts in active textbox
        private List<string> preWords = new List<string>();

        // Base64 to image converter function
        public Image Base64ToImage(string b64string)
        {
            byte[] imageBytes = Convert.FromBase64String(b64string);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        // Image to Base64 converter function
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

        // Function to handle undo and redo
        private void UserInfo_KeyDown(object sender, KeyEventArgs eventArgs)
        {
            if (eventArgs.KeyCode == Keys.Space)
            {
                string temp = activeTextBox.Text;
                if (activeTextBox != null && temp[temp.Count() - 1] != ' ')
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

        public UserInfo(int selected_index)
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(UserInfo_KeyDown);
            preWords = new List<string>();


            inf_selected_index = selected_index;
            tbName.Text = MainVariables.personalsInfo[inf_selected_index][1];
            tbSurname.Text = MainVariables.personalsInfo[inf_selected_index][2];
            tbUsername.Text = MainVariables.personalsInfo[inf_selected_index][3];
            tbPhone.Text = MainVariables.personalsInfo[inf_selected_index][4];
            tbMail.Text = MainVariables.personalsInfo[inf_selected_index][5];
            tbAddress.Text = MainVariables.personalsInfo[inf_selected_index][6];
            tbPassword.Text = MainVariables.personalsInfo[inf_selected_index][7];
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            Image pp = Base64ToImage(MainVariables.personalsInfo[inf_selected_index][8]);
            pb1.BackgroundImage = pp;
        }

        // Saves variables if everything is in order
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text) &&
                !string.IsNullOrWhiteSpace(tbSurname.Text) &&
                !string.IsNullOrWhiteSpace(tbUsername.Text) &&
                !string.IsNullOrWhiteSpace(tbPhone.Text) &&
                !string.IsNullOrWhiteSpace(tbAddress.Text) &&
                !string.IsNullOrWhiteSpace(tbMail.Text) &&
                !string.IsNullOrWhiteSpace(tbPassword.Text) &&
                pb1.BackgroundImage != null)
            {
                if (MainVariables.personalsInfo.Where((person, index) => index != inf_selected_index).Any(person => person[3] == tbUsername.Text))
                {
                    MessageBox.Show("This username is already in use please choose another one", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MainVariables.personalsInfo[inf_selected_index][1] = tbName.Text;
                MainVariables.personalsInfo[inf_selected_index][2] = tbSurname.Text;
                MainVariables.personalsInfo[inf_selected_index][3] = tbUsername.Text;
                MainVariables.personalsInfo[inf_selected_index][4] = tbPhone.Text;
                MainVariables.personalsInfo[inf_selected_index][5] = tbMail.Text;
                MainVariables.personalsInfo[inf_selected_index][6] = tbAddress.Text;
                MainVariables.personalsInfo[inf_selected_index][7] = tbPassword.Text;
                if (pb1.BackgroundImage != null)
                {
                    try
                    {
                        using (var bitMap = new Bitmap(pb1.BackgroundImage))
                        {
                            MainVariables.personalsInfo[inf_selected_index][8] = ImageToBase64(bitMap, System.Drawing.Imaging.ImageFormat.Jpeg);
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
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill all the fields to save successfully!", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Updates profile photo
        private void btnPP_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files | *.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb1.BackgroundImage = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}