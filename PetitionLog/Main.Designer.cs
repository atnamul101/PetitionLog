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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabView = new System.Windows.Forms.TabPage();
            this.lblPurge = new System.Windows.Forms.Label();
            this.btnPurge = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.dtpDateFiled = new System.Windows.Forms.DateTimePicker();
            this.lblCCE = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtCCE = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblDateFiled = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(0, 78);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(1253, 558);
            this.gridView.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(590, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 63);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "✔";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabView);
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 681);
            this.tabControl1.TabIndex = 2;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.lblPurge);
            this.tabView.Controls.Add(this.btnPurge);
            this.tabView.Controls.Add(this.btnRefresh);
            this.tabView.Controls.Add(this.btnSearch);
            this.tabView.Controls.Add(this.cmbFilter);
            this.tabView.Controls.Add(this.lblSearch);
            this.tabView.Controls.Add(this.txtSearch);
            this.tabView.Controls.Add(this.gridView);
            this.tabView.Location = new System.Drawing.Point(4, 38);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(1256, 639);
            this.tabView.TabIndex = 0;
            this.tabView.Text = "View";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // lblPurge
            // 
            this.lblPurge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPurge.AutoSize = true;
            this.lblPurge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurge.Location = new System.Drawing.Point(1197, 55);
            this.lblPurge.Name = "lblPurge";
            this.lblPurge.Size = new System.Drawing.Size(51, 20);
            this.lblPurge.TabIndex = 6;
            this.lblPurge.Text = "Purge";
            // 
            // btnPurge
            // 
            this.btnPurge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPurge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPurge.BackgroundImage")));
            this.btnPurge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPurge.Location = new System.Drawing.Point(1198, 6);
            this.btnPurge.Name = "btnPurge";
            this.btnPurge.Size = new System.Drawing.Size(50, 47);
            this.btnPurge.TabIndex = 5;
            this.btnPurge.UseVisualStyleBackColor = true;
            this.btnPurge.Click += new System.EventHandler(this.btnPurge_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(538, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 47);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(482, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 47);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "All",
            "Name",
            "Type",
            "CCE",
            "Remarks"});
            this.cmbFilter.Location = new System.Drawing.Point(281, 35);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(183, 37);
            this.cmbFilter.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 5);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 29);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 35);
            this.txtSearch.TabIndex = 1;
            // 
            // tabAdd
            // 
            this.tabAdd.AutoScrollMargin = new System.Drawing.Size(0, 500);
            this.tabAdd.Controls.Add(this.panel1);
            this.tabAdd.Location = new System.Drawing.Point(4, 38);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(1256, 639);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtRemarks.Location = new System.Drawing.Point(583, 226);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(635, 35);
            this.txtRemarks.TabIndex = 7;
            // 
            // dtpDateFiled
            // 
            this.dtpDateFiled.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtpDateFiled.Location = new System.Drawing.Point(30, 226);
            this.dtpDateFiled.Name = "dtpDateFiled";
            this.dtpDateFiled.Size = new System.Drawing.Size(430, 35);
            this.dtpDateFiled.TabIndex = 6;
            // 
            // lblCCE
            // 
            this.lblCCE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCCE.AutoSize = true;
            this.lblCCE.Location = new System.Drawing.Point(840, 37);
            this.lblCCE.Name = "lblCCE";
            this.lblCCE.Size = new System.Drawing.Size(156, 29);
            this.lblCCE.TabIndex = 5;
            this.lblCCE.Text = "CCE Number";
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(431, 37);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(181, 29);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type of Petition";
            // 
            // txtCCE
            // 
            this.txtCCE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCCE.Location = new System.Drawing.Point(845, 69);
            this.txtCCE.Name = "txtCCE";
            this.txtCCE.Size = new System.Drawing.Size(347, 35);
            this.txtCCE.TabIndex = 4;
            // 
            // txtType
            // 
            this.txtType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtType.Location = new System.Drawing.Point(436, 69);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(347, 35);
            this.txtType.TabIndex = 4;
            // 
            // lblRemarks
            // 
            this.lblRemarks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(578, 194);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(109, 29);
            this.lblRemarks.TabIndex = 3;
            this.lblRemarks.Text = "Remarks";
            // 
            // lblDateFiled
            // 
            this.lblDateFiled.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDateFiled.AutoSize = true;
            this.lblDateFiled.Location = new System.Drawing.Point(25, 194);
            this.lblDateFiled.Name = "lblDateFiled";
            this.lblDateFiled.Size = new System.Drawing.Size(124, 29);
            this.lblDateFiled.TabIndex = 3;
            this.lblDateFiled.Text = "Date Filed";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(213, 29);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name of Petitioner";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtName.Location = new System.Drawing.Point(30, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(347, 35);
            this.txtName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.lblRemarks);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.dtpDateFiled);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblDateFiled);
            this.panel1.Controls.Add(this.lblCCE);
            this.panel1.Controls.Add(this.txtCCE);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 403);
            this.panel1.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Petition Log";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabView.PerformLayout();
            this.tabAdd.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

