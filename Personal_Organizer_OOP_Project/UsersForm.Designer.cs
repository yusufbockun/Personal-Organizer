namespace Personal_Organizer_OOP_Project
{
    partial class UsersForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_mngUser = new System.Windows.Forms.Button();
            this.btEditOwnInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_users = new System.Windows.Forms.Label();
            this.lstView_user_info = new System.Windows.Forms.ListView();
            this.col_userType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_userName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDown = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.buttonDown);
            this.panel1.Controls.Add(this.btn_mngUser);
            this.panel1.Controls.Add(this.btEditOwnInfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 74);
            this.panel1.TabIndex = 0;
            // 
            // btn_mngUser
            // 
            this.btn_mngUser.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_mngUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_mngUser.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mngUser.ForeColor = System.Drawing.Color.White;
            this.btn_mngUser.Location = new System.Drawing.Point(540, 0);
            this.btn_mngUser.Name = "btn_mngUser";
            this.btn_mngUser.Size = new System.Drawing.Size(130, 74);
            this.btn_mngUser.TabIndex = 4;
            this.btn_mngUser.Text = "Edit";
            this.btn_mngUser.UseVisualStyleBackColor = false;
            this.btn_mngUser.Click += new System.EventHandler(this.btn_mngUser_Click);
            // 
            // btEditOwnInfo
            // 
            this.btEditOwnInfo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btEditOwnInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btEditOwnInfo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btEditOwnInfo.ForeColor = System.Drawing.Color.White;
            this.btEditOwnInfo.Location = new System.Drawing.Point(670, 0);
            this.btEditOwnInfo.Name = "btEditOwnInfo";
            this.btEditOwnInfo.Size = new System.Drawing.Size(130, 74);
            this.btEditOwnInfo.TabIndex = 5;
            this.btEditOwnInfo.Text = "Edit";
            this.btEditOwnInfo.UseVisualStyleBackColor = false;
            this.btEditOwnInfo.Click += new System.EventHandler(this.btEditOwnInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "MANAGE USER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.lbl_users);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 46);
            this.panel2.TabIndex = 1;
            // 
            // lbl_users
            // 
            this.lbl_users.AutoSize = true;
            this.lbl_users.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_users.ForeColor = System.Drawing.Color.White;
            this.lbl_users.Location = new System.Drawing.Point(3, 9);
            this.lbl_users.Name = "lbl_users";
            this.lbl_users.Size = new System.Drawing.Size(65, 23);
            this.lbl_users.TabIndex = 5;
            this.lbl_users.Text = "USERS";
            // 
            // lstView_user_info
            // 
            this.lstView_user_info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_userType,
            this.col_name,
            this.col_surname,
            this.col_userName,
            this.col_phoneNumber,
            this.col_adress,
            this.col_mail});
            this.lstView_user_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstView_user_info.FullRowSelect = true;
            this.lstView_user_info.GridLines = true;
            this.lstView_user_info.HideSelection = false;
            this.lstView_user_info.Location = new System.Drawing.Point(0, 46);
            this.lstView_user_info.Name = "lstView_user_info";
            this.lstView_user_info.Size = new System.Drawing.Size(800, 330);
            this.lstView_user_info.TabIndex = 2;
            this.lstView_user_info.UseCompatibleStateImageBehavior = false;
            this.lstView_user_info.View = System.Windows.Forms.View.Details;
            // 
            // col_userType
            // 
            this.col_userType.Text = "User Type";
            this.col_userType.Width = 110;
            // 
            // col_name
            // 
            this.col_name.Text = "Name";
            this.col_name.Width = 110;
            // 
            // col_surname
            // 
            this.col_surname.Text = "Surname";
            this.col_surname.Width = 110;
            // 
            // col_userName
            // 
            this.col_userName.Text = "User Name";
            this.col_userName.Width = 110;
            // 
            // col_phoneNumber
            // 
            this.col_phoneNumber.Text = "Phone Number";
            this.col_phoneNumber.Width = 110;
            // 
            // col_adress
            // 
            this.col_adress.Text = "Adresses";
            this.col_adress.Width = 110;
            // 
            // col_mail
            // 
            this.col_mail.Text = "E-Mail";
            this.col_mail.Width = 110;
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDown.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDown.ForeColor = System.Drawing.Color.White;
            this.buttonDown.Location = new System.Drawing.Point(410, 0);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(130, 74);
            this.buttonDown.TabIndex = 6;
            this.buttonDown.Text = "Download";
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Visible = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstView_user_info);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstView_user_info;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_surname;
        private System.Windows.Forms.ColumnHeader col_userName;
        private System.Windows.Forms.ColumnHeader col_phoneNumber;
        private System.Windows.Forms.ColumnHeader col_adress;
        private System.Windows.Forms.ColumnHeader col_mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mngUser;
        private System.Windows.Forms.Label lbl_users;
        private System.Windows.Forms.ColumnHeader col_userType;
        private System.Windows.Forms.Button btEditOwnInfo;
        private System.Windows.Forms.Button buttonDown;
    }
}