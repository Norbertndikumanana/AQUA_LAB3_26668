namespace AquaApp.Views
{
    partial class ReviewView
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
            this.grpProject = new System.Windows.Forms.GroupBox();
            this.lblRefCaption = new System.Windows.Forms.Label();
            this.lblRefValue = new System.Windows.Forms.Label();
            this.lblTitleCaption = new System.Windows.Forms.Label();
            this.lblTitleValue = new System.Windows.Forms.Label();
            this.lblOrgCaption = new System.Windows.Forms.Label();
            this.lblOrgValue = new System.Windows.Forms.Label();
            this.lblStatusCaption = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblReviewerCaption = new System.Windows.Forms.Label();
            this.lblReviewerValue = new System.Windows.Forms.Label();
            this.lblDescriptionCaption = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.grpDocuments = new System.Windows.Forms.GroupBox();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.grpComments = new System.Windows.Forms.GroupBox();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnEditComment = new System.Windows.Forms.Button();
            this.btnDeleteComment = new System.Windows.Forms.Button();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnRequestInfo = new System.Windows.Forms.Button();
            this.lblRequestHint = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpProject.SuspendLayout();
            this.grpDocuments.SuspendLayout();
            this.grpComments.SuspendLayout();
            this.grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(20, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(173, 30);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Review project";
            // 
            // grpProject
            // 
            this.grpProject.Controls.Add(this.lblRefCaption);
            this.grpProject.Controls.Add(this.lblRefValue);
            this.grpProject.Controls.Add(this.lblTitleCaption);
            this.grpProject.Controls.Add(this.lblTitleValue);
            this.grpProject.Controls.Add(this.lblOrgCaption);
            this.grpProject.Controls.Add(this.lblOrgValue);
            this.grpProject.Controls.Add(this.lblStatusCaption);
            this.grpProject.Controls.Add(this.lblStatusValue);
            this.grpProject.Controls.Add(this.lblReviewerCaption);
            this.grpProject.Controls.Add(this.lblReviewerValue);
            this.grpProject.Controls.Add(this.lblDescriptionCaption);
            this.grpProject.Controls.Add(this.txtDescription);
            this.grpProject.Location = new System.Drawing.Point(20, 50);
            this.grpProject.Name = "grpProject";
            this.grpProject.Size = new System.Drawing.Size(460, 300);
            this.grpProject.TabIndex = 1;
            this.grpProject.Text = "Project";
            // 
            // lblRefCaption
            // 
            this.lblRefCaption.AutoSize = true;
            this.lblRefCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblRefCaption.Location = new System.Drawing.Point(15, 28);
            this.lblRefCaption.Name = "lblRefCaption";
            this.lblRefCaption.Size = new System.Drawing.Size(64, 20);
            this.lblRefCaption.TabIndex = 0;
            this.lblRefCaption.Text = "Reference";
            // 
            // lblRefValue
            // 
            this.lblRefValue.Location = new System.Drawing.Point(120, 28);
            this.lblRefValue.Name = "lblRefValue";
            this.lblRefValue.Size = new System.Drawing.Size(325, 20);
            this.lblRefValue.TabIndex = 1;
            this.lblRefValue.Text = "-";
            // 
            // lblTitleCaption
            // 
            this.lblTitleCaption.AutoSize = true;
            this.lblTitleCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleCaption.Location = new System.Drawing.Point(15, 55);
            this.lblTitleCaption.Name = "lblTitleCaption";
            this.lblTitleCaption.Size = new System.Drawing.Size(36, 20);
            this.lblTitleCaption.TabIndex = 2;
            this.lblTitleCaption.Text = "Title";
            // 
            // lblTitleValue
            // 
            this.lblTitleValue.Location = new System.Drawing.Point(120, 55);
            this.lblTitleValue.Name = "lblTitleValue";
            this.lblTitleValue.Size = new System.Drawing.Size(325, 20);
            this.lblTitleValue.TabIndex = 3;
            this.lblTitleValue.Text = "-";
            // 
            // lblOrgCaption
            // 
            this.lblOrgCaption.AutoSize = true;
            this.lblOrgCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblOrgCaption.Location = new System.Drawing.Point(15, 82);
            this.lblOrgCaption.Name = "lblOrgCaption";
            this.lblOrgCaption.Size = new System.Drawing.Size(86, 20);
            this.lblOrgCaption.TabIndex = 4;
            this.lblOrgCaption.Text = "Organization";
            // 
            // lblOrgValue
            // 
            this.lblOrgValue.Location = new System.Drawing.Point(120, 82);
            this.lblOrgValue.Name = "lblOrgValue";
            this.lblOrgValue.Size = new System.Drawing.Size(325, 20);
            this.lblOrgValue.TabIndex = 5;
            this.lblOrgValue.Text = "-";
            // 
            // lblStatusCaption
            // 
            this.lblStatusCaption.AutoSize = true;
            this.lblStatusCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatusCaption.Location = new System.Drawing.Point(15, 109);
            this.lblStatusCaption.Name = "lblStatusCaption";
            this.lblStatusCaption.Size = new System.Drawing.Size(43, 20);
            this.lblStatusCaption.TabIndex = 6;
            this.lblStatusCaption.Text = "Status";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusValue.Location = new System.Drawing.Point(120, 109);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(325, 20);
            this.lblStatusValue.TabIndex = 7;
            this.lblStatusValue.Text = "-";
            // 
            // lblReviewerCaption
            // 
            this.lblReviewerCaption.AutoSize = true;
            this.lblReviewerCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblReviewerCaption.Location = new System.Drawing.Point(15, 136);
            this.lblReviewerCaption.Name = "lblReviewerCaption";
            this.lblReviewerCaption.Size = new System.Drawing.Size(57, 20);
            this.lblReviewerCaption.TabIndex = 8;
            this.lblReviewerCaption.Text = "Reviewer";
            // 
            // lblReviewerValue
            // 
            this.lblReviewerValue.Location = new System.Drawing.Point(120, 136);
            this.lblReviewerValue.Name = "lblReviewerValue";
            this.lblReviewerValue.Size = new System.Drawing.Size(325, 20);
            this.lblReviewerValue.TabIndex = 9;
            this.lblReviewerValue.Text = "-";
            // 
            // lblDescriptionCaption
            // 
            this.lblDescriptionCaption.AutoSize = true;
            this.lblDescriptionCaption.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescriptionCaption.Location = new System.Drawing.Point(15, 163);
            this.lblDescriptionCaption.Name = "lblDescriptionCaption";
            this.lblDescriptionCaption.Size = new System.Drawing.Size(79, 20);
            this.lblDescriptionCaption.TabIndex = 10;
            this.lblDescriptionCaption.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescription.Location = new System.Drawing.Point(15, 185);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(430, 100);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // grpDocuments
            // 
            this.grpDocuments.Controls.Add(this.dgvDocuments);
            this.grpDocuments.Controls.Add(this.btnOpenFile);
            this.grpDocuments.Location = new System.Drawing.Point(20, 360);
            this.grpDocuments.Name = "grpDocuments";
            this.grpDocuments.Size = new System.Drawing.Size(460, 250);
            this.grpDocuments.TabIndex = 2;
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
            this.dgvDocuments.Size = new System.Drawing.Size(440, 180);
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
            this.btnOpenFile.Size = new System.Drawing.Size(440, 32);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // grpComments
            // 
            this.grpComments.Controls.Add(this.dgvComments);
            this.grpComments.Controls.Add(this.lblComment);
            this.grpComments.Controls.Add(this.txtComment);
            this.grpComments.Controls.Add(this.btnAddComment);
            this.grpComments.Controls.Add(this.btnEditComment);
            this.grpComments.Controls.Add(this.btnDeleteComment);
            this.grpComments.Location = new System.Drawing.Point(500, 50);
            this.grpComments.Name = "grpComments";
            this.grpComments.Size = new System.Drawing.Size(480, 340);
            this.grpComments.TabIndex = 3;
            this.grpComments.Text = "Comments";
            // 
            // dgvComments
            // 
            this.dgvComments.Location = new System.Drawing.Point(15, 25);
            this.dgvComments.AllowUserToAddRows = false;
            this.dgvComments.AllowUserToDeleteRows = false;
            this.dgvComments.AllowUserToResizeRows = false;
            this.dgvComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComments.BackgroundColor = System.Drawing.Color.White;
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.MultiSelect = false;
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.Size = new System.Drawing.Size(450, 190);
            this.dgvComments.TabIndex = 0;
            this.dgvComments.ReadOnly = true;
            this.dgvComments.RowHeadersVisible = false;
            this.dgvComments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComments_CellClick);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(15, 222);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(417, 20);
            this.lblComment.TabIndex = 1;
            this.lblComment.Text = "Comment, or the information you need from the organization";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(15, 242);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(450, 50);
            this.txtComment.TabIndex = 2;
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // btnAddComment
            // 
            this.btnAddComment.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddComment.ForeColor = System.Drawing.Color.White;
            this.btnAddComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComment.Location = new System.Drawing.Point(15, 298);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(140, 32);
            this.btnAddComment.TabIndex = 3;
            this.btnAddComment.UseVisualStyleBackColor = false;
            this.btnAddComment.Text = "Add Comment";
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnEditComment
            // 
            this.btnEditComment.Location = new System.Drawing.Point(165, 298);
            this.btnEditComment.Name = "btnEditComment";
            this.btnEditComment.Size = new System.Drawing.Size(140, 32);
            this.btnEditComment.TabIndex = 4;
            this.btnEditComment.UseVisualStyleBackColor = true;
            this.btnEditComment.Text = "Update Comment";
            this.btnEditComment.Click += new System.EventHandler(this.btnEditComment_Click);
            // 
            // btnDeleteComment
            // 
            this.btnDeleteComment.Location = new System.Drawing.Point(315, 298);
            this.btnDeleteComment.Name = "btnDeleteComment";
            this.btnDeleteComment.Size = new System.Drawing.Size(150, 32);
            this.btnDeleteComment.TabIndex = 5;
            this.btnDeleteComment.UseVisualStyleBackColor = true;
            this.btnDeleteComment.Text = "Delete Comment";
            this.btnDeleteComment.Click += new System.EventHandler(this.btnDeleteComment_Click);
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnRequestInfo);
            this.grpActions.Controls.Add(this.lblRequestHint);
            this.grpActions.Controls.Add(this.lblReason);
            this.grpActions.Controls.Add(this.txtReason);
            this.grpActions.Controls.Add(this.btnApprove);
            this.grpActions.Controls.Add(this.btnReject);
            this.grpActions.Location = new System.Drawing.Point(500, 400);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(480, 210);
            this.grpActions.TabIndex = 4;
            this.grpActions.Text = "Review actions";
            // 
            // btnRequestInfo
            // 
            this.btnRequestInfo.Location = new System.Drawing.Point(15, 25);
            this.btnRequestInfo.Name = "btnRequestInfo";
            this.btnRequestInfo.Size = new System.Drawing.Size(450, 34);
            this.btnRequestInfo.TabIndex = 0;
            this.btnRequestInfo.UseVisualStyleBackColor = true;
            this.btnRequestInfo.Text = "Request More Info";
            this.btnRequestInfo.Click += new System.EventHandler(this.btnRequestInfo_Click);
            // 
            // lblRequestHint
            // 
            this.lblRequestHint.AutoSize = true;
            this.lblRequestHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblRequestHint.Location = new System.Drawing.Point(15, 62);
            this.lblRequestHint.Name = "lblRequestHint";
            this.lblRequestHint.Size = new System.Drawing.Size(352, 20);
            this.lblRequestHint.TabIndex = 1;
            this.lblRequestHint.Text = "Sends the text in the comment box as the request.";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(15, 88);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(338, 20);
            this.lblReason.TabIndex = 2;
            this.lblReason.Text = "Decision reason (required to approve or reject)";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(15, 108);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(450, 50);
            this.txtReason.TabIndex = 3;
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.SeaGreen;
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Location = new System.Drawing.Point(15, 165);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(220, 34);
            this.btnApprove.TabIndex = 4;
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Text = "Approve";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Firebrick;
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Location = new System.Drawing.Point(245, 165);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(220, 34);
            this.btnReject.TabIndex = 5;
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Text = "Reject";
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(860, 630);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ReviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpComments);
            this.Controls.Add(this.grpDocuments);
            this.Controls.Add(this.grpProject);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReviewView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AQUA - Review Project";
            this.Load += new System.EventHandler(this.ReviewView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            this.grpProject.ResumeLayout(false);
            this.grpProject.PerformLayout();
            this.grpDocuments.ResumeLayout(false);
            this.grpDocuments.PerformLayout();
            this.grpComments.ResumeLayout(false);
            this.grpComments.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpProject;
        private System.Windows.Forms.Label lblRefCaption;
        private System.Windows.Forms.Label lblRefValue;
        private System.Windows.Forms.Label lblTitleCaption;
        private System.Windows.Forms.Label lblTitleValue;
        private System.Windows.Forms.Label lblOrgCaption;
        private System.Windows.Forms.Label lblOrgValue;
        private System.Windows.Forms.Label lblStatusCaption;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblReviewerCaption;
        private System.Windows.Forms.Label lblReviewerValue;
        private System.Windows.Forms.Label lblDescriptionCaption;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox grpDocuments;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.GroupBox grpComments;
        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnEditComment;
        private System.Windows.Forms.Button btnDeleteComment;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnRequestInfo;
        private System.Windows.Forms.Label lblRequestHint;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnClose;
    }
}
