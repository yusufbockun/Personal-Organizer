using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organizer_OOP_Project
{
    public partial class MainForm : Form
    {
        private Timer reminderTimer;
        public MainForm()
        {
            InitializeComponent();
            btn_notes.FlatAppearance.BorderSize = 0;
            btn_phonebook.FlatAppearance.BorderSize = 0;
            btn_salary.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            Reminder reminder = new Reminder();
            reminderTimer = new Timer();
            reminderTimer.Interval = 1000;
            reminderTimer.Tick += reminder.ReminderTimer_Tick;
            reminderTimer.Start();
            Reminder reminder1 = new Reminder();
            reminder1.Show();
            reminder1.Close();
        }
        public void setReminderLabel(string label)
        {
            label1.Text = label;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm!= null) activeForm.Close();
            activeForm= childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            pnl_main.Controls.Add(childForm);
            pnl_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            openChildForm(new UsersForm());
            
        }

        private void btn_backMenu_Click(object sender, EventArgs e)
        {
            MainVariables.all_Quit = false;
            MainVariables.menuQuit = false;
            this.Close();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure about exiting this masterpiece ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MainVariables.all_Quit = true;
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Phonebook());
        }

        private void btn_notes_Click(object sender, EventArgs e)
        {
            openChildForm(new Notes());
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            openChildForm(new Salary_Calc());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Mails());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Reminder());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
