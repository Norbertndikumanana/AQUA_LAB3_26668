namespace AquaApp.Views
{
    partial class ProjectDetailsView
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblRefCaption = new System.Windows.Forms.Label();
            this.lblRefValue = new System.Windows.Forms.Label();
            this.lblStatusCaption = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblTitleCaption = new System.Windows.Forms.Label();
            this.lblTitleValue = new System.Windows.Forms.Label();
            this.lblCategoryCaption = new System.Windows.Forms.Label();
            this.lblCategoryValue = new System.Windows.Forms.Label();
            this.lblBudgetCaption = new System.Windows.Forms.Label();
            this.lblBudgetValue = new System.Windows.Forms.Label();
            this.lblLocationCaption = new System.Windows.Forms.Label();
            this.lblLocationValue = new System.Windows.Forms.Label();
            this.lblOrgCaption = new System.Windows.Forms.Label();
            this.lblOrgValue = new System.Windows.Forms.Label();
            this.lblReviewerCaption = new System.Windows.Forms.Label();
            this.lblReviewerValue = new System.Windows.Forms.Label();
            this.lblSubmittedCaption = new System.Windows.Forms.Label();
            this.lblSubmittedValue = new System.Windows.Forms.Label();
            this.lblDescriptionCaption = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDecision = new System.Windows.Forms.Label();
            this.grpDocuments = new System.Windows.Forms.GroupBox();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.grpHistory = new System.Windows.Forms.GroupBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpInfo.SuspendLayout();
            this.grpDocuments.SuspendLayout();
            this.grpHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(20, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(186, 30);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Project details";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblRefCaption);
            this.grpInfo.Controls.Add(this.lblRefValue);
            this.grpInfo.Controls.Add(this.lblStatusCaption);
            this.grpInfo.Controls.Add(this.lblStatusValue);
            this.grpInfo.Controls.Add(this.lblTitleCaption);
            this.grpInfo.Controls.Add(this.lblTitleValue);
            this.grpInfo.Controls.Add(this.lblCategoryCaption);
            this.grpInfo.Controls.Add(this.lblCategoryValue);
            this.grpInfo.Controls.Add(this.lblBudgetCaption);
            this.grpInfo.Controls.Add(this.lblBudgetValue);
            this.grpInfo.Controls.Add(this.lblLocationCaption);
            this.grpInfo.Controls.Add(this.lblLocationValue);
            this.grpInfo.Controls.Add(this.lblOrgCaption);
            this.grpInfo.Controls.Add(this.lblOrgValue);
            this.grpInfo.Controls.Add(this.lblReviewerCaption);
            this.grpInfo.Controls.Add(this.lblReviewerValue);
            this.grpInfo.Controls.Add(this.lblSubmittedCaption);
            this.grpInfo.Controls.Add(this.lblSubmittedValue);
            this.grpInfo.Controls.Add(this.lblDescriptionCaption);
            this.grpInfo.Controls.Add(this.txtDescription);
            this.grpInfo.Location = new System.Drawing.Point(20, 50);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(780, 250);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.Text = "Project";
            // 
            // lblRefCaption
            // 
            this.lblRefCaption.AutoSize = true;
            this.lblRefCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblRefCaption.Location = new System.Drawing.Point(15, 30);
            this.lblRefCaption.Name = "lblRefCaption";
            this.lblRefCaption.Size = new System.Drawing.Size(64, 20);
            this.lblRefCaption.TabIndex = 0;
            this.lblRefCaption.Text = "Reference";
            // 
            // lblRefValue
            // 
            this.lblRefValue.Location = new System.Drawing.Point(130, 30);
            this.lblRefValue.Name = "lblRefValue";
            this.lblRefValue.Size = new System.Drawing.Size(250, 20);
            this.lblRefValue.TabIndex = 1;
            this.lblRefValue.Text = "-";
            // 
            // lblStatusCaption
            // 
            this.lblStatusCaption.AutoSize = true;
            this.lblStatusCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatusCaption.Location = new System.Drawing.Point(400, 30);
            this.lblStatusCaption.Name = "lblStatusCaption";
            this.lblStatusCaption.Size = new System.Drawing.Size(43, 20);
            this.lblStatusCaption.TabIndex = 2;
            this.lblStatusCaption.Text = "Status";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusValue.Location = new System.Drawing.Point(510, 30);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(255, 20);
            this.lblStatusValue.TabIndex = 3;
            this.lblStatusValue.Text = "-";
            // 
            // lblTitleCaption
            // 
            this.lblTitleCaption.AutoSize = true;
            this.lblTitleCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleCaption.Location = new System.Drawing.Point(15, 60);
            this.lblTitleCaption.Name = "lblTitleCaption";
            this.lblTitleCaption.Size = new System.Drawing.Size(36, 20);
            this.lblTitleCaption.TabIndex = 4;
            this.lblTitleCaption.Text = "Title";
            // 
            // lblTitleValue
            // 
            this.lblTitleValue.Location = new System.Drawing.Point(130, 60);
            this.lblTitleValue.Name = "lblTitleValue";
            this.lblTitleValue.Size = new System.Drawing.Size(635, 20);
            this.lblTitleValue.TabIndex = 5;
            this.lblTitleValue.Text = "-";
            // 
            // lblCategoryCaption
            // 
            this.lblCategoryCaption.AutoSize = true;
            this.lblCategoryCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblCategoryCaption.Location = new System.Drawing.Point(15, 90);
            this.lblCategoryCaption.Name = "lblCategoryCaption";
            this.lblCategoryCaption.Size = new System.Drawing.Size(57, 20);
            this.lblCategoryCaption.TabIndex = 6;
            this.lblCategoryCaption.Text = "Category";
            // 
            // lblCategoryValue
            // 
            this.lblCategoryValue.Location = new System.Drawing.Point(130, 90);
            this.lblCategoryValue.Name = "lblCategoryValue";
            this.lblCategoryValue.Size = new System.Drawing.Size(250, 20);
            this.lblCategoryValue.TabIndex = 7;
            this.lblCategoryValue.Text = "-";
            // 
            // lblBudgetCaption
            // 
            this.lblBudgetCaption.AutoSize = true;
            this.lblBudgetCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblBudgetCaption.Location = new System.Drawing.Point(400, 90);
            this.lblBudgetCaption.Name = "lblBudgetCaption";
            this.lblBudgetCaption.Size = new System.Drawing.Size(86, 20);
            this.lblBudgetCaption.TabIndex = 8;
            this.lblBudgetCaption.Text = "Budget (RWF)";
            // 
            // lblBudgetValue
            // 
            this.lblBudgetValue.Location = new System.Drawing.Point(510, 90);
            this.lblBudgetValue.Name = "lblBudgetValue";
            this.lblBudgetValue.Size = new System.Drawing.Size(255, 20);
            this.lblBudgetValue.TabIndex = 9;
            this.lblBudgetValue.Text = "-";
            // 
            // lblLocationCaption
            // 
            this.lblLocationCaption.AutoSize = true;
            this.lblLocationCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblLocationCaption.Location = new System.Drawing.Point(15, 120);
            this.lblLocationCaption.Name = "lblLocationCaption";
            this.lblLocationCaption.Size = new System.Drawing.Size(57, 20);
            this.lblLocationCaption.TabIndex = 10;
            this.lblLocationCaption.Text = "Location";
            // 
            // lblLocationValue
            // 
            this.lblLocationValue.Location = new System.Drawing.Point(130, 120);
            this.lblLocationValue.Name = "lblLocationValue";
            this.lblLocationValue.Size = new System.Drawing.Size(250, 20);
            this.lblLocationValue.TabIndex = 11;
            this.lblLocationValue.Text = "-";
            // 
            // lblOrgCaption
            // 
            this.lblOrgCaption.AutoSize = true;
            this.lblOrgCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblOrgCaption.Location = new System.Drawing.Point(400, 120);
            this.lblOrgCaption.Name = "lblOrgCaption";
            this.lblOrgCaption.Size = new System.Drawing.Size(86, 20);
            this.lblOrgCaption.TabIndex = 12;
            this.lblOrgCaption.Text = "Organization";
            // 
            // lblOrgValue
            // 
            this.lblOrgValue.Location = new System.Drawing.Point(510, 120);
            this.lblOrgValue.Name = "lblOrgValue";
            this.lblOrgValue.Size = new System.Drawing.Size(255, 20);
            this.lblOrgValue.TabIndex = 13;
            this.lblOrgValue.Text = "-";
            // 
            // lblReviewerCaption
            // 
            this.lblReviewerCaption.AutoSize = true;
            this.lblReviewerCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblReviewerCaption.Location = new System.Drawing.Point(15, 150);
            this.lblReviewerCaption.Name = "lblReviewerCaption";
            this.lblReviewerCaption.Size = new System.Drawing.Size(57, 20);
            this.lblReviewerCaption.TabIndex = 14;
            this.lblReviewerCaption.Text = "Reviewer";
            // 
            // lblReviewerValue
            // 
            this.lblReviewerValue.Location = new System.Drawing.Point(130, 150);
            this.lblReviewerValue.Name = "lblReviewerValue";
            this.lblReviewerValue.Size = new System.Drawing.Size(250, 20);
            this.lblReviewerValue.TabIndex = 15;
            this.lblReviewerValue.Text = "-";
            // 
            // lblSubmittedCaption
            // 
            this.lblSubmittedCaption.AutoSize = true;
            this.lblSubmittedCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubmittedCaption.Location = new System.Drawing.Point(400, 150);
            this.lblSubmittedCaption.Name = "lblSubmittedCaption";
            this.lblSubmittedCaption.Size = new System.Drawing.Size(64, 20);
            this.lblSubmittedCaption.TabIndex = 16;
            this.lblSubmittedCaption.Text = "Submitted";
            // 
            // lblSubmittedValue
            // 
            this.lblSubmittedValue.Location = new System.Drawing.Point(510, 150);
            this.lblSubmittedValue.Name = "lblSubmittedValue";
            this.lblSubmittedValue.Size = new System.Drawing.Size(255, 20);
            this.lblSubmittedValue.TabIndex = 17;
            this.lblSubmittedValue.Text = "-";
            // 
            // lblDescriptionCaption
            // 
            this.lblDescriptionCaption.AutoSize = true;
            this.lblDescriptionCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescriptionCaption.Location = new System.Drawing.Point(15, 180);
            this.lblDescriptionCaption.Name = "lblDescriptionCaption";
            this.lblDescriptionCaption.Size = new System.Drawing.Size(79, 20);
            this.lblDescriptionCaption.TabIndex = 18;
            this.lblDescriptionCaption.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescription.Location = new System.Drawing.Point(130, 177);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(635, 60);
            this.txtDescription.TabIndex = 19;
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // lblDecision
            // 
            this.lblDecision.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDecision.Location = new System.Drawing.Point(20, 305);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(780, 20);
            this.lblDecision.TabIndex = 2;
            this.lblDecision.Text = "Decision: none yet";
            // 
            // grpDocuments
            // 
            this.grpDocuments.Controls.Add(this.dgvDocuments);
            this.grpDocuments.Controls.Add(this.btnOpenFile);
            this.grpDocuments.Location = new System.Drawing.Point(20, 330);
            this.grpDocuments.Name = "grpDocuments";
            this.grpDocuments.Size = new System.Drawing.Size(300, 250);
            this.grpDocuments.TabIndex = 3;
            this.grpDocuments.Text = "Documents";
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.Location = new System.Drawing.Point(10, 22);
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AllowUserToDeleteRows = false;
            this.dgvDocuments.AllowUserToResizeRows = false;
            this.dgvDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocuments.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.MultiSelect = false;
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.Size = new System.Drawing.Size(280, 180);
            this.dgvDocuments.TabIndex = 0;
            this.dgvDocuments.ReadOnly = true;
            this.dgvDocuments.RowHeadersVisible = false;
            this.dgvDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocuments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocuments_CellDoubleClick);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(10, 208);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(280, 32);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // grpHistory
            // 
            this.grpHistory.Controls.Add(this.dgvHistory);
            this.grpHistory.Location = new System.Drawing.Point(330, 330);
            this.grpHistory.Name = "grpHistory";
            this.grpHistory.Size = new System.Drawing.Size(470, 250);
            this.grpHistory.TabIndex = 4;
            this.grpHistory.Text = "Review history";
            // 
            // dgvHistory
            // 
            this.dgvHistory.Location = new System.Drawing.Point(10, 22);
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.Size = new System.Drawing.Size(450, 218);
            this.dgvHistory.TabIndex = 0;
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(680, 592);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ProjectDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 640);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpHistory);
            this.Controls.Add(this.grpDocuments);
            this.Controls.Add(this.lblDecision);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProjectDetailsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AQUA - Project Details";
            this.Load += new System.EventHandler(this.ProjectDetailsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpDocuments.ResumeLayout(false);
            this.grpDocuments.PerformLayout();
            this.grpHistory.ResumeLayout(false);
            this.grpHistory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblRefCaption;
        private System.Windows.Forms.Label lblRefValue;
        private System.Windows.Forms.Label lblStatusCaption;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblTitleCaption;
        private System.Windows.Forms.Label lblTitleValue;
        private System.Windows.Forms.Label lblCategoryCaption;
        private System.Windows.Forms.Label lblCategoryValue;
        private System.Windows.Forms.Label lblBudgetCaption;
        private System.Windows.Forms.Label lblBudgetValue;
        private System.Windows.Forms.Label lblLocationCaption;
        private System.Windows.Forms.Label lblLocationValue;
        private System.Windows.Forms.Label lblOrgCaption;
        private System.Windows.Forms.Label lblOrgValue;
        private System.Windows.Forms.Label lblReviewerCaption;
        private System.Windows.Forms.Label lblReviewerValue;
        private System.Windows.Forms.Label lblSubmittedCaption;
        private System.Windows.Forms.Label lblSubmittedValue;
        private System.Windows.Forms.Label lblDescriptionCaption;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.GroupBox grpDocuments;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.GroupBox grpHistory;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnClose;
    }
}
