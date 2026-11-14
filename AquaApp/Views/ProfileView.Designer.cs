namespace AquaApp.Views
{
    partial class ProfileView
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblOrganization = new System.Windows.Forms.Label();
            this.txtOrganization = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpProfile.SuspendLayout();
            this.grpPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(20, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(124, 30);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "My profile";
            // 
            // grpProfile
            // 
            this.grpProfile.Controls.Add(this.lblEmail);
            this.grpProfile.Controls.Add(this.txtEmail);
            this.grpProfile.Controls.Add(this.lblFullName);
            this.grpProfile.Controls.Add(this.txtFullName);
            this.grpProfile.Controls.Add(this.lblOrganization);
            this.grpProfile.Controls.Add(this.txtOrganization);
            this.grpProfile.Controls.Add(this.lblPhone);
            this.grpProfile.Controls.Add(this.txtPhone);
            this.grpProfile.Controls.Add(this.btnSaveProfile);
            this.grpProfile.Location = new System.Drawing.Point(20, 50);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.Size = new System.Drawing.Size(440, 250);
            this.grpProfile.TabIndex = 1;
            this.grpProfile.Text = "Profile";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 28);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(180, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email (cannot be changed)";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(15, 48);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(410, 23);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.ReadOnly = true;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(15, 80);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(64, 20);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(15, 100);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(410, 23);
            this.txtFullName.TabIndex = 3;
            // 
            // lblOrganization
            // 
            this.lblOrganization.AutoSize = true;
            this.lblOrganization.Location = new System.Drawing.Point(15, 132);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(122, 20);
            this.lblOrganization.TabIndex = 4;
            this.lblOrganization.Text = "Organization name";
            // 
            // txtOrganization
            // 
            this.txtOrganization.Location = new System.Drawing.Point(15, 152);
            this.txtOrganization.Name = "txtOrganization";
            this.txtOrganization.Size = new System.Drawing.Size(410, 23);
            this.txtOrganization.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 184);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(36, 20);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(15, 204);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 23);
            this.txtPhone.TabIndex = 7;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveProfile.ForeColor = System.Drawing.Color.White;
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.Location = new System.Drawing.Point(280, 200);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(145, 32);
            this.btnSaveProfile.TabIndex = 8;
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            this.btnSaveProfile.Text = "Save Profile";
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // grpPassword
            // 
            this.grpPassword.Controls.Add(this.lblCurrent);
            this.grpPassword.Controls.Add(this.txtCurrent);
            this.grpPassword.Controls.Add(this.lblNew);
            this.grpPassword.Controls.Add(this.txtNew);
            this.grpPassword.Controls.Add(this.lblConfirm);
            this.grpPassword.Controls.Add(this.txtConfirm);
            this.grpPassword.Controls.Add(this.btnChangePassword);
            this.grpPassword.Location = new System.Drawing.Point(20, 310);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Size = new System.Drawing.Size(440, 190);
            this.grpPassword.TabIndex = 2;
            this.grpPassword.Text = "Change password";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(15, 28);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(115, 20);
            this.lblCurrent.TabIndex = 0;
            this.lblCurrent.Text = "Current password";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(15, 48);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(410, 23);
            this.txtCurrent.TabIndex = 1;
            this.txtCurrent.UseSystemPasswordChar = true;
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(15, 80);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(86, 20);
            this.lblNew.TabIndex = 2;
            this.lblNew.Text = "New password";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(15, 100);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(200, 23);
            this.txtNew.TabIndex = 3;
            this.txtNew.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(225, 80);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(144, 20);
            this.lblConfirm.TabIndex = 4;
            this.lblConfirm.Text = "Confirm new password";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(225, 100);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(200, 23);
            this.txtConfirm.TabIndex = 5;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.SteelBlue;
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Location = new System.Drawing.Point(15, 140);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(410, 34);
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(340, 515);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 560);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpPassword);
            this.Controls.Add(this.grpProfile);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProfileView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AQUA - My Profile";
            this.Load += new System.EventHandler(this.ProfileView_Load);
            this.grpProfile.ResumeLayout(false);
            this.grpProfile.PerformLayout();
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.TextBox txtOrganization;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnClose;
    }
}
