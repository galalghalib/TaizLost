namespace TaizlostSmart.Forms.ReportUI
{
    partial class SearchReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel topBar;
        private Panel sideBar;
        private Panel searchPanel;
        private DataGridView dgvResults;
        private PictureBox logo;

        private Label lblCategory;
        private ComboBox cmbCategory;

        private Label lblDescription;
        private TextBox txtDescription;

        private Button btnSearch;

        private Button btnAdd;
        private Button btnView;
        private Button btnHome;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchReportsForm));
            sideBar = new Panel();
            logo = new PictureBox();
            btnAdd = new Button();
            btnView = new Button();
            btnHome = new Button();
            topBar = new Panel();
            lblTitle = new Label();
            searchPanel = new Panel();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnSearch = new Button();
            dgvResults = new DataGridView();
            sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            topBar.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.SkyBlue;
            sideBar.Controls.Add(logo);
            sideBar.Controls.Add(btnAdd);
            sideBar.Controls.Add(btnView);
            sideBar.Controls.Add(btnHome);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(220, 777);
            sideBar.TabIndex = 3;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 10);
            logo.Name = "logo";
            logo.Size = new Size(178, 150);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(224, 224, 224);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.Location = new Point(12, 233);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(194, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Report";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(224, 224, 224);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnView.Location = new Point(12, 327);
            btnView.Name = "btnView";
            btnView.Size = new Size(194, 50);
            btnView.TabIndex = 2;
            btnView.Text = "View Report";
            btnView.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(224, 224, 224);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHome.Location = new Point(12, 419);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(194, 50);
            btnHome.TabIndex = 3;
            btnHome.Text = "Back up";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // topBar
            // 
            topBar.BackColor = Color.SkyBlue;
            topBar.Controls.Add(lblTitle);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(220, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(1092, 70);
            topBar.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(323, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(349, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Search Of Your Lost";
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.WhiteSmoke;
            searchPanel.Controls.Add(lblCategory);
            searchPanel.Controls.Add(cmbCategory);
            searchPanel.Controls.Add(lblDescription);
            searchPanel.Controls.Add(txtDescription);
            searchPanel.Controls.Add(btnSearch);
            searchPanel.Dock = DockStyle.Top;
            searchPanel.Location = new Point(220, 70);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(1092, 100);
            searchPanel.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCategory.Location = new Point(873, 25);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 39);
            lblCategory.TabIndex = 0;
            lblCategory.Text = ":الفئة ";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F);
            cmbCategory.Location = new Point(620, 25);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(220, 40);
            cmbCategory.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDescription.Location = new Point(500, 25);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 40);
            lblDescription.TabIndex = 2;
            lblDescription.Text = ":الوصف";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F);
            txtDescription.Location = new Point(250, 25);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(240, 39);
            txtDescription.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 120, 215);
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(80, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 40);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvResults
            // 
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.BackgroundColor = Color.Cornsilk;
            dgvResults.ColumnHeadersHeight = 34;
            dgvResults.Dock = DockStyle.Fill;
            dgvResults.Location = new Point(220, 170);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 62;
            dgvResults.RowTemplate.Height = 150;
            dgvResults.Size = new Size(1092, 607);
            dgvResults.TabIndex = 0;
            // 
            // SearchReportsForm
            // 
            ClientSize = new Size(1312, 777);
            Controls.Add(dgvResults);
            Controls.Add(searchPanel);
            Controls.Add(topBar);
            Controls.Add(sideBar);
            Name = "SearchReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Reports";
            sideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }
        private Label lblTitle;
    }
}
