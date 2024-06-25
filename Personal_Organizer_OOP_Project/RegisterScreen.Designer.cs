namespace Personal_Organizer_OOP_Project
{
    partial class RegisterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_backMenu = new System.Windows.Forms.PictureBox();
            this.btn_quit = new System.Windows.Forms.PictureBox();
            this.B = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_adresses = new System.Windows.Forms.TextBox();
            this.txt_eMail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btn_uploadPhoto = new System.Windows.Forms.Button();
            this.show_photo = new System.Windows.Forms.PictureBox();
            this.txt_phoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_backMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btn_backMenu);
            this.panel1.Controls.Add(this.btn_quit);
            this.panel1.Controls.Add(this.B);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 76);
            this.panel1.TabIndex = 0;
            // 
            // btn_backMenu
            // 
            this.btn_backMenu.Image = global::Personal_Organizer_OOP_Project.Properties.Resources.Go_Back;
            this.btn_backMenu.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_backMenu.InitialImage")));
            this.btn_backMenu.Location = new System.Drawing.Point(331, 6);
            this.btn_backMenu.Name = "btn_backMenu";
            this.btn_backMenu.Size = new System.Drawing.Size(23, 22);
            this.btn_backMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_backMenu.TabIndex = 13;
            this.btn_backMenu.TabStop = false;
            this.btn_backMenu.Click += new System.EventHandler(this.btn_backMenu_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Image = global::Personal_Organizer_OOP_Project.Properties.Resources.bb;
            this.btn_quit.InitialImage = global::Personal_Organizer_OOP_Project.Properties.Resources.bb;
            this.btn_quit.Location = new System.Drawing.Point(354, 0);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(51, 33);
            this.btn_quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quit.TabIndex = 12;
            this.btn_quit.TabStop = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B.ForeColor = System.Drawing.Color.White;
            this.B.Location = new System.Drawing.Point(86, 25);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(225, 26);
            this.B.TabIndex = 11;
            this.B.Text = "User Management";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Personal_Organizer_OOP_Project.Properties.Resources.Bir_başlık_ekleyin;
            this.pictureBox2.InitialImage = global::Personal_Organizer_OOP_Project.Properties.Resources.Adsız_tasarım__26_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 79);
            this.panel2.TabIndex = 1;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.LightGreen;
            this.btn_register.Location = new System.Drawing.Point(263, 452);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(104, 36);
            this.btn_register.TabIndex = 13;
            this.btn_register.Text = "REGISTER";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 118);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(355, 22);
            this.txt_name.TabIndex = 15;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone Number:";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(12, 167);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(355, 22);
            this.txt_surname.TabIndex = 19;
            this.txt_surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_surname_KeyPress);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(12, 216);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(355, 22);
            this.txt_username.TabIndex = 20;
            this.txt_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_username_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Adresses:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Password:";
            // 
            // txt_adresses
            // 
            this.txt_adresses.Location = new System.Drawing.Point(12, 314);
            this.txt_adresses.Name = "txt_adresses";
            this.txt_adresses.Size = new System.Drawing.Size(355, 22);
            this.txt_adresses.TabIndex = 25;
            // 
            // txt_eMail
            // 
            this.txt_eMail.Location = new System.Drawing.Point(12, 363);
            this.txt_eMail.Name = "txt_eMail";
            this.txt_eMail.Size = new System.Drawing.Size(355, 22);
            this.txt_eMail.TabIndex = 26;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(12, 421);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(355, 22);
            this.txtPass.TabIndex = 27;
            // 
            // btn_uploadPhoto
            // 
            this.btn_uploadPhoto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uploadPhoto.Location = new System.Drawing.Point(12, 446);
            this.btn_uploadPhoto.Name = "btn_uploadPhoto";
            this.btn_uploadPhoto.Size = new System.Drawing.Size(145, 46);
            this.btn_uploadPhoto.TabIndex = 28;
            this.btn_uploadPhoto.Text = "Add Photo";
            this.btn_uploadPhoto.UseVisualStyleBackColor = true;
            this.btn_uploadPhoto.Click += new System.EventHandler(this.btn_uploadPhoto_Click);
            // 
            // show_photo
            // 
            this.show_photo.Location = new System.Drawing.Point(163, 446);
            this.show_photo.Name = "show_photo";
            this.show_photo.Size = new System.Drawing.Size(52, 46);
            this.show_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show_photo.TabIndex = 29;
            this.show_photo.TabStop = false;
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(12, 264);
            this.txt_phoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phoneNumber.Mask = "(000) 000 00 00";
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(355, 22);
            this.txt_phoneNumber.TabIndex = 30;
            this.txt_phoneNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // RegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 580);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.show_photo);
            this.Controls.Add(this.btn_uploadPhoto);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txt_eMail);
            this.Controls.Add(this.txt_adresses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_backMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.PictureBox btn_quit;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_adresses;
        private System.Windows.Forms.TextBox txt_eMail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btn_uploadPhoto;
        private System.Windows.Forms.PictureBox show_photo;
        private System.Windows.Forms.PictureBox btn_backMenu;
        private System.Windows.Forms.MaskedTextBox txt_phoneNumber;
    }
}