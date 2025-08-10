using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PetitionLog
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void LoadEntries()
        {
            if (gridView.Columns.Contains("btnEdit"))
                gridView.Columns.Remove("btnEdit");
            if (gridView.Columns.Contains("btnDelete"))
                gridView.Columns.Remove("btnDelete");

            var data = Storage.Load();
            gridView.DataSource = null;
            var sortedList = data.OrderByDescending(p => p.DateUpdated ?? p.DateAdded).ToList();
            var sorted = new SortableBindingList<Petition>();
            foreach (var petition in sortedList)
            {
                sorted.Add(petition);
            }


            gridView.DataSource = null;
            gridView.DataSource = sorted;
            GridFormat.Format(gridView);

            gridView.AllowUserToAddRows = false;
        }

        private bool ValidateAddInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the petitioner's name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            // Add more validation as needed (e.g., for txtType, txtCCE, etc.)
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateAddInputs())
                return;

            var petitions = Storage.Load();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the petitioner's name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Petition newPetition = new Petition
            {
                Name = txtName.Text.ToUpperInvariant(),
                Type = txtType.Text.ToUpperInvariant(),
                CCE = txtCCE.Text.ToUpperInvariant(),
                DateFiled = dtpDateFiled.Value,
                Remarks = txtRemarks.Text.ToUpperInvariant(),
                DateAdded = DateTime.Now,
                DateUpdated = null
            };

            petitions.Add(newPetition);
            Storage.Save(petitions);
            MessageBox.Show("Petition added!");

            LoadEntries();
            txtName.Clear();
            txtType.Clear();
            txtCCE.Clear();
            txtRemarks.Clear();

            tabControl1.SelectedTab = tabView;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
                return;

            var petitions = Storage.Load();
            var searchWords = keyword.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var filtered = petitions.Where(p => p.Name != null && searchWords.All(word => p.Name.ToLower().Contains(word))).ToList();

            gridView.DataSource = null;
            var sortableFiltered = new SortableBindingList<Petition>();
            foreach (var petition in filtered)
            {
                sortableFiltered.Add(petition);
            }
            gridView.DataSource = sortableFiltered;
            GridFormat.Format(gridView);

            DeleteBtn();
            EditBtn();
            if (gridView.Columns.Contains("btnEdit"))
                gridView.Columns["btnEdit"].DisplayIndex = gridView.Columns.Count - 1;
            if (gridView.Columns.Contains("btnDelete"))
                gridView.Columns["btnDelete"].DisplayIndex = gridView.Columns.Count - 1;

            if (gridView.Columns.Contains("DateAdded"))
                gridView.Columns["DateAdded"].Visible = false;
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadEntries();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                    btnSearch.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevents ding sound
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadEntries();
        }

        private void DeleteBtn()
        {
            if (!gridView.Columns.Contains("btnDelete"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.HeaderText = "";
                deleteButton.Text = "Delete";
                deleteButton.Name = "btnDelete";
                deleteButton.UseColumnTextForButtonValue = true;
                gridView.Columns.Add(deleteButton);
            }
        }

        private void EditBtn()
        {
            if (!gridView.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.HeaderText = "";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                editButton.Name = "btnEdit";
                gridView.Columns.Add(editButton);
            }
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            gridView.EndEdit();

            var displayedPetitions = (SortableBindingList<Petition>)gridView.DataSource;

            if (gridView.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                var petitionToRemove = displayedPetitions[e.RowIndex];

                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete the petition from {petitionToRemove.Name}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Load all petitions, remove the one to delete
                    var allPetitions = Storage.Load();
                    var petitionToDelete = allPetitions.FirstOrDefault(p => 
                        p.Name == petitionToRemove.Name && 
                        p.DateAdded == petitionToRemove.DateAdded);
                    
                    if (petitionToDelete != null)
                    {
                        allPetitions.Remove(petitionToDelete);
                        Storage.Save(allPetitions);
                    }
                    
                    displayedPetitions.RemoveAt(e.RowIndex);

                    LoadEntries();
                }
            }
            else if (gridView.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                var petitionToEdit = displayedPetitions[e.RowIndex];

                using (var editForm = new EditForm(petitionToEdit))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Load all petitions, update the edited one
                        var allPetitions = Storage.Load();
                        var existingPetition = allPetitions.FirstOrDefault(p =>
                            p.DateAdded == petitionToEdit.DateAdded);
                        
                        if (existingPetition != null)
                        {
                            // Update the properties
                            existingPetition.Name = petitionToEdit.Name;
                            existingPetition.Type = petitionToEdit.Type;
                            existingPetition.CCE = petitionToEdit.CCE;
                            existingPetition.DateFiled = petitionToEdit.DateFiled;
                            existingPetition.Remarks = petitionToEdit.Remarks;
                            existingPetition.DateUpdated = petitionToEdit.DateUpdated;
                        
                            Storage.Save(allPetitions);
                        }
                        
                        LoadEntries(); // Refresh table
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabAdd)
                this.AcceptButton = btnAdd;
            else
                this.AcceptButton = null;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedTab == tabAdd && e.KeyCode == Keys.Escape)
            {
                tabControl1.SelectedTab = tabView;
                e.Handled = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadEntries();
            gridView.CellContentClick += GridView_CellContentClick;
            gridView.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

    }
}
