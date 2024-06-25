namespace Personal_Organizer_OOP_Project
{
    partial class Reminder
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
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbReminderType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.lblReminder = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.listViewReminders = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Labelc5 = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.PictureBox();
            this.buttonDown = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSummary
            // 
            this.txtSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSummary.Location = new System.Drawing.Point(176, 434);
            this.txtSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(288, 28);
            this.txtSummary.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Location = new System.Drawing.Point(176, 492);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(288, 28);
            this.txtDescription.TabIndex = 2;
            // 
            // datePicker
            // 
            this.datePicker.Checked = false;
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datePicker.Location = new System.Drawing.Point(176, 306);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 28);
            this.datePicker.TabIndex = 3;
            // 
            // cmbReminderType
            // 
            this.cmbReminderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbReminderType.FormattingEnabled = true;
            this.cmbReminderType.Location = new System.Drawing.Point(176, 374);
            this.cmbReminderType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbReminderType.Name = "cmbReminderType";
            this.cmbReminderType.Size = new System.Drawing.Size(121, 30);
            this.cmbReminderType.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 227);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 65);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(46, 75);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 65);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(46, 151);
            this.btnClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(123, 65);
            this.btnClick.TabIndex = 7;
            this.btnClick.Text = "Delete";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReminder.Location = new System.Drawing.Point(172, 349);
            this.lblReminder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(127, 20);
            this.lblReminder.TabIndex = 8;
            this.lblReminder.Text = "Reminder Type:";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSummary.Location = new System.Drawing.Point(172, 409);
            this.lblSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(85, 20);
            this.lblSummary.TabIndex = 9;
            this.lblSummary.Text = "Summary:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(172, 467);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 20);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description:";
            // 
            // timePicker
            // 
            this.timePicker.Checked = false;
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timePicker.Location = new System.Drawing.Point(415, 306);
            this.timePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(200, 28);
            this.timePicker.TabIndex = 11;
            // 
            // listViewReminders
            // 
            this.listViewReminders.HideSelection = false;
            this.listViewReminders.Location = new System.Drawing.Point(176, 75);
            this.listViewReminders.Margin = new System.Windows.Forms.Padding(4);
            this.listViewReminders.Name = "listViewReminders";
            this.listViewReminders.Size = new System.Drawing.Size(749, 213);
            this.listViewReminders.TabIndex = 12;
            this.listViewReminders.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 575);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 75);
            this.panel1.TabIndex = 14;
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
            this.panel2.TabIndex = 13;
            // 
            // Labelc5
            // 
            this.Labelc5.AutoSize = true;
            this.Labelc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Labelc5.ForeColor = System.Drawing.Color.White;
            this.Labelc5.Location = new System.Drawing.Point(15, 11);
            this.Labelc5.Name = "Labelc5";
            this.Labelc5.Size = new System.Drawing.Size(119, 29);
            this.Labelc5.TabIndex = 15;
            this.Labelc5.Text = "Reminder";
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
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(47, 303);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(123, 65);
            this.buttonDown.TabIndex = 15;
            this.buttonDown.Text = "Download";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Visible = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 650);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listViewReminders);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblReminder);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbReminderType);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSummary);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reminder";
            this.Load += new System.EventHandler(this.Reminder_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox cmbReminderType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.ListView listViewReminders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Labelc5;
        private System.Windows.Forms.PictureBox btn_quit;
        private System.Windows.Forms.Button buttonDown;
    }
}