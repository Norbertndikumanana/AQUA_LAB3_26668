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
            lblHeading = new Label();
            lblHint = new Label();
            dgvProjects = new DataGridView();
            lblReviewer = new Label();
            cboReviewer = new ComboBox();
            btnAssign = new Button();
            btnRemoveReviewer = new Button();
            btnRefresh = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeading.Location = new Point(20, 15);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(159, 25);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Assign reviewers";
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.ForeColor = Color.DimGray;
            lblHint.Location = new Point(22, 48);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(419, 15);
            lblHint.TabIndex = 1;
            lblHint.Text = "Projects that are Received or Under Review. Unassigned projects are listed first.";
            // 
            // dgvProjects
            // 
            dgvProjects.AllowUserToAddRows = false;
            dgvProjects.AllowUserToDeleteRows = false;
            dgvProjects.AllowUserToResizeRows = false;
            dgvProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProjects.BackgroundColor = Color.White;
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Location = new Point(20, 75);
            dgvProjects.MultiSelect = false;
            dgvProjects.Name = "dgvProjects";
            dgvProjects.ReadOnly = true;
            dgvProjects.RowHeadersVisible = false;
            dgvProjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProjects.Size = new Size(860, 350);
            dgvProjects.TabIndex = 2;
            dgvProjects.CellClick += dgvProjects_CellClick;
            // 
            // lblReviewer
            // 
            lblReviewer.AutoSize = true;
            lblReviewer.Location = new Point(20, 445);
            lblReviewer.Name = "lblReviewer";
            lblReviewer.Size = new Size(54, 15);
            lblReviewer.TabIndex = 3;
            lblReviewer.Text = "Reviewer";
            // 
            // cboReviewer
            // 
            cboReviewer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboReviewer.FormattingEnabled = true;
            cboReviewer.Location = new Point(90, 442);
            cboReviewer.Name = "cboReviewer";
            cboReviewer.Size = new Size(260, 23);
            cboReviewer.TabIndex = 4;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.SteelBlue;
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(369, 438);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(160, 32);
            btnAssign.TabIndex = 5;
            btnAssign.Text = "Assign / Reassign";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // btnRemoveReviewer
            // 
            btnRemoveReviewer.Location = new Point(535, 438);
            btnRemoveReviewer.Name = "btnRemoveReviewer";
            btnRemoveReviewer.Size = new Size(160, 32);
            btnRemoveReviewer.TabIndex = 6;
            btnRemoveReviewer.Text = "Remove Reviewer";
            btnRemoveReviewer.UseVisualStyleBackColor = true;
            btnRemoveReviewer.Click += btnRemoveReviewer_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(705, 438);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(175, 32);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(760, 505);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 32);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AssignReviewerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 552);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(btnRemoveReviewer);
            Controls.Add(btnAssign);
            Controls.Add(cboReviewer);
            Controls.Add(lblReviewer);
            Controls.Add(dgvProjects);
            Controls.Add(lblHint);
            Controls.Add(lblHeading);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AssignReviewerView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AQUA - Assign Reviewers";
            Load += AssignReviewerView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
