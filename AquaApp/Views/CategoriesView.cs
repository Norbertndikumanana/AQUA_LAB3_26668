using AquaApp.Controllers;
using AquaApp.Helpers;
using AquaApp.Models;

namespace AquaApp.Views
{
    /// <summary>Admin: full CRUD on project categories.</summary>
    public partial class CategoriesView : Form
    {
        private readonly CategoryController _categories = new CategoryController();
        private int _selectedCategoryId;

        public CategoriesView()
        {
            InitializeComponent();
        }

        private void CategoriesView_Load(object sender, EventArgs e)
        {
            if (!Session.IsAdmin)
            {
                Ui.Error("Only an administrator can manage categories.");
                Enabled = false;
                return;
            }
            LoadCategories();
            ClearForm();
        }

        private void LoadCategories()
        {
            dgvCategories.DataSource = _categories.GetAll();
            dgvCategories.ClearSelection();
        }

        private void ClearForm()
        {
            _selectedCategoryId = 0;
            txtName.Clear();
            txtDescription.Clear();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            dgvCategories.ClearSelection();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvCategories.Rows[e.RowIndex].DataBoundItem is not Category category) return;

            _selectedCategoryId = category.CategoryId;
            txtName.Text = category.Name;
            txtDescription.Text = category.Description;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Ui.Ok(_categories.Add(txtName.Text, txtDescription.Text))) return;
            LoadCategories();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Ui.Ok(_categories.Update(_selectedCategoryId, txtName.Text, txtDescription.Text))) return;
            LoadCategories();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryId == 0 || !Ui.Confirm("Delete this category?")) return;
            if (!Ui.Ok(_categories.Delete(_selectedCategoryId))) return;
            LoadCategories();
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
