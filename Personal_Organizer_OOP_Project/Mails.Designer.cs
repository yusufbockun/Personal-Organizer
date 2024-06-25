namespace Personal_Organizer_OOP_Project
{
    partial class Mails
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Labelc5 = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.textBoxFromToWho = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonMarkRead = new System.Windows.Forms.Button();
            this.buttonMarkUnread = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.Labelc5);
            this.panel2.Controls.Add(this.btn_quit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 55);
            this.panel2.TabIndex = 4;
            // 
            // Labelc5
            // 
            this.Labelc5.AutoSize = true;
            this.Labelc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Labelc5.ForeColor = System.Drawing.Color.White;
            this.Labelc5.Location = new System.Drawing.Point(15, 11);
            this.Labelc5.Name = "Labelc5";
            this.Labelc5.Size = new System.Drawing.Size(70, 29);
            this.Labelc5.TabIndex = 15;
            this.Labelc5.Text = "Mails";
            // 
            // btn_quit
            // 
            this.btn_quit.Image = global::Personal_Organizer_OOP_Project.Properties.Resources.bb;
            this.btn_quit.InitialImage = global::Personal_Organizer_OOP_Project.Properties.Resources.bb;
            this.btn_quit.Location = new System.Drawing.Point(1199, 11);
            this.btn_quit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(51, 33);
            this.btn_quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quit.TabIndex = 13;
            this.btn_quit.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 575);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 75);
            this.panel1.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(20, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(957, 466);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMail.Location = new System.Drawing.Point(20, 165);
            this.textBoxMail.Multiline = true;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(957, 384);
            this.textBoxMail.TabIndex = 11;
            this.textBoxMail.Visible = false;
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAbout.Location = new System.Drawing.Point(20, 81);
            this.textBoxAbout.Multiline = true;
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.Size = new System.Drawing.Size(957, 42);
            this.textBoxAbout.TabIndex = 12;
            this.textBoxAbout.Visible = false;
            // 
            // textBoxFromToWho
            // 
            this.textBoxFromToWho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFromToWho.Location = new System.Drawing.Point(20, 123);
            this.textBoxFromToWho.Multiline = true;
            this.textBoxFromToWho.Name = "textBoxFromToWho";
            this.textBoxFromToWho.Size = new System.Drawing.Size(957, 42);
            this.textBoxFromToWho.TabIndex = 13;
            this.textBoxFromToWho.Visible = false;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(1001, 81);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(204, 103);
            this.buttonRead.TabIndex = 18;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1001, 444);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(204, 103);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonMarkRead
            // 
            this.buttonMarkRead.Location = new System.Drawing.Point(1001, 202);
            this.buttonMarkRead.Name = "buttonMarkRead";
            this.buttonMarkRead.Size = new System.Drawing.Size(204, 103);
            this.buttonMarkRead.TabIndex = 15;
            this.buttonMarkRead.Text = "Mark as read";
            this.buttonMarkRead.UseVisualStyleBackColor = true;
            this.buttonMarkRead.Click += new System.EventHandler(this.buttonMarkRead_Click);
            // 
            // buttonMarkUnread
            // 
            this.buttonMarkUnread.Location = new System.Drawing.Point(1001, 323);
            this.buttonMarkUnread.Name = "buttonMarkUnread";
            this.buttonMarkUnread.Size = new System.Drawing.Size(204, 103);
            this.buttonMarkUnread.TabIndex = 17;
            this.buttonMarkUnread.Text = "Mark as unread";
            this.buttonMarkUnread.UseVisualStyleBackColor = true;
            this.buttonMarkUnread.Click += new System.EventHandler(this.buttonMarkUnread_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(1001, 81);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(204, 103);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Mails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 650);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonMarkRead);
            this.Controls.Add(this.buttonMarkUnread);
            this.Controls.Add(this.textBoxFromToWho);
            this.Controls.Add(this.textBoxAbout);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Mails";
            this.Text = "Mails";
            this.Load += new System.EventHandler(this.Mails_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Labelc5;
        private System.Windows.Forms.PictureBox btn_quit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.TextBox textBoxFromToWho;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonMarkRead;
        private System.Windows.Forms.Button buttonMarkUnread;
        private System.Windows.Forms.Button buttonBack;
    }
}