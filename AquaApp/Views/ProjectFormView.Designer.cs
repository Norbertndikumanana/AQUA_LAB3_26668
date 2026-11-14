namespace AquaApp.Views
{
    partial class ProjectFormView
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
            this.lblReference = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.numBudget = new System.Windows.Forms.NumericUpDown();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.grpDocuments = new System.Windows.Forms.GroupBox();
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.grpResponse = new System.Windows.Forms.GroupBox();
            this.lblRequest = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpDocuments.SuspendLayout();
            this.grpResponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(20, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(136, 30);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "New Project";
            // 
            // lblReference
            // 
            this.lblReference.ForeColor = System.Drawing.Color.DimGray;
            this.lblReference.Location = new System.Drawing.Point(22, 48);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(500, 20);
            this.lblReference.TabIndex = 1;
            this.lblReference.Text = "Reference: assigned when you submit";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 85);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(150, 82);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(600, 23);
            this.txtTitle.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 120);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 20);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Location = new System.Drawing.Point(150, 117);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(250, 23);
            this.cboCategory.TabIndex = 5;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(420, 120);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(86, 20);
            this.lblBudget.TabIndex = 6;
            this.lblBudget.Text = "Budget (RWF)";
            // 
            // numBudget
            // 
            this.numBudget.Location = new System.Drawing.Point(520, 117);
            this.numBudget.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            this.numBudget.Name = "numBudget";
            this.numBudget.Size = new System.Drawing.Size(230, 23);
            this.numBudget.TabIndex = 7;
            this.numBudget.ThousandsSeparator = true;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(20, 155);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(57, 20);
            this.lblLocation.TabIndex = 8;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(150, 152);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(600, 23);
            this.txtLocation.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 190);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 20);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 187);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(600, 110);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // grpDocuments
            // 
            this.grpDocuments.Controls.Add(this.dgvDocuments);
            this.grpDocuments.Controls.Add(this.btnAddFile);
            this.grpDocuments.Controls.Add(this.btnOpenFile);
            this.grpDocuments.Controls.Add(this.btnRemoveFile);
            this.grpDocuments.Location = new System.Drawing.Point(20, 310);
            this.grpDocuments.Name = "grpDocuments";
            this.grpDocuments.Size = new System.Drawing.Size(740, 170);
            this.grpDocuments.TabIndex = 12;
            this.grpDocuments.Text = "Supporting documents";
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.Location = new System.Drawing.Point(15, 25);
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AllowUserToDeleteRows = false;
            this.dgvDocuments.AllowUserToResizeRows = false;
            this.dgvDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocuments.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.MultiSelect = false;
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.Size = new System.Drawing.Size(580, 130);
            this.dgvDocuments.TabIndex = 0;
            this.dgvDocuments.ReadOnly = true;
            this.dgvDocuments.RowHeadersVisible = false;
            this.dgvDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(610, 25);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(115, 32);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Text = "Add File...";
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(610, 65);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(115, 32);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(610, 105);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(115, 32);
            this.btnRemoveFile.TabIndex = 3;
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Text = "Remove File";
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // grpResponse
            // 
            this.grpResponse.Controls.Add(this.lblRequest);
            this.grpResponse.Controls.Add(this.txtResponse);
            this.grpResponse.Location = new System.Drawing.Point(20, 490);
            this.grpResponse.Name = "grpResponse";
            this.grpResponse.Size = new System.Drawing.Size(740, 110);
            this.grpResponse.TabIndex = 13;
            this.grpResponse.Visible = false;
            this.grpResponse.Text = "Reviewer's request and your response";
            // 
            // lblRequest
            // 
            this.lblRequest.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRequest.Location = new System.Drawing.Point(15, 25);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(710, 20);
            this.lblRequest.TabIndex = 0;
            this.lblRequest.Text = "Request:";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(15, 65);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(710, 32);
            this.txtResponse.TabIndex = 1;
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(470, 612);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 36);
            this.btnSave.TabIndex = 14;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Text = "Submit Project";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(620, 612);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 36);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Documents (*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.jpg;*.jpeg;*.png)|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.jpg;*.jpeg;*.png";
            this.openFileDialog.Title = "Choose a supporting document";
            // 
            // ProjectFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 660);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpResponse);
            this.Controls.Add(this.grpDocuments);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.numBudget);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProjectFormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AQUA - Project";
            this.Load += new System.EventHandler(this.ProjectFormView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            this.grpDocuments.ResumeLayout(false);
            this.grpDocuments.PerformLayout();
            this.grpResponse.ResumeLayout(false);
            this.grpResponse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.NumericUpDown numBudget;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox grpDocuments;
        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.GroupBox grpResponse;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
