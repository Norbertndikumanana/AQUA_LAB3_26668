using AquaApp.Controllers;
using AquaApp.Models;

namespace AquaApp.Views
{
    /// <summary>
    /// Create a new project (projectId = 0), edit one, or resubmit one
    /// after the reviewer asked for more information.
    /// </summary>
    public partial class ProjectFormView : Form
    {
        private readonly ProjectController _projects = new ProjectController();
        private readonly int _projectId;
        private List<Category> _categories = new List<Category>();
        private List<ProjectDocument> _documents = new List<ProjectDocument>();
        private readonly List<int> _removedDocumentIds = new List<int>();

        public ProjectFormView(int projectId)
        {
            InitializeComponent();
            _projectId = projectId;
        }

        private ProjectDocument SelectedDocument => dgvDocuments.CurrentRow?.DataBoundItem as ProjectDocument;

        private void ProjectFormView_Load(object sender, EventArgs e)
        {
            _categories = _projects.GetCategories();
            cboCategory.DataSource = _categories;
            cboCategory.SelectedIndex = -1;

            if (_projectId == 0)
            {
                lblHeading.Text = "New Project";
                btnSave.Text = "Submit Project";
                ShowDocuments();
                return;
            }

            Project p = _projects.GetProject(_projectId);
            if (!_projects.CanEdit(p))
            {
                Ui.Error("This project can no longer be edited.");
                btnSave.Enabled = false;
            }

            lblHeading.Text = "Edit Project";
            lblReference.Text = $"Reference: {p.ReferenceNo}     Status: {p.Status}";
            txtTitle.Text = p.Title;
            txtDescription.Text = p.Description;
            txtLocation.Text = p.Location;
            numBudget.Value = Math.Min(p.Budget, numBudget.Maximum);
            cboCategory.SelectedItem = _categories.FirstOrDefault(c => c.CategoryId == p.CategoryId);

            _documents = _projects.GetDocuments(_projectId);
            ShowDocuments();

            if (p.Status == ProjectStatus.InfoRequested)
            {
                ReviewComment request = _projects.GetLatestInfoRequest(_projectId);
                grpResponse.Visible = true;
                lblRequest.Text = "Request from " + (request?.AuthorName ?? "the reviewer") + ": " + (request?.Text ?? "");
                btnSave.Text = "Resubmit";
            }
            else
            {
                btnSave.Text = "Save Changes";
            }
        }

        private void ShowDocuments()
        {
            dgvDocuments.DataSource = null;
            dgvDocuments.DataSource = _documents.ToList();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) != DialogResult.OK) return;

            string path = openFileDialog.FileName;
            if (!Ui.Ok(_projects.ValidateFile(path))) return;

            string name = Path.GetFileName(path);
            if (_documents.Any(d => d.FileName.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                Ui.Error("A file with this name is already attached.");
                return;
            }

            _documents.Add(new ProjectDocument { FileName = name, FilePath = path, UploadedAt = DateTime.Now });
            ShowDocuments();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Ui.Ok(_projects.OpenDocument(SelectedDocument));
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            ProjectDocument document = SelectedDocument;
            if (document == null) return;
            if (!Ui.Confirm($"Remove {document.FileName}?")) return;

            if (!document.IsNew) _removedDocumentIds.Add(document.DocumentId);
            _documents.Remove(document);
            ShowDocuments();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var project = new Project
            {
                ProjectId = _projectId,
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                Category = cboCategory.SelectedItem as Category,
                Location = txtLocation.Text,
                Budget = numBudget.Value
            };

            string error = _projects.Save(project, _documents, _removedDocumentIds, txtResponse.Text);
            if (!Ui.Ok(error)) return;

            if (_projectId == 0)
                Ui.Info("Your project was submitted.\n\nReference number: " + project.ReferenceNo);
            else
                Ui.Info("Your changes were saved.");

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
