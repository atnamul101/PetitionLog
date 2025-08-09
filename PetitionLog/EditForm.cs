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
    public partial class EditForm : Form
    {
        public Petition PetitionData { get; private set; }

        public EditForm(Petition petition)
        {
            InitializeComponent();
            PetitionData = petition;

            // Pre-fill fields
            txtName.Text = petition.Name;
            txtType.Text = petition.Type;
            txtCCE.Text = petition.CCE;
            dtpDateFiled.Value = petition.DateFiled;
            txtRemarks.Text = petition.Remarks;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PetitionData.Name = txtName.Text;
            PetitionData.Type = txtType.Text;
            PetitionData.CCE = txtCCE.Text;
            PetitionData.DateFiled = dtpDateFiled.Value;
            PetitionData.Remarks = txtRemarks.Text;

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
