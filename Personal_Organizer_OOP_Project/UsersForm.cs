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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            MainVariables.readCSV("personalsInfo.csv");

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            update_users();

            if (MainVariables.user_type == "admin")
            {
                btn_mngUser.Enabled = true;
                btEditOwnInfo.Enabled = false;
                btEditOwnInfo.Hide();
                buttonDown.Enabled = true;
                buttonDown.Show();
            }
            else
            {
                btn_mngUser.Enabled = false;
                btn_mngUser.Hide();
            }

        }

        private void update_users()
        {
            lstView_user_info.Items.Clear();

            foreach(var user in MainVariables.personalsInfo)
            {

                ListViewItem item=new ListViewItem(user[0]);
                for(int i=1;i<user.Count-1;i++)
                {
                    item.SubItems.Add(user[i]);
                }
                lstView_user_info.Items.Add(item);

            }
        }

        private void btn_mngUser_Click(object sender, EventArgs e)
        {


                // Seçili eleman var mı kontrol et
                if (lstView_user_info.SelectedItems.Count > 0)
                {
                    // Seçili elemanın indeksini al
                    int selectedIndex = lstView_user_info.SelectedItems[0].Index;

                    // Burada indeksi kullanarak gerekli işlemleri yapabilirsin
                    // Örneğin, bir edit formunu açabilir ve seçili elemanın bilgilerini gösterebilirsin
                    Users_Edit users_edit=new Users_Edit(selectedIndex);
                    users_edit.ShowDialog();
                update_users();
                }
                else
                {
                    // Seçili eleman yoksa kullanıcıya uyarı göster
                    MessageBox.Show("Please select a profile");
                }
            }

        private void btEditOwnInfo_Click(object sender, EventArgs e)
        {
            if (lstView_user_info.SelectedItems.Count > 0)
            {

                int inf_selected_index = lstView_user_info.SelectedItems[0].Index;
                if (MainVariables.personalsInfo[inf_selected_index][3] == MainVariables.user_name)
                {
                    UserInfo userInfo = new UserInfo(inf_selected_index);
                    userInfo.ShowDialog();
                    update_users();
                }
                else
                {
                    MessageBox.Show("Only admins can edit other profiles", "Unauthorized Edit Attemp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                // Seçili eleman yoksa kullanıcıya uyarı göster
                MessageBox.Show("Please select a profile");
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "personalsInfo.csv");
            File.Copy("personalsInfo.csv", filePath, true);
        }
    }
}

