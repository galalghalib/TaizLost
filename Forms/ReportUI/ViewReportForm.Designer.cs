namespace TaizlostSmart.Forms.ReportUI
{
    partial class ViewReportForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.DataGridView dgvReports;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox logo;

        public System.Windows.Forms.Button btnAddReport;
        public System.Windows.Forms.Button btnSearchReport;
        public System.Windows.Forms.Button btnHome;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReportForm));
            topBar = new Panel();
            lblTitle = new Label();
            sideBar = new Panel();
            logo = new PictureBox();
            btnAddReport = new Button();
            btnSearchReport = new Button();
            btnHome = new Button();
            dgvReports = new DataGridView();
            topBar.SuspendLayout();
            sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
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
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(411, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(292, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "View all Reports";
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.SkyBlue;
            sideBar.Controls.Add(logo);
            sideBar.Controls.Add(btnAddReport);
            sideBar.Controls.Add(btnSearchReport);
            sideBar.Controls.Add(btnHome);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(220, 777);
            sideBar.TabIndex = 1;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(20, 20);
            logo.Name = "logo";
            logo.Size = new Size(180, 140);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // btnAddReport
            // 
            btnAddReport.BackColor = Color.FromArgb(224, 224, 224);
            btnAddReport.FlatStyle = FlatStyle.Flat;
            btnAddReport.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddReport.Location = new Point(12, 221);
            btnAddReport.Name = "btnAddReport";
            btnAddReport.Size = new Size(194, 50);
            btnAddReport.TabIndex = 1;
            btnAddReport.Text = "Add Report";
            btnAddReport.UseVisualStyleBackColor = false;
            // 
            // btnSearchReport
            // 
            btnSearchReport.BackColor = Color.FromArgb(224, 224, 224);
            btnSearchReport.FlatStyle = FlatStyle.Flat;
            btnSearchReport.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearchReport.Location = new Point(12, 318);
            btnSearchReport.Name = "btnSearchReport";
            btnSearchReport.Size = new Size(194, 50);
            btnSearchReport.TabIndex = 2;
            btnSearchReport.Text = "Search ";
            btnSearchReport.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(224, 224, 224);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHome.Location = new Point(12, 414);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(194, 50);
            btnHome.TabIndex = 3;
            btnHome.Text = "Back up";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // dgvReports
            // 
            dgvReports.BackgroundColor = Color.Cornsilk;
            dgvReports.ColumnHeadersHeight = 34;
            dgvReports.Dock = DockStyle.Fill;
            dgvReports.Location = new Point(220, 70);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 62;
            dgvReports.RowTemplate.Height = 180;
            dgvReports.Size = new Size(1092, 707);
            dgvReports.TabIndex = 0;
            // 
            // ViewReportForm
            // 
            ClientSize = new Size(1312, 777);
            Controls.Add(dgvReports);
            Controls.Add(topBar);
            Controls.Add(sideBar);
            Name = "ViewReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Reports";
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            sideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }
    }
}
