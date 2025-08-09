namespace PetitionLog
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            gridView = new System.Windows.Forms.DataGridView();
            btnAdd = new System.Windows.Forms.Button();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabView = new System.Windows.Forms.TabPage();
            lblPurge = new System.Windows.Forms.Label();
            btnPurge = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            cmbFilter = new System.Windows.Forms.ComboBox();
            lblSearch2 = new System.Windows.Forms.Label();
            lblRefresh = new System.Windows.Forms.Label();
            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            tabAdd = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            txtRemarks = new System.Windows.Forms.TextBox();
            lblRemarks = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            dtpDateFiled = new System.Windows.Forms.DateTimePicker();
            txtName = new System.Windows.Forms.TextBox();
            lblDateFiled = new System.Windows.Forms.Label();
            lblCCE = new System.Windows.Forms.Label();
            txtCCE = new System.Windows.Forms.TextBox();
            lblType = new System.Windows.Forms.Label();
            txtType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            tabControl1.SuspendLayout();
            tabView.SuspendLayout();
            tabAdd.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridView
            // 
            gridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Location = new System.Drawing.Point(0, 90);
            gridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridView.Name = "gridView";
            gridView.Size = new System.Drawing.Size(1462, 644);
            gridView.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.Location = new System.Drawing.Point(688, 359);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(76, 73);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "✔";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabView);
            tabControl1.Controls.Add(tabAdd);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1475, 786);
            tabControl1.TabIndex = 2;
            // 
            // tabView
            // 
            tabView.Controls.Add(lblPurge);
            tabView.Controls.Add(btnPurge);
            tabView.Controls.Add(btnRefresh);
            tabView.Controls.Add(btnSearch);
            tabView.Controls.Add(cmbFilter);
            tabView.Controls.Add(lblSearch2);
            tabView.Controls.Add(lblRefresh);
            tabView.Controls.Add(lblSearch);
            tabView.Controls.Add(txtSearch);
            tabView.Controls.Add(gridView);
            tabView.Location = new System.Drawing.Point(4, 38);
            tabView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabView.Name = "tabView";
            tabView.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabView.Size = new System.Drawing.Size(1467, 744);
            tabView.TabIndex = 0;
            tabView.Text = "View";
            tabView.UseVisualStyleBackColor = true;
            // 
            // lblPurge
            // 
            lblPurge.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblPurge.AutoSize = true;
            lblPurge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblPurge.Location = new System.Drawing.Point(1396, 63);
            lblPurge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPurge.Name = "lblPurge";
            lblPurge.Size = new System.Drawing.Size(51, 20);
            lblPurge.TabIndex = 6;
            lblPurge.Text = "Purge";
            // 
            // btnPurge
            // 
            btnPurge.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPurge.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnPurge.BackgroundImage");
            btnPurge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnPurge.Location = new System.Drawing.Point(1398, 7);
            btnPurge.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPurge.Name = "btnPurge";
            btnPurge.Size = new System.Drawing.Size(58, 54);
            btnPurge.TabIndex = 5;
            btnPurge.UseVisualStyleBackColor = true;
            btnPurge.Click += btnPurge_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnRefresh.BackgroundImage");
            btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnRefresh.Location = new System.Drawing.Point(628, 28);
            btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(58, 54);
            btnRefresh.TabIndex = 4;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.Transparent;
            btnSearch.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            btnSearch.Location = new System.Drawing.Point(562, 28);
            btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(58, 54);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "All", "Name", "Type", "CCE", "Remarks" });
            cmbFilter.Location = new System.Drawing.Point(328, 40);
            cmbFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new System.Drawing.Size(213, 37);
            cmbFilter.TabIndex = 3;
            // 
            // lblSearch2
            // 
            lblSearch2.AutoSize = true;
            lblSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSearch2.Location = new System.Drawing.Point(565, 7);
            lblSearch2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSearch2.Name = "lblSearch2";
            lblSearch2.Size = new System.Drawing.Size(55, 18);
            lblSearch2.TabIndex = 2;
            lblSearch2.Text = "Search";
            // 
            // lblRefresh
            // 
            lblRefresh.AutoSize = true;
            lblRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRefresh.Location = new System.Drawing.Point(628, 7);
            lblRefresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRefresh.Name = "lblRefresh";
            lblRefresh.Size = new System.Drawing.Size(60, 18);
            lblRefresh.TabIndex = 2;
            lblRefresh.Text = "Refresh";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new System.Drawing.Point(7, 6);
            lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(89, 29);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(7, 43);
            txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(299, 35);
            txtSearch.TabIndex = 1;
            // 
            // tabAdd
            // 
            tabAdd.AutoScrollMargin = new System.Drawing.Size(0, 500);
            tabAdd.Controls.Add(panel1);
            tabAdd.Location = new System.Drawing.Point(4, 38);
            tabAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabAdd.Name = "tabAdd";
            tabAdd.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabAdd.Size = new System.Drawing.Size(1467, 744);
            tabAdd.TabIndex = 1;
            tabAdd.Text = "Add";
            tabAdd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtRemarks);
            panel1.Controls.Add(lblRemarks);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(dtpDateFiled);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblDateFiled);
            panel1.Controls.Add(lblCCE);
            panel1.Controls.Add(txtCCE);
            panel1.Controls.Add(lblType);
            panel1.Controls.Add(txtType);
            panel1.Location = new System.Drawing.Point(9, 7);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1449, 465);
            panel1.TabIndex = 8;
            // 
            // txtRemarks
            // 
            txtRemarks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            txtRemarks.Location = new System.Drawing.Point(680, 261);
            txtRemarks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new System.Drawing.Size(740, 35);
            txtRemarks.TabIndex = 7;
            // 
            // lblRemarks
            // 
            lblRemarks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lblRemarks.AutoSize = true;
            lblRemarks.Location = new System.Drawing.Point(674, 224);
            lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new System.Drawing.Size(109, 29);
            lblRemarks.TabIndex = 3;
            lblRemarks.Text = "Remarks";
            // 
            // lblName
            // 
            lblName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(29, 43);
            lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(269, 29);
            lblName.TabIndex = 3;
            lblName.Text = "Name of Petitioner/Filer";
            // 
            // dtpDateFiled
            // 
            dtpDateFiled.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            dtpDateFiled.Location = new System.Drawing.Point(35, 261);
            dtpDateFiled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpDateFiled.Name = "dtpDateFiled";
            dtpDateFiled.Size = new System.Drawing.Size(501, 35);
            dtpDateFiled.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            txtName.Location = new System.Drawing.Point(35, 80);
            txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(404, 35);
            txtName.TabIndex = 2;
            // 
            // lblDateFiled
            // 
            lblDateFiled.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lblDateFiled.AutoSize = true;
            lblDateFiled.Location = new System.Drawing.Point(29, 224);
            lblDateFiled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDateFiled.Name = "lblDateFiled";
            lblDateFiled.Size = new System.Drawing.Size(124, 29);
            lblDateFiled.TabIndex = 3;
            lblDateFiled.Text = "Date Filed";
            // 
            // lblCCE
            // 
            lblCCE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lblCCE.AutoSize = true;
            lblCCE.Location = new System.Drawing.Point(980, 43);
            lblCCE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCCE.Name = "lblCCE";
            lblCCE.Size = new System.Drawing.Size(156, 29);
            lblCCE.TabIndex = 5;
            lblCCE.Text = "CCE Number";
            // 
            // txtCCE
            // 
            txtCCE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            txtCCE.Location = new System.Drawing.Point(986, 80);
            txtCCE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtCCE.Name = "txtCCE";
            txtCCE.Size = new System.Drawing.Size(404, 35);
            txtCCE.TabIndex = 4;
            // 
            // lblType
            // 
            lblType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lblType.AutoSize = true;
            lblType.Location = new System.Drawing.Point(503, 43);
            lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new System.Drawing.Size(181, 29);
            lblType.TabIndex = 5;
            lblType.Text = "Type of Petition";
            // 
            // txtType
            // 
            txtType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            txtType.Location = new System.Drawing.Point(509, 80);
            txtType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtType.Name = "txtType";
            txtType.Size = new System.Drawing.Size(404, 35);
            txtType.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1475, 786);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Petition Log";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            tabControl1.ResumeLayout(false);
            tabView.ResumeLayout(false);
            tabView.PerformLayout();
            tabAdd.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblCCE;
        private System.Windows.Forms.TextBox txtCCE;
        private System.Windows.Forms.DateTimePicker dtpDateFiled;
        private System.Windows.Forms.Label lblDateFiled;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPurge;
        private System.Windows.Forms.Label lblPurge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearch2;
        private System.Windows.Forms.Label lblRefresh;
    }
}

