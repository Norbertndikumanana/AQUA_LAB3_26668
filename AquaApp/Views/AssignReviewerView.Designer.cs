namespace AquaApp.Views
{
    partial class AssignReviewerView
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
            this.lblHint = new System.Windows.Forms.Label();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.lblReviewer = new System.Windows.Forms.Label();
            this.cboReviewer = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnRemoveReviewer = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(20, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(198, 30);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Assign reviewers";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.ForeColor = System.Drawing.Color.DimGray;
            this.lblHint.Location = new System.Drawing.Point(22, 48);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(583, 20);
            this.lblHint.TabIndex = 1;
            this.lblHint.Text = "Projects that are Received or Under Review. Unassigned projects are listed first.";
            // 
            // dgvProjects
            // 
            this.dgvProjects.Location = new System.Drawing.Point(20, 75);
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AllowUserToResizeRows = false;
            this.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjects.BackgroundColor = System.Drawing.Color.White;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.Size = new System.Drawing.Size(860, 350);
            this.dgvProjects.TabIndex = 2;
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.RowHeadersVisible = false;
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellClick);
            // 
            // lblReviewer
            // 
            this.lblReviewer.AutoSize = true;
            this.lblReviewer.Location = new System.Drawing.Point(20, 445);
            this.lblReviewer.Name = "lblReviewer";
            this.lblReviewer.Size = new System.Drawing.Size(57, 20);
            this.lblReviewer.TabIndex = 3;
            this.lblReviewer.Text = "Reviewer";
            // 
            // cboReviewer
            // 
            this.cboReviewer.FormattingEnabled = true;
            this.cboReviewer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReviewer.Location = new System.Drawing.Point(90, 442);
            this.cboReviewer.Name = "cboReviewer";
            this.cboReviewer.Size = new System.Drawing.Size(260, 23);
            this.cboReviewer.TabIndex = 4;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Location = new System.Drawing.Point(365, 438);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(160, 32);
            this.btnAssign.TabIndex = 5;
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Text = "Assign / Reassign";
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnRemoveReviewer
            // 
            this.btnRemoveReviewer.Location = new System.Drawing.Point(535, 438);
            this.btnRemoveReviewer.Name = "btnRemoveReviewer";
            this.btnRemoveReviewer.Size = new System.Drawing.Size(160, 32);
            this.btnRemoveReviewer.TabIndex = 6;
            this.btnRemoveReviewer.UseVisualStyleBackColor = true;
            this.btnRemoveReviewer.Text = "Remove Reviewer";
            this.btnRemoveReviewer.Click += new System.EventHandler(this.btnRemoveReviewer_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(705, 438);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(175, 32);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(760, 505);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AssignReviewerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 552);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRemoveReviewer);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cboReviewer);
            this.Controls.Add(this.lblReviewer);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AssignReviewerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AQUA - Assign Reviewers";
            this.Load += new System.EventHandler(this.AssignReviewerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Label lblReviewer;
        private System.Windows.Forms.ComboBox cboReviewer;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnRemoveReviewer;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
    }
}
