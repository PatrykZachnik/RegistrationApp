
namespace RegistrationApp
{
    partial class frmRegistration
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.radPod = new System.Windows.Forms.RadioButton();
            this.radSrd = new System.Windows.Forms.RadioButton();
            this.radWy = new System.Windows.Forms.RadioButton();
            this.lblwyk = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.birthCal = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(142, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(142, 59);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 62);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(15, 257);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblwyk);
            this.groupBox1.Controls.Add(this.lblFullName);
            this.groupBox1.Location = new System.Drawing.Point(366, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 255);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserDetails";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(6, 33);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(0, 13);
            this.lblFullName.TabIndex = 0;
            // 
            // radPod
            // 
            this.radPod.AutoSize = true;
            this.radPod.Location = new System.Drawing.Point(15, 105);
            this.radPod.Name = "radPod";
            this.radPod.Size = new System.Drawing.Size(86, 17);
            this.radPod.TabIndex = 1;
            this.radPod.TabStop = true;
            this.radPod.Text = "Podstawowe";
            this.radPod.UseVisualStyleBackColor = true;
            this.radPod.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radSrd
            // 
            this.radSrd.AutoSize = true;
            this.radSrd.Location = new System.Drawing.Point(15, 128);
            this.radSrd.Name = "radSrd";
            this.radSrd.Size = new System.Drawing.Size(61, 17);
            this.radSrd.TabIndex = 5;
            this.radSrd.TabStop = true;
            this.radSrd.Text = "Średnie";
            this.radSrd.UseVisualStyleBackColor = true;
            this.radSrd.CheckedChanged += new System.EventHandler(this.radSrd_CheckedChanged);
            // 
            // radWy
            // 
            this.radWy.AutoSize = true;
            this.radWy.Location = new System.Drawing.Point(15, 151);
            this.radWy.Name = "radWy";
            this.radWy.Size = new System.Drawing.Size(62, 17);
            this.radWy.TabIndex = 6;
            this.radWy.TabStop = true;
            this.radWy.Text = "Wyższe";
            this.radWy.UseVisualStyleBackColor = true;
            this.radWy.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblwyk
            // 
            this.lblwyk.AutoSize = true;
            this.lblwyk.Location = new System.Drawing.Point(6, 50);
            this.lblwyk.Name = "lblwyk";
            this.lblwyk.Size = new System.Drawing.Size(0, 13);
            this.lblwyk.TabIndex = 1;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(6, 84);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 13);
            this.lbldate.TabIndex = 8;
            // 
            // birthCal
            // 
            this.birthCal.Location = new System.Drawing.Point(142, 124);
            this.birthCal.Name = "birthCal";
            this.birthCal.Size = new System.Drawing.Size(200, 20);
            this.birthCal.TabIndex = 7;
            this.birthCal.CloseUp += new System.EventHandler(this.birthCal_CloseUp);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 292);
            this.Controls.Add(this.birthCal);
            this.Controls.Add(this.radWy);
            this.Controls.Add(this.radSrd);
            this.Controls.Add(this.radPod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.ResizeEnd += new System.EventHandler(this.frmRegistration_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.RadioButton radPod;
        private System.Windows.Forms.RadioButton radSrd;
        private System.Windows.Forms.RadioButton radWy;
        private System.Windows.Forms.Label lblwyk;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.DateTimePicker birthCal;
    }
}

