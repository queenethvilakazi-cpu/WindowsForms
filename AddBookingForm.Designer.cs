namespace WindowsForms
{
    partial class AddBookingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.cboEquipment = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.nudMaxUsers = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equipment Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Purpose:";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(131, 25);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(155, 20);
            this.txtBookingID.TabIndex = 5;
            // 
            // cboEquipment
            // 
            this.cboEquipment.FormattingEnabled = true;
            this.cboEquipment.Location = new System.Drawing.Point(131, 73);
            this.cboEquipment.Name = "cboEquipment";
            this.cboEquipment.Size = new System.Drawing.Size(155, 21);
            this.cboEquipment.TabIndex = 6;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(131, 117);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(155, 21);
            this.cboCategory.TabIndex = 7;
            // 
            // cboLocation
            // 
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Location = new System.Drawing.Point(131, 163);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(155, 21);
            this.cboLocation.TabIndex = 8;
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(131, 209);
            this.txtPurpose.Multiline = true;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(155, 80);
            this.txtPurpose.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Booking Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Start Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "End Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Department:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Max Users:";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingDate.Location = new System.Drawing.Point(473, 25);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBookingDate.TabIndex = 15;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(473, 67);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(200, 20);
            this.dtpStartTime.TabIndex = 16;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(473, 112);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(200, 20);
            this.dtpEndTime.TabIndex = 17;
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(473, 153);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(121, 21);
            this.cboDepartment.TabIndex = 18;
            // 
            // nudMaxUsers
            // 
            this.nudMaxUsers.Location = new System.Drawing.Point(474, 202);
            this.nudMaxUsers.Name = "nudMaxUsers";
            this.nudMaxUsers.Size = new System.Drawing.Size(120, 20);
            this.nudMaxUsers.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(354, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 50);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save Booking";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(518, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 50);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(621, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "(> 0)";
            // 
            // AddBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudMaxUsers);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.dtpBookingDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.cboLocation);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.cboEquipment);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBookingForm";
            this.Text = "AddBookingForm";
            this.Load += new System.EventHandler(this.AddBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.ComboBox cboEquipment;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboLocation;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.NumericUpDown nudMaxUsers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label11;
    }
}