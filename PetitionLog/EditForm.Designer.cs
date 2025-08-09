namespace PetitionLog
{
    partial class EditForm
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
            txtName = new System.Windows.Forms.TextBox();
            txtType = new System.Windows.Forms.TextBox();
            txtCCE = new System.Windows.Forms.TextBox();
            dtpDateFiled = new System.Windows.Forms.DateTimePicker();
            txtRemarks = new System.Windows.Forms.TextBox();
            lblName = new System.Windows.Forms.Label();
            lblType = new System.Windows.Forms.Label();
            lblCCE = new System.Windows.Forms.Label();
            lblDateFiled = new System.Windows.Forms.Label();
            lblRemarks = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            txtName.Location = new System.Drawing.Point(22, 39);
            txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(404, 23);
            txtName.TabIndex = 3;
            // 
            // txtType
            // 
            txtType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            txtType.Location = new System.Drawing.Point(22, 112);
            txtType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtType.Name = "txtType";
            txtType.Size = new System.Drawing.Size(404, 23);
            txtType.TabIndex = 5;
            // 
            // txtCCE
            // 
            txtCCE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            txtCCE.Location = new System.Drawing.Point(22, 184);
            txtCCE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCCE.Name = "txtCCE";
            txtCCE.Size = new System.Drawing.Size(404, 23);
            txtCCE.TabIndex = 6;
            // 
            // dtpDateFiled
            // 
            dtpDateFiled.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            dtpDateFiled.Location = new System.Drawing.Point(22, 258);
            dtpDateFiled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpDateFiled.Name = "dtpDateFiled";
            dtpDateFiled.Size = new System.Drawing.Size(214, 23);
            dtpDateFiled.TabIndex = 7;
            // 
            // txtRemarks
            // 
            txtRemarks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            txtRemarks.Location = new System.Drawing.Point(22, 322);
            txtRemarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new System.Drawing.Size(740, 23);
            txtRemarks.TabIndex = 8;
            // 
            // lblName
            // 
            lblName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(22, 21);
            lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(134, 15);
            lblName.TabIndex = 9;
            lblName.Text = "Name of Petitioner/Filer";
            // 
            // lblType
            // 
            lblType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lblType.AutoSize = true;
            lblType.Location = new System.Drawing.Point(22, 94);
            lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new System.Drawing.Size(89, 15);
            lblType.TabIndex = 10;
            lblType.Text = "Type of Petition";
            // 
            // lblCCE
            // 
            lblCCE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lblCCE.AutoSize = true;
            lblCCE.Location = new System.Drawing.Point(22, 166);
            lblCCE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCCE.Name = "lblCCE";
            lblCCE.Size = new System.Drawing.Size(76, 15);
            lblCCE.TabIndex = 11;
            lblCCE.Text = "CCE Number";
            // 
            // lblDateFiled
            // 
            lblDateFiled.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lblDateFiled.AutoSize = true;
            lblDateFiled.Location = new System.Drawing.Point(22, 240);
            lblDateFiled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDateFiled.Name = "lblDateFiled";
            lblDateFiled.Size = new System.Drawing.Size(59, 15);
            lblDateFiled.TabIndex = 12;
            lblDateFiled.Text = "Date Filed";
            // 
            // lblRemarks
            // 
            lblRemarks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lblRemarks.AutoSize = true;
            lblRemarks.Location = new System.Drawing.Point(22, 304);
            lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new System.Drawing.Size(52, 15);
            lblRemarks.TabIndex = 13;
            lblRemarks.Text = "Remarks";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(301, 369);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(64, 36);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(439, 369);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(64, 36);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(798, 428);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblRemarks);
            Controls.Add(lblDateFiled);
            Controls.Add(lblCCE);
            Controls.Add(lblType);
            Controls.Add(lblName);
            Controls.Add(txtRemarks);
            Controls.Add(dtpDateFiled);
            Controls.Add(txtCCE);
            Controls.Add(txtType);
            Controls.Add(txtName);
            Name = "EditForm";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtCCE;
        private System.Windows.Forms.DateTimePicker dtpDateFiled;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCCE;
        private System.Windows.Forms.Label lblDateFiled;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}