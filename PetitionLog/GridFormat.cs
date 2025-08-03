using System.Drawing;
using System.Windows.Forms;

namespace PetitionLog
{
    public static class GridFormat
    {
        public static void Format(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.DefaultCellStyle.Font = new Font("Arial", 14);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;

            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv.Columns["Remarks"].FillWeight = 200;
            dgv.Columns["Name"].FillWeight = 150;
            dgv.Columns["Type"].FillWeight = 80;
            dgv.Columns["btnDelete"].FillWeight = 60;

            // Rename headers
            if (dgv.Columns.Contains("Name")) dgv.Columns["Name"].HeaderText = "Name of Petitioner/Filer";
            if (dgv.Columns.Contains("Type")) dgv.Columns["Type"].HeaderText = "Petition Type";
            if (dgv.Columns.Contains("CCE")) dgv.Columns["CCE"].HeaderText = "CCE Number";
            if (dgv.Columns.Contains("DateFiled")) dgv.Columns["DateFiled"].HeaderText = "Date Filed";
            if (dgv.Columns.Contains("DateAdded")) dgv.Columns["DateAdded"].HeaderText = "Date Added";
            if (dgv.Columns.Contains("Remarks")) dgv.Columns["Remarks"].HeaderText = "Remarks";
            if (dgv.Columns.Contains("btnDelete")) dgv.Columns["btnDelete"].HeaderText = " ";

            // Format dates
            if (dgv.Columns.Contains("DateFiled")) dgv.Columns["DateFiled"].DefaultCellStyle.Format = "MMM d, yyyy";
            if (dgv.Columns.Contains("DateAdded")) dgv.Columns["DateAdded"].DefaultCellStyle.Format = "MMM d, yyyy";

            // Set column display order
            if (dgv.Columns.Contains("btnDelete")) dgv.Columns["btnDelete"].DisplayIndex = dgv.Columns.Count - 1;
        }
    }
}
