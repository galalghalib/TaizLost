namespace TaizlostSmart.Forms.Home
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel mainContent;
        private System.Windows.Forms.Label bigTitle;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Panel cardUsers;
        private System.Windows.Forms.Label lblUsersTitle;
        private System.Windows.Forms.Label lblUsersCount;

        private System.Windows.Forms.Panel cardReports;
        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.Label lblReportsCount;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            topBar = new Panel();
            lblWelcome1 = new Label();
            sideMenu = new Panel();
            appLogo = new PictureBox();
            btnAdd = new Button();
            btnSearch = new Button();
            btnView = new Button();
            btnLogout = new Button();
            mainContent = new Panel();
            cardUsers = new Panel();
            lblUsersTitle = new Label();
            lblUsersCount = new Label();
            cardReports = new Panel();
            lblReportsTitle = new Label();
            lblReportsCount = new Label();
            bigTitle = new Label();
            description = new Label();
            pageSetupDialog1 = new PageSetupDialog();
            topBar.SuspendLayout();
            sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appLogo).BeginInit();
            mainContent.SuspendLayout();
            cardUsers.SuspendLayout();
            cardReports.SuspendLayout();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.BackColor = Color.SkyBlue;
            topBar.Controls.Add(lblWelcome1);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(1312, 70);
            topBar.TabIndex = 2;
            topBar.Paint += topBar_Paint;
            // 
            // lblWelcome1
            // 
            lblWelcome1.AutoSize = true;
            lblWelcome1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblWelcome1.Location = new Point(647, 18);
            lblWelcome1.Name = "lblWelcome1";
            lblWelcome1.Size = new Size(175, 48);
            lblWelcome1.TabIndex = 0;
            lblWelcome1.Text = "Welcome";
            lblWelcome1.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcome1.Click += lblWelcome1_Click;
            // 
            // sideMenu
            // 
            sideMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sideMenu.BackColor = Color.SkyBlue;
            sideMenu.Controls.Add(appLogo);
            sideMenu.Controls.Add(btnAdd);
            sideMenu.Controls.Add(btnSearch);
            sideMenu.Controls.Add(btnView);
            sideMenu.Controls.Add(btnLogout);
            sideMenu.Location = new Point(0, -6);
            sideMenu.Name = "sideMenu";
            sideMenu.Size = new Size(220, 777);
            sideMenu.TabIndex = 1;
            // 
            // appLogo
            // 
            appLogo.Image = (Image)resources.GetObject("appLogo.Image");
            appLogo.Location = new Point(27, 18);
            appLogo.Name = "appLogo";
            appLogo.Size = new Size(166, 135);
            appLogo.SizeMode = PictureBoxSizeMode.Zoom;
            appLogo.TabIndex = 0;
            appLogo.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(224, 224, 224);
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.Location = new Point(12, 213);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(194, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Report";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearch.Location = new Point(12, 310);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(194, 50);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search Reports";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(224, 224, 224);
            btnView.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnView.Location = new Point(12, 410);
            btnView.Name = "btnView";
            btnView.Size = new Size(194, 50);
            btnView.TabIndex = 3;
            btnView.Text = "View Reports";
            btnView.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Left;
            btnLogout.BackColor = Color.Red;
            btnLogout.Location = new Point(-6, 602);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(248, 50);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // mainContent
            // 
            mainContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainContent.BackColor = Color.Cornsilk;
            mainContent.Controls.Add(cardUsers);
            mainContent.Controls.Add(cardReports);
            mainContent.Controls.Add(bigTitle);
            mainContent.Controls.Add(description);
            mainContent.Location = new Point(212, 70);
            mainContent.Name = "mainContent";
            mainContent.Size = new Size(1088, 818);
            mainContent.TabIndex = 0;
            // 
            // cardUsers
            // 
            cardUsers.Anchor = AnchorStyles.None;
            cardUsers.BackColor = Color.FromArgb(245, 247, 250);
            cardUsers.Controls.Add(lblUsersTitle);
            cardUsers.Controls.Add(lblUsersCount);
            cardUsers.Location = new Point(140, 491);
            cardUsers.Name = "cardUsers";
            cardUsers.Padding = new Padding(10);
            cardUsers.Size = new Size(250, 130);
            cardUsers.TabIndex = 3;
            // 
            // lblUsersTitle
            // 
            lblUsersTitle.AutoSize = true;
            lblUsersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsersTitle.ForeColor = Color.DimGray;
            lblUsersTitle.Location = new Point(33, 3);
            lblUsersTitle.Name = "lblUsersTitle";
            lblUsersTitle.Size = new Size(179, 32);
            lblUsersTitle.TabIndex = 0;
            lblUsersTitle.Text = "عدد المستخدمين";
            // 
            // lblUsersCount
            // 
            lblUsersCount.AutoSize = true;
            lblUsersCount.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblUsersCount.ForeColor = Color.FromArgb(0, 120, 215);
            lblUsersCount.Location = new Point(84, 34);
            lblUsersCount.Name = "lblUsersCount";
            lblUsersCount.Size = new Size(74, 86);
            lblUsersCount.TabIndex = 1;
            lblUsersCount.Text = "0";
            // 
            // cardReports
            // 
            cardReports.Anchor = AnchorStyles.None;
            cardReports.BackColor = Color.FromArgb(245, 247, 250);
            cardReports.Controls.Add(lblReportsTitle);
            cardReports.Controls.Add(lblReportsCount);
            cardReports.Location = new Point(723, 491);
            cardReports.Name = "cardReports";
            cardReports.Padding = new Padding(10);
            cardReports.Size = new Size(250, 130);
            cardReports.TabIndex = 4;
            // 
            // lblReportsTitle
            // 
            lblReportsTitle.AutoSize = true;
            lblReportsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblReportsTitle.ForeColor = Color.DimGray;
            lblReportsTitle.Location = new Point(54, 5);
            lblReportsTitle.Name = "lblReportsTitle";
            lblReportsTitle.Size = new Size(137, 32);
            lblReportsTitle.TabIndex = 0;
            lblReportsTitle.Text = "عدد البلاغات";
            lblReportsTitle.Click += lblReportsTitle_Click;
            // 
            // lblReportsCount
            // 
            lblReportsCount.AutoSize = true;
            lblReportsCount.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblReportsCount.ForeColor = Color.FromArgb(255, 128, 0);
            lblReportsCount.Location = new Point(91, 32);
            lblReportsCount.Name = "lblReportsCount";
            lblReportsCount.Size = new Size(74, 86);
            lblReportsCount.TabIndex = 1;
            lblReportsCount.Text = "0";
            // 
            // bigTitle
            // 
            bigTitle.Anchor = AnchorStyles.None;
            bigTitle.AutoSize = true;
            bigTitle.BackColor = Color.Cornsilk;
            bigTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            bigTitle.ForeColor = Color.FromArgb(74, 144, 226);
            bigTitle.Location = new Point(224, 102);
            bigTitle.Name = "bigTitle";
            bigTitle.Size = new Size(650, 86);
            bigTitle.TabIndex = 0;
            bigTitle.Text = "Welcome in TaizLost";
            bigTitle.Click += bigTitle_Click;
            // 
            // description
            // 
            description.Anchor = AnchorStyles.None;
            description.AutoSize = true;
            description.BackColor = Color.Cornsilk;
            description.Font = new Font("Segoe UI", 14F);
            description.ForeColor = Color.FromArgb(68, 68, 68);
            description.Location = new Point(248, 295);
            description.Name = "description";
            description.Size = new Size(605, 38);
            description.TabIndex = 1;
            description.Text = "TaizLost- Found and Lost Managnament System";
            description.Click += description_Click;
            // 
            // HomeForm
            // 
            ClientSize = new Size(1312, 777);
            Controls.Add(mainContent);
            Controls.Add(sideMenu);
            Controls.Add(topBar);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appLogo).EndInit();
            mainContent.ResumeLayout(false);
            mainContent.PerformLayout();
            cardUsers.ResumeLayout(false);
            cardUsers.PerformLayout();
            cardReports.ResumeLayout(false);
            cardReports.PerformLayout();
            ResumeLayout(false);



        }
        #endregion

        private PictureBox appLogo;
        private PageSetupDialog pageSetupDialog1;
        private Label lblWelcome1;
    }
}
