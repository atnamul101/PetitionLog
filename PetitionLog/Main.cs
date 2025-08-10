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

            gridView.DataSource = null;
            gridView.DataSource = Storage.Load();

            GridFormat.Format(gridView);

            gridView.AllowUserToAddRows = false;

            if (gridView.Columns.Contains("DateAdded"))
            {
                gridView.Sort(gridView.Columns["DateAdded"], ListSortDirection.Descending);
                gridView.Columns["DateAdded"].Visible = false;      // hide column but still sort
            }

            //highlight
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (row.Cells["DateAdded"].Value is DateTime dateAdded)
                {
                    TimeSpan age = DateTime.Now - dateAdded;

                    if (age.TotalDays >= 32)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral; // red
                    }
                    else if (age.TotalDays >= 21)
                    {
                        row.DefaultCellStyle.BackColor = Color.Khaki; // yellow
                    }
                    // else do nothing (default)
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var petitions = Storage.Load();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the petitioner's name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Petition newPetition = new Petition
            {
                Name = txtName.Text,
                Type = txtType.Text,
                CCE = txtCCE.Text,
                DateFiled = dtpDateFiled.Value,
                Remarks = txtRemarks.Text,
                DateAdded = DateTime.Now,
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
            var petitions = Storage.Load();
            string keyword = txtSearch.Text.ToLower();
            string filterBy = cmbFilter.SelectedItem?.ToString() ?? "All";

            var filtered = petitions.Where(p =>
                string.IsNullOrWhiteSpace(keyword) || filterBy == "All" ||
                (filterBy == "Name" && p.Name.ToLower().Contains(keyword)) ||
                (filterBy == "Type" && p.Type.ToLower().Contains(keyword)) ||
                (filterBy == "CCE" && p.CCE.ToLower().Contains(keyword)) ||
                (filterBy == "Remarks" && p.Remarks.ToLower().Contains(keyword)) ||
                (filterBy == "All" && ( p.Name.ToLower().Contains(keyword) || p.Type.ToLower().Contains(keyword) || p.CCE.ToLower().Contains(keyword) || p.Remarks.ToLower().Contains(keyword)))).ToList();

            gridView.DataSource = null;
            gridView.DataSource = filtered;

            DeleteBtn();
            EditBtn();
            if (gridView.Columns.Contains("btnEdit"))
                gridView.Columns["btnEdit"].DisplayIndex = gridView.Columns.Count - 1;
            if (gridView.Columns.Contains("btnDelete"))
                gridView.Columns["btnDelete"].DisplayIndex = gridView.Columns.Count - 1;

            if (gridView.Columns.Contains("DateAdded"))
                gridView.Columns["DateAdded"].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilter.SelectedIndex = 0;
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

            var petitions = (SortableBindingList<Petition>)gridView.DataSource;

            if (gridView.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                var petitionToRemove = petitions[e.RowIndex];

                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete the petition from {petitionToRemove.Name}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    petitions.RemoveAt(e.RowIndex);
                    Storage.Save(petitions);
                }
            }

            else if (gridView.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                var petitionToEdit = petitions[e.RowIndex];

                using (var editForm = new EditForm(petitionToEdit))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        Storage.Save(petitions); // Save updated list
                        LoadEntries();           // Refresh table
                    }
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadEntries();
            cmbFilter.SelectedIndex = 0;
            gridView.CellContentClick += GridView_CellContentClick;
            gridView.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btnPurge_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
        "Are you sure you want to purge all entries older than 32 days?",
        "Confirm Purge", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Storage.Purge(32);
                LoadEntries();
            }
        }
    }
}
