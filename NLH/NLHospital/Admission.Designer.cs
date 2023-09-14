
namespace NLHospital
{
    partial class Admission
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxWardDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxSurguryDate = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonNoSurgury = new System.Windows.Forms.RadioButton();
            this.radioButtonYesSurgury = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxDischargeDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAdmissionDate = new System.Windows.Forms.MaskedTextBox();
            this.textBoxBedNumber = new System.Windows.Forms.TextBox();
            this.textBoxPatientID = new System.Windows.Forms.TextBox();
            this.textBoxAdmissionID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonPrivate = new System.Windows.Forms.RadioButton();
            this.radioButtonPHONE = new System.Windows.Forms.RadioButton();
            this.radioButtonTV = new System.Windows.Forms.RadioButton();
            this.radioButtonSemiPrivate = new System.Windows.Forms.RadioButton();
            this.dataGridViewBeds = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonNewAdmission = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeds)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxWardDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.maskedTextBoxSurguryDate);
            this.groupBox1.Controls.Add(this.radioButtonNoSurgury);
            this.groupBox1.Controls.Add(this.radioButtonYesSurgury);
            this.groupBox1.Controls.Add(this.maskedTextBoxDischargeDate);
            this.groupBox1.Controls.Add(this.maskedTextBoxAdmissionDate);
            this.groupBox1.Controls.Add(this.textBoxBedNumber);
            this.groupBox1.Controls.Add(this.textBoxPatientID);
            this.groupBox1.Controls.Add(this.textBoxAdmissionID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admission";
            // 
            // textBoxWardDate
            // 
            this.textBoxWardDate.Location = new System.Drawing.Point(207, 395);
            this.textBoxWardDate.MaxLength = 15;
            this.textBoxWardDate.Name = "textBoxWardDate";
            this.textBoxWardDate.Size = new System.Drawing.Size(189, 26);
            this.textBoxWardDate.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ward Name:";
            // 
            // maskedTextBoxSurguryDate
            // 
            this.maskedTextBoxSurguryDate.Location = new System.Drawing.Point(207, 351);
            this.maskedTextBoxSurguryDate.Mask = "00/00/0000";
            this.maskedTextBoxSurguryDate.Name = "maskedTextBoxSurguryDate";
            this.maskedTextBoxSurguryDate.Size = new System.Drawing.Size(189, 26);
            this.maskedTextBoxSurguryDate.TabIndex = 15;
            this.maskedTextBoxSurguryDate.ValidatingType = typeof(System.DateTime);
            // 
            // radioButtonNoSurgury
            // 
            this.radioButtonNoSurgury.AutoSize = true;
            this.radioButtonNoSurgury.Location = new System.Drawing.Point(284, 299);
            this.radioButtonNoSurgury.Name = "radioButtonNoSurgury";
            this.radioButtonNoSurgury.Size = new System.Drawing.Size(53, 24);
            this.radioButtonNoSurgury.TabIndex = 14;
            this.radioButtonNoSurgury.TabStop = true;
            this.radioButtonNoSurgury.Text = "No";
            this.radioButtonNoSurgury.UseVisualStyleBackColor = true;
            // 
            // radioButtonYesSurgury
            // 
            this.radioButtonYesSurgury.AutoSize = true;
            this.radioButtonYesSurgury.Location = new System.Drawing.Point(217, 299);
            this.radioButtonYesSurgury.Name = "radioButtonYesSurgury";
            this.radioButtonYesSurgury.Size = new System.Drawing.Size(61, 24);
            this.radioButtonYesSurgury.TabIndex = 13;
            this.radioButtonYesSurgury.TabStop = true;
            this.radioButtonYesSurgury.Text = "Yes";
            this.radioButtonYesSurgury.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxDischargeDate
            // 
            this.maskedTextBoxDischargeDate.Location = new System.Drawing.Point(207, 250);
            this.maskedTextBoxDischargeDate.Mask = "00/00/0000";
            this.maskedTextBoxDischargeDate.Name = "maskedTextBoxDischargeDate";
            this.maskedTextBoxDischargeDate.Size = new System.Drawing.Size(189, 26);
            this.maskedTextBoxDischargeDate.TabIndex = 12;
            this.maskedTextBoxDischargeDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxAdmissionDate
            // 
            this.maskedTextBoxAdmissionDate.Location = new System.Drawing.Point(207, 202);
            this.maskedTextBoxAdmissionDate.Mask = "00/00/0000";
            this.maskedTextBoxAdmissionDate.Name = "maskedTextBoxAdmissionDate";
            this.maskedTextBoxAdmissionDate.Size = new System.Drawing.Size(189, 26);
            this.maskedTextBoxAdmissionDate.TabIndex = 11;
            this.maskedTextBoxAdmissionDate.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxBedNumber
            // 
            this.textBoxBedNumber.Location = new System.Drawing.Point(207, 147);
            this.textBoxBedNumber.MaxLength = 3;
            this.textBoxBedNumber.Name = "textBoxBedNumber";
            this.textBoxBedNumber.Size = new System.Drawing.Size(189, 26);
            this.textBoxBedNumber.TabIndex = 10;
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.Location = new System.Drawing.Point(207, 94);
            this.textBoxPatientID.MaxLength = 15;
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(189, 26);
            this.textBoxPatientID.TabIndex = 9;
            // 
            // textBoxAdmissionID
            // 
            this.textBoxAdmissionID.Location = new System.Drawing.Point(207, 44);
            this.textBoxAdmissionID.MaxLength = 30;
            this.textBoxAdmissionID.Name = "textBoxAdmissionID";
            this.textBoxAdmissionID.Size = new System.Drawing.Size(189, 26);
            this.textBoxAdmissionID.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Surgury Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Surgury Scheduled:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Discharge Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Admission Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bed Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admission ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.radioButtonPHONE);
            this.groupBox2.Controls.Add(this.radioButtonTV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(432, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonSemiPrivate);
            this.groupBox3.Controls.Add(this.radioButtonPrivate);
            this.groupBox3.Location = new System.Drawing.Point(132, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 96);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Room";
            // 
            // radioButtonPrivate
            // 
            this.radioButtonPrivate.AutoSize = true;
            this.radioButtonPrivate.Location = new System.Drawing.Point(15, 25);
            this.radioButtonPrivate.Name = "radioButtonPrivate";
            this.radioButtonPrivate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonPrivate.Size = new System.Drawing.Size(89, 24);
            this.radioButtonPrivate.TabIndex = 21;
            this.radioButtonPrivate.TabStop = true;
            this.radioButtonPrivate.Text = "Private";
            this.radioButtonPrivate.UseVisualStyleBackColor = true;
            // 
            // radioButtonPHONE
            // 
            this.radioButtonPHONE.AutoSize = true;
            this.radioButtonPHONE.Location = new System.Drawing.Point(18, 86);
            this.radioButtonPHONE.Name = "radioButtonPHONE";
            this.radioButtonPHONE.Size = new System.Drawing.Size(95, 24);
            this.radioButtonPHONE.TabIndex = 19;
            this.radioButtonPHONE.TabStop = true;
            this.radioButtonPHONE.Text = "PHONE";
            this.radioButtonPHONE.UseVisualStyleBackColor = true;
            // 
            // radioButtonTV
            // 
            this.radioButtonTV.AutoSize = true;
            this.radioButtonTV.Location = new System.Drawing.Point(18, 33);
            this.radioButtonTV.Name = "radioButtonTV";
            this.radioButtonTV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonTV.Size = new System.Drawing.Size(53, 24);
            this.radioButtonTV.TabIndex = 18;
            this.radioButtonTV.TabStop = true;
            this.radioButtonTV.Text = "TV";
            this.radioButtonTV.UseVisualStyleBackColor = true;
            // 
            // radioButtonSemiPrivate
            // 
            this.radioButtonSemiPrivate.AutoSize = true;
            this.radioButtonSemiPrivate.Location = new System.Drawing.Point(15, 61);
            this.radioButtonSemiPrivate.Name = "radioButtonSemiPrivate";
            this.radioButtonSemiPrivate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonSemiPrivate.Size = new System.Drawing.Size(138, 24);
            this.radioButtonSemiPrivate.TabIndex = 22;
            this.radioButtonSemiPrivate.TabStop = true;
            this.radioButtonSemiPrivate.Text = "Semi-Private";
            this.radioButtonSemiPrivate.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBeds
            // 
            this.dataGridViewBeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBeds.Location = new System.Drawing.Point(432, 227);
            this.dataGridViewBeds.Name = "dataGridViewBeds";
            this.dataGridViewBeds.RowHeadersWidth = 51;
            this.dataGridViewBeds.RowTemplate.Height = 24;
            this.dataGridViewBeds.Size = new System.Drawing.Size(363, 150);
            this.dataGridViewBeds.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(428, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "All Beds:";
            // 
            // buttonNewAdmission
            // 
            this.buttonNewAdmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewAdmission.Location = new System.Drawing.Point(513, 390);
            this.buttonNewAdmission.Name = "buttonNewAdmission";
            this.buttonNewAdmission.Size = new System.Drawing.Size(138, 53);
            this.buttonNewAdmission.TabIndex = 19;
            this.buttonNewAdmission.Text = "New Admission";
            this.buttonNewAdmission.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(657, 390);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(138, 53);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // Admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 482);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNewAdmission);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewBeds);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admission";
            this.Text = "Admission";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWardDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSurguryDate;
        private System.Windows.Forms.RadioButton radioButtonNoSurgury;
        private System.Windows.Forms.RadioButton radioButtonYesSurgury;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDischargeDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAdmissionDate;
        private System.Windows.Forms.TextBox textBoxBedNumber;
        private System.Windows.Forms.TextBox textBoxPatientID;
        private System.Windows.Forms.TextBox textBoxAdmissionID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonPrivate;
        private System.Windows.Forms.RadioButton radioButtonPHONE;
        private System.Windows.Forms.RadioButton radioButtonTV;
        private System.Windows.Forms.RadioButton radioButtonSemiPrivate;
        private System.Windows.Forms.DataGridView dataGridViewBeds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonNewAdmission;
        private System.Windows.Forms.Button buttonExit;
    }
}