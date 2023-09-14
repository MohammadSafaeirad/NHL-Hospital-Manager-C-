using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NLHospitalLibrary;
using NLHBaseWindow;


namespace NLHospital
{
	/// <summary>
	/// Summary description for frmMenu.
	/// </summary>
	public class frmMenu : NLHBase
	{
		private System.Windows.Forms.Label lblAdministrator;
		private System.Windows.Forms.Button btnDoctors;
		private System.Windows.Forms.Label lblAdmin;
		private System.Windows.Forms.Panel pnlAdministrator;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnDischarge;
		private System.Windows.Forms.Button btnSurgery;
		private System.Windows.Forms.Label lblNurses;
		private System.Windows.Forms.Button btnForSurgery;
		private System.Windows.Forms.Button btnBilling;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Panel pnlDoctors;
		private System.Windows.Forms.Panel pnlNurses;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPatientID;
		private System.Windows.Forms.Label label1;
        private Panel pnlAdmission;
        private Label label6;
        private Button btnAddPatient;
        private Button btnNewAdmission;
        private Label label7;
        public CurrentUser oCurrent = new CurrentUser();

		public frmMenu(CurrentUser curUser)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            oCurrent = curUser;
            SelectUser();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pnlAdministrator = new System.Windows.Forms.Panel();
            this.btnBilling = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.pnlDoctors = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSurgery = new System.Windows.Forms.Button();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNurses = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnForSurgery = new System.Windows.Forms.Button();
            this.lblNurses = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlAdmission = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnNewAdmission = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlAdministrator.SuspendLayout();
            this.pnlDoctors.SuspendLayout();
            this.pnlNurses.SuspendLayout();
            this.pnlAdmission.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdministrator
            // 
            this.pnlAdministrator.Controls.Add(this.btnBilling);
            this.pnlAdministrator.Controls.Add(this.lblAdmin);
            this.pnlAdministrator.Controls.Add(this.btnDoctors);
            this.pnlAdministrator.Controls.Add(this.lblAdministrator);
            this.pnlAdministrator.Location = new System.Drawing.Point(19, 9);
            this.pnlAdministrator.Name = "pnlAdministrator";
            this.pnlAdministrator.Size = new System.Drawing.Size(384, 139);
            this.pnlAdministrator.TabIndex = 0;
            this.pnlAdministrator.Visible = false;
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(192, 92);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(163, 27);
            this.btnBilling.TabIndex = 5;
            this.btnBilling.Text = "Bill Patient";
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(19, 37);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(222, 17);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Please select one of the following:";
            // 
            // btnDoctors
            // 
            this.btnDoctors.Location = new System.Drawing.Point(10, 92);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(163, 27);
            this.btnDoctors.TabIndex = 1;
            this.btnDoctors.Text = "Manage Doctors";
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(19, 9);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(130, 20);
            this.lblAdministrator.TabIndex = 0;
            this.lblAdministrator.Text = "Administration";
            // 
            // pnlDoctors
            // 
            this.pnlDoctors.Controls.Add(this.label1);
            this.pnlDoctors.Controls.Add(this.txtPatientID);
            this.pnlDoctors.Controls.Add(this.label3);
            this.pnlDoctors.Controls.Add(this.btnSurgery);
            this.pnlDoctors.Controls.Add(this.btnDischarge);
            this.pnlDoctors.Controls.Add(this.label2);
            this.pnlDoctors.Location = new System.Drawing.Point(413, 9);
            this.pnlDoctors.Name = "pnlDoctors";
            this.pnlDoctors.Size = new System.Drawing.Size(384, 139);
            this.pnlDoctors.TabIndex = 2;
            this.pnlDoctors.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(96, 65);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(86, 22);
            this.txtPatientID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please elect one of the following:";
            // 
            // btnSurgery
            // 
            this.btnSurgery.Location = new System.Drawing.Point(202, 92);
            this.btnSurgery.Name = "btnSurgery";
            this.btnSurgery.Size = new System.Drawing.Size(163, 27);
            this.btnSurgery.TabIndex = 2;
            this.btnSurgery.Text = "Surgery Report";
            this.btnSurgery.Click += new System.EventHandler(this.btnSurgery_Click);
            // 
            // btnDischarge
            // 
            this.btnDischarge.Location = new System.Drawing.Point(19, 92);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(163, 27);
            this.btnDischarge.TabIndex = 1;
            this.btnDischarge.Text = "Discharge Patient";
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doctors";
            // 
            // pnlNurses
            // 
            this.pnlNurses.Controls.Add(this.label4);
            this.pnlNurses.Controls.Add(this.button1);
            this.pnlNurses.Controls.Add(this.btnForSurgery);
            this.pnlNurses.Controls.Add(this.lblNurses);
            this.pnlNurses.Location = new System.Drawing.Point(19, 157);
            this.pnlNurses.Name = "pnlNurses";
            this.pnlNurses.Size = new System.Drawing.Size(384, 138);
            this.pnlNurses.TabIndex = 3;
            this.pnlNurses.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select one of the following:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Patient List";
            // 
            // btnForSurgery
            // 
            this.btnForSurgery.Location = new System.Drawing.Point(202, 92);
            this.btnForSurgery.Name = "btnForSurgery";
            this.btnForSurgery.Size = new System.Drawing.Size(163, 27);
            this.btnForSurgery.TabIndex = 1;
            this.btnForSurgery.Text = "Surgery Report";
            // 
            // lblNurses
            // 
            this.lblNurses.AutoSize = true;
            this.lblNurses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNurses.Location = new System.Drawing.Point(38, 9);
            this.lblNurses.Name = "lblNurses";
            this.lblNurses.Size = new System.Drawing.Size(69, 20);
            this.lblNurses.TabIndex = 0;
            this.lblNurses.Text = "Nurses";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(707, 326);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(90, 27);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlAdmission
            // 
            this.pnlAdmission.Controls.Add(this.label6);
            this.pnlAdmission.Controls.Add(this.btnAddPatient);
            this.pnlAdmission.Controls.Add(this.btnNewAdmission);
            this.pnlAdmission.Controls.Add(this.label7);
            this.pnlAdmission.Location = new System.Drawing.Point(413, 157);
            this.pnlAdmission.Name = "pnlAdmission";
            this.pnlAdmission.Size = new System.Drawing.Size(384, 139);
            this.pnlAdmission.TabIndex = 8;
            this.pnlAdmission.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Please elect one of the following:";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(202, 92);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(163, 27);
            this.btnAddPatient.TabIndex = 2;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnNewAdmission
            // 
            this.btnNewAdmission.Location = new System.Drawing.Point(19, 92);
            this.btnNewAdmission.Name = "btnNewAdmission";
            this.btnNewAdmission.Size = new System.Drawing.Size(163, 27);
            this.btnNewAdmission.TabIndex = 1;
            this.btnNewAdmission.Text = "New Admission";
            this.btnNewAdmission.Click += new System.EventHandler(this.btnNewAdmission_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Admission";
            // 
            // frmMenu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(833, 367);
            this.Controls.Add(this.pnlAdmission);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.pnlDoctors);
            this.Controls.Add(this.pnlAdministrator);
            this.Controls.Add(this.pnlNurses);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlAdministrator.ResumeLayout(false);
            this.pnlAdministrator.PerformLayout();
            this.pnlDoctors.ResumeLayout(false);
            this.pnlDoctors.PerformLayout();
            this.pnlNurses.ResumeLayout(false);
            this.pnlNurses.PerformLayout();
            this.pnlAdmission.ResumeLayout(false);
            this.pnlAdmission.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void btnDoctors_Click(object sender, System.EventArgs e)
		{
			frmDoctors doctorsForm = new frmDoctors ();
			doctorsForm.Visible = true;
			doctorsForm.Activate();
		}

		private void btnQuit_Click(object sender, System.EventArgs e)
		{
			Application.Exit ();
		}

		private void frmMenu_Load(object sender, System.EventArgs e)
		{
		}

		public void SelectUser()
		{
			switch (oCurrent.UserPosition)
			{
				case "Admin":
					pnlAdministrator.Visible = true;
					break;
				case "Doctor":
					pnlDoctors.Visible = true;
					break;
				case "Nurse":
					pnlNurses.Visible = true;
                    break;
                case "Admission":
                    pnlAdmission.Visible = true;
                    break;
			}
			
		}

		private void btnDischarge_Click(object sender, System.EventArgs e)
		{


		}

		private void btnBilling_Click(object sender, System.EventArgs e)
		{
			frmBillPatient billForm = new frmBillPatient ();
			billForm.Visible = true;
			billForm.Activate();
		}

        private void btnSurgery_Click(object sender, EventArgs e)
        {

        }

        private void btnNewAdmission_Click(object sender, EventArgs e)
        {
            Admission admission = new Admission();
            admission.Visible = true;
            admission.Activate();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Visible = true;
            patient.Activate();
        }
    }
}
