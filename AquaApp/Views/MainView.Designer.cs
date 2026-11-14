namespace AquaApp.Views
{
    partial class MainView
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
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblReceivedCaption = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.lblUnderReviewCaption = new System.Windows.Forms.Label();
            this.lblUnderReview = new System.Windows.Forms.Label();
            this.lblInfoRequestedCaption = new System.Windows.Forms.Label();
            this.lblInfoRequested = new System.Windows.Forms.Label();
            this.lblApprovedCaption = new System.Windows.Forms.Label();
            this.lblApproved = new System.Windows.Forms.Label();
            this.lblRejectedCaption = new System.Windows.Forms.Label();
            this.lblRejected = new System.Windows.Forms.Label();
            this.lblRecent = new System.Windows.Forms.Label();
            this.dgvRecent = new System.Windows.Forms.DataGridView();
            this.flpMenu.SuspendLayout();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.SuspendLayout();
            // 
            // flpMenu
            // 
            this.flpMenu.Controls.Add(this.lblMenuTitle);
            this.flpMenu.Controls.Add(this.btnProjects);
            this.flpMenu.Controls.Add(this.btnNewProject);
            this.flpMenu.Controls.Add(this.btnAssign);
            this.flpMenu.Controls.Add(this.btnUsers);
            this.flpMenu.Controls.Add(this.btnCategories);
            this.flpMenu.Controls.Add(this.btnProfile);
            this.flpMenu.Controls.Add(this.btnLogout);
            this.flpMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.flpMenu.Location = new System.Drawing.Point(0, 0);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(210, 600);
            this.flpMenu.TabIndex = 0;
            this.flpMenu.Padding = new System.Windows.Forms.Padding(8, 15, 8, 8);
            this.flpMenu.WrapContents = false;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.White;
            this.lblMenuTitle.Location = new System.Drawing.Point(0, 0);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(186, 60);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenuTitle.Text = "AQUA";
            // 
            // btnProjects
            // 
            this.btnProjects.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProjects.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
            this.btnProjects.ForeColor = System.Drawing.Color.White;
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.Location = new System.Drawing.Point(0, 0);
            this.btnProjects.FlatAppearance.BorderSize = 0;
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(186, 42);
            this.btnProjects.TabIndex = 1;
            this.btnProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjects.UseVisualStyleBackColor = false;
            this.btnProjects.Text = "  Projects";
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnNewProject
            // 
            this.btnNewProject.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewProject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
            this.btnNewProject.ForeColor = System.Drawing.Color.White;
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProject.Location = new System.Drawing.Point(0, 0);
            this.btnNewProject.FlatAppearance.BorderSize = 0;
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(186, 42);
            this.btnNewProject.TabIndex = 2;
            this.btnNewProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProject.UseVisualStyleBackColor = false;
            this.btnNewProject.Text = "  New Project";
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Location = new System.Drawing.Point(0, 0);
            this.btnAssign.FlatAppearance.BorderSize = 0;
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(186, 42);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Text = "  Assign Reviewers";
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Location = new System.Drawing.Point(0, 0);
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(186, 42);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Text = "  Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Location = new System.Drawing.Point(0, 0);
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(186, 42);
            this.btnCategories.TabIndex = 5;
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Text = "  Categories";
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(0, 0);
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(186, 42);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Text = "  My Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(186, 42);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(230, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(92, 32);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.Color.DimGray;
            this.lblRole.Location = new System.Drawing.Point(232, 55);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(28, 20);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(820, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblReceivedCaption);
            this.grpSummary.Controls.Add(this.lblReceived);
            this.grpSummary.Controls.Add(this.lblUnderReviewCaption);
            this.grpSummary.Controls.Add(this.lblUnderReview);
            this.grpSummary.Controls.Add(this.lblInfoRequestedCaption);
            this.grpSummary.Controls.Add(this.lblInfoRequested);
            this.grpSummary.Controls.Add(this.lblApprovedCaption);
            this.grpSummary.Controls.Add(this.lblApproved);
            this.grpSummary.Controls.Add(this.lblRejectedCaption);
            this.grpSummary.Controls.Add(this.lblRejected);
            this.grpSummary.Location = new System.Drawing.Point(230, 90);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(705, 120);
            this.grpSummary.TabIndex = 4;
            this.grpSummary.Text = "Project summary";
            // 
            // lblReceivedCaption
            // 
            this.lblReceivedCaption.AutoSize = true;
            this.lblReceivedCaption.Location = new System.Drawing.Point(15, 30);
            this.lblReceivedCaption.Name = "lblReceivedCaption";
            this.lblReceivedCaption.Size = new System.Drawing.Size(57, 20);
            this.lblReceivedCaption.TabIndex = 0;
            this.lblReceivedCaption.Text = "Received";
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReceived.Location = new System.Drawing.Point(15, 55);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(20, 42);
            this.lblReceived.TabIndex = 1;
            this.lblReceived.Text = "0";
            // 
            // lblUnderReviewCaption
            // 
            this.lblUnderReviewCaption.AutoSize = true;
            this.lblUnderReviewCaption.Location = new System.Drawing.Point(150, 30);
            this.lblUnderReviewCaption.Name = "lblUnderReviewCaption";
            this.lblUnderReviewCaption.Size = new System.Drawing.Size(86, 20);
            this.lblUnderReviewCaption.TabIndex = 2;
            this.lblUnderReviewCaption.Text = "Under Review";
            // 
            // lblUnderReview
            // 
            this.lblUnderReview.AutoSize = true;
            this.lblUnderReview.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUnderReview.Location = new System.Drawing.Point(150, 55);
            this.lblUnderReview.Name = "lblUnderReview";
            this.lblUnderReview.Size = new System.Drawing.Size(20, 42);
            this.lblUnderReview.TabIndex = 3;
            this.lblUnderReview.Text = "0";
            // 
            // lblInfoRequestedCaption
            // 
            this.lblInfoRequestedCaption.AutoSize = true;
            this.lblInfoRequestedCaption.Location = new System.Drawing.Point(285, 30);
            this.lblInfoRequestedCaption.Name = "lblInfoRequestedCaption";
            this.lblInfoRequestedCaption.Size = new System.Drawing.Size(100, 20);
            this.lblInfoRequestedCaption.TabIndex = 4;
            this.lblInfoRequestedCaption.Text = "Info Requested";
            // 
            // lblInfoRequested
            // 
            this.lblInfoRequested.AutoSize = true;
            this.lblInfoRequested.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfoRequested.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblInfoRequested.Location = new System.Drawing.Point(285, 55);
            this.lblInfoRequested.Name = "lblInfoRequested";
            this.lblInfoRequested.Size = new System.Drawing.Size(20, 42);
            this.lblInfoRequested.TabIndex = 5;
            this.lblInfoRequested.Text = "0";
            // 
            // lblApprovedCaption
            // 
            this.lblApprovedCaption.AutoSize = true;
            this.lblApprovedCaption.Location = new System.Drawing.Point(420, 30);
            this.lblApprovedCaption.Name = "lblApprovedCaption";
            this.lblApprovedCaption.Size = new System.Drawing.Size(57, 20);
            this.lblApprovedCaption.TabIndex = 6;
            this.lblApprovedCaption.Text = "Approved";
            // 
            // lblApproved
            // 
            this.lblApproved.AutoSize = true;
            this.lblApproved.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApproved.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblApproved.Location = new System.Drawing.Point(420, 55);
            this.lblApproved.Name = "lblApproved";
            this.lblApproved.Size = new System.Drawing.Size(20, 42);
            this.lblApproved.TabIndex = 7;
            this.lblApproved.Text = "0";
            // 
            // lblRejectedCaption
            // 
            this.lblRejectedCaption.AutoSize = true;
            this.lblRejectedCaption.Location = new System.Drawing.Point(555, 30);
            this.lblRejectedCaption.Name = "lblRejectedCaption";
            this.lblRejectedCaption.Size = new System.Drawing.Size(57, 20);
            this.lblRejectedCaption.TabIndex = 8;
            this.lblRejectedCaption.Text = "Rejected";
            // 
            // lblRejected
            // 
            this.lblRejected.AutoSize = true;
            this.lblRejected.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRejected.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRejected.Location = new System.Drawing.Point(555, 55);
            this.lblRejected.Name = "lblRejected";
            this.lblRejected.Size = new System.Drawing.Size(20, 42);
            this.lblRejected.TabIndex = 9;
            this.lblRejected.Text = "0";
            // 
            // lblRecent
            // 
            this.lblRecent.AutoSize = true;
            this.lblRecent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecent.Location = new System.Drawing.Point(230, 225);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.Size = new System.Drawing.Size(394, 20);
            this.lblRecent.TabIndex = 5;
            this.lblRecent.Text = "Recent projects (double-click a row to open it)";
            // 
            // dgvRecent
            // 
            this.dgvRecent.Location = new System.Drawing.Point(230, 250);
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            this.dgvRecent.AllowUserToResizeRows = false;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecent.MultiSelect = false;
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.Size = new System.Drawing.Size(705, 330);
            this.dgvRecent.TabIndex = 6;
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecent_CellDoubleClick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.dgvRecent);
            this.Controls.Add(this.lblRecent);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.flpMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AQUA - Dashboard";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.flpMenu.ResumeLayout(false);
            this.flpMenu.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblReceivedCaption;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Label lblUnderReviewCaption;
        private System.Windows.Forms.Label lblUnderReview;
        private System.Windows.Forms.Label lblInfoRequestedCaption;
        private System.Windows.Forms.Label lblInfoRequested;
        private System.Windows.Forms.Label lblApprovedCaption;
        private System.Windows.Forms.Label lblApproved;
        private System.Windows.Forms.Label lblRejectedCaption;
        private System.Windows.Forms.Label lblRejected;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.DataGridView dgvRecent;
    }
}
