namespace Personal_Organizer_OOP_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.B = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salary = new System.Windows.Forms.Button();
            this.btn_notes = new System.Windows.Forms.Button();
            this.lbl_out = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.btn_phonebook = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.PictureBox();
            this.btn_backMenu = new System.Windows.Forms.PictureBox();
            this.btn_users = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_backMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B.ForeColor = System.Drawing.Color.MidnightBlue;
            this.B.Location = new System.Drawing.Point(89, 39);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(210, 29);
            this.B.TabIndex = 12;
            this.B.Text = "User Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_salary);
            this.panel1.Controls.Add(this.btn_notes);
            this.panel1.Controls.Add(this.btn_phonebook);
            this.panel1.Controls.Add(this.btn_quit);
            this.panel1.Controls.Add(this.lbl_out);
            this.panel1.Controls.Add(this.btn_backMenu);
            this.panel1.Controls.Add(this.btn_users);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.B);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 102);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Personal_Organizer_OOP_Project.Properties.Resources.icons8_reminder_96;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(951, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 53);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Personal_Organizer_OOP_Project.Properties.Resources.icons8_mail_96;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(831, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 53);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_salary
            // 
            this.btn_salary.BackgroundImage = global::Personal_Organizer_OOP_Project.Properties.Resources.icons8_salary_96;
            this.btn_salary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salary.Location = new System.Drawing.Point(711, 29);
            this.btn_salary.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Size = new System.Drawing.Size(54, 53);
            this.btn_salary.TabIndex = 18;
            this.btn_salary.UseVisualStyleBackColor = true;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // btn_notes
            // 
            this.btn_notes.BackgroundImage = global::Personal_Organizer_OOP_Project.Properties.Resources.icons8_notes_64;
            this.btn_notes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notes.Location = new System.Drawing.Point(591, 29);
            this.btn_notes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_notes.Name = "btn_notes";
            this.btn_notes.Size = new System.Drawing.Size(54, 53);
            this.btn_notes.TabIndex = 17;
            this.btn_notes.UseVisualStyleBackColor = true;
            this.btn_notes.Click += new System.EventHandler(this.btn_notes_Click);
            // 
            // lbl_out
            // 
            this.lbl_out.AutoSize = true;
            this.lbl_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_out.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_out.Location = new System.Drawing.Point(1175, 85);
            this.lbl_out.Name = "lbl_out";
            this.lbl_out.Size = new System.Drawing.Size(66, 16);
            this.lbl_out.TabIndex = 15;
            this.lbl_out.Text = "LOG OUT";
            // 
            // pnl_main
            // 
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 102);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1251, 651);
            this.pnl_main.TabIndex = 14;
            // 
            // btn_phonebook
            // 
            this.btn_phonebook.BackgroundImage = global::Personal_Organizer_OOP_Project.Properties.Resources.icons8_phone_book_96;
            this.btn_phonebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_phonebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_phonebook.Location = new System.Drawing.Point(471, 29);
            this.btn_phonebook.Margin = new System.Windows.Forms.Padding(4);
            this.btn_phonebook.Name = "btn_phonebook";
            this.btn_phonebook.Size = new System.Drawing.Size(54, 53);
            this.btn_phonebook.TabIndex = 16;
            this.btn_phonebook.UseVisualStyleBackColor = true;
            this.btn_phonebook.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Image = global::Personal_Organizer_OOP_Project.Properties.Resources.bb;
            this.btn_quit.InitialImage = global::Personal_Organizer_OOP_Project.Properties.Resources.bb;
            this.btn_quit.Location = new System.Drawing.Point(1201, 1);
            this.btn_quit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(51, 33);
            this.btn_quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quit.TabIndex = 15;
            this.btn_quit.TabStop = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_backMenu
            // 
            this.btn_backMenu.Image = global::Personal_Organizer_OOP_Project.Properties.Resources.Go_Back;
            this.btn_backMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_backMenu.InitialImage")));
            this.btn_backMenu.Location = new System.Drawing.Point(1201, 39);
            this.btn_backMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_backMenu.Name = "btn_backMenu";
            this.btn_backMenu.Size = new System.Drawing.Size(35, 43);
            this.btn_backMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_backMenu.TabIndex = 14;
            this.btn_backMenu.TabStop = false;
            this.btn_backMenu.Click += new System.EventHandler(this.btn_backMenu_Click);
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.Transparent;
            this.btn_users.Image = global::Personal_Organizer_OOP_Project.Properties.Resources.Bir_başlık_ekleyin1;
            this.btn_users.InitialImage = global::Personal_Organizer_OOP_Project.Properties.Resources.Adsız_tasarım__26_;
            this.btn_users.Location = new System.Drawing.Point(351, 29);
            this.btn_users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(56, 53);
            this.btn_users.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_users.TabIndex = 13;
            this.btn_users.TabStop = false;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox2.Image = global::Personal_Organizer_OOP_Project.Properties.Resources.Bir_başlık_ekleyin;
            this.pictureBox2.InitialImage = global::Personal_Organizer_OOP_Project.Properties.Resources.Adsız_tasarım__26_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 753);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_backMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_users;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_out;
        private System.Windows.Forms.PictureBox btn_backMenu;
        private System.Windows.Forms.PictureBox btn_quit;
        private System.Windows.Forms.Button btn_phonebook;
        private System.Windows.Forms.Button btn_notes;
        private System.Windows.Forms.Button btn_salary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}