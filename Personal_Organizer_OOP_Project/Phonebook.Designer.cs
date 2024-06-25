namespace Personal_Organizer_OOP_Project
{
    partial class Phonebook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnreg = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDown = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(1252, 55);
            this.panel2.TabIndex = 2;
            // 
            // Labelc5
            // 
            this.Labelc5.AutoSize = true;
            this.Labelc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Labelc5.ForeColor = System.Drawing.Color.White;
            this.Labelc5.Location = new System.Drawing.Point(15, 11);
            this.Labelc5.Name = "Labelc5";
            this.Labelc5.Size = new System.Drawing.Size(145, 29);
            this.Labelc5.TabIndex = 15;
            this.Labelc5.Text = "Phone Book";
            // 
            // btn_quit
            // 
            this.btn_quit.Image = global::Personal_Organizer_OOP_Project.Properties.Resources.bb;
            this.btn_quit.InitialImage = global::Personal_Organizer_OOP_Project.Properties.Resources.bb;
            this.btn_quit.Location = new System.Drawing.Point(1201, 2);
            this.btn_quit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(51, 33);
            this.btn_quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quit.TabIndex = 13;
            this.btn_quit.TabStop = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adsoyad,
            this.email,
            this.telefon,
            this.adres});
            this.dataGridView1.Location = new System.Drawing.Point(0, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(869, 448);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // adsoyad
            // 
            this.adsoyad.HeaderText = "Name\\Surname";
            this.adsoyad.MinimumWidth = 6;
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.ReadOnly = true;
            this.adsoyad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.adsoyad.Width = 150;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // telefon
            // 
            this.telefon.HeaderText = "Phone Number";
            this.telefon.MinimumWidth = 6;
            this.telefon.Name = "telefon";
            this.telefon.Width = 150;
            // 
            // adres
            // 
            this.adres.HeaderText = "Address";
            this.adres.MinimumWidth = 6;
            this.adres.Name = "adres";
            this.adres.Width = 150;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(929, 146);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(929, 204);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(929, 334);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(265, 22);
            this.textBox4.TabIndex = 8;
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(1096, 468);
            this.btnreg.Margin = new System.Windows.Forms.Padding(4);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(100, 28);
            this.btnreg.TabIndex = 9;
            this.btnreg.Text = "Create";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(16, 528);
            this.btndel.Margin = new System.Windows.Forms.Padding(4);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(100, 28);
            this.btndel.TabIndex = 10;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(124, 528);
            this.btnup.Margin = new System.Windows.Forms.Padding(4);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(100, 28);
            this.btnup.TabIndex = 11;
            this.btnup.Text = "Update";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(929, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad\\Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(929, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(929, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(929, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Address";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(929, 274);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Mask = "(000) 000 00 00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(265, 22);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 598);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 75);
            this.panel1.TabIndex = 17;
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(232, 528);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(100, 28);
            this.buttonDown.TabIndex = 18;
            this.buttonDown.Text = "Download";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Visible = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // Phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 673);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Phonebook";
            this.Text = "Phonebook";
            this.Load += new System.EventHandler(this.Phonebook_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
        private System.Windows.Forms.PictureBox btn_quit;
        private System.Windows.Forms.Label Labelc5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDown;
    }
}