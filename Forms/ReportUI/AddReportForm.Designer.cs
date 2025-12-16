namespace TaizlostSmart.Forms.ReportUI
{
    partial class AddReportForm
    {
        private System.ComponentModel.IContainer components = null;

        // عناصر الواجهة
        private Panel topBar;
        private Label lblTop;
        private Panel sideMenu;
        private PictureBox logo;
        private Button btnSearch;
        private Button btnView;
        private Button btnHome;

        private Panel box;

        private ComboBox cmbType;
        private ComboBox cmbCategory;
        private TextBox txtDescription;
        private TextBox txtLocation;
        private DateTimePicker dtDate;
        private TextBox txtPhone;
        private PictureBox picImage;
        private TextBox txtCategoryCustom;
        private TextBox txtTitle;

        private Label lblTitleReport;
        private Label lblType;
        private Label lblCat;
        private Label lblDesc;
        private Label lblLoc;
        private Label lblDate;
        private Label lblPhone;

        private Button btnSelectImage;
        private Button btnPublish;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReportForm));
            topBar = new Panel();
            lblTop = new Label();
            sideMenu = new Panel();
            logo = new PictureBox();
            btnSearch = new Button();
            btnView = new Button();
            btnHome = new Button();
            box = new Panel();
            lblTitleReport = new Label();
            txtTitle = new TextBox();
            lblType = new Label();
            cmbType = new ComboBox();
            lblCat = new Label();
            cmbCategory = new ComboBox();
            txtCategoryCustom = new TextBox();
            lblDesc = new Label();
            txtDescription = new TextBox();
            lblLoc = new Label();
            txtLocation = new TextBox();
            lblDate = new Label();
            dtDate = new DateTimePicker();
            btnSelectImage = new Button();
            picImage = new PictureBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnPublish = new Button();
            topBar.SuspendLayout();
            sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.BackColor = Color.SkyBlue;
            topBar.Controls.Add(lblTop);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(220, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(1092, 70);
            topBar.TabIndex = 0;
            // 
            // lblTop
            // 
            lblTop.AutoSize = true;
            lblTop.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTop.ForeColor = Color.Black;
            lblTop.Location = new Point(380, 12);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(301, 48);
            lblTop.TabIndex = 0;
            lblTop.Text = "Add Your Report";
            // 
            // sideMenu
            // 
            sideMenu.BackColor = Color.SkyBlue;
            sideMenu.BorderStyle = BorderStyle.FixedSingle;
            sideMenu.Controls.Add(logo);
            sideMenu.Controls.Add(btnSearch);
            sideMenu.Controls.Add(btnView);
            sideMenu.Controls.Add(btnHome);
            sideMenu.Dock = DockStyle.Left;
            sideMenu.Location = new Point(0, 0);
            sideMenu.Name = "sideMenu";
            sideMenu.Size = new Size(220, 777);
            sideMenu.TabIndex = 1;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(33, 11);
            logo.Name = "logo";
            logo.Size = new Size(129, 141);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(11, 210);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(194, 50);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search Reports";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FromArgb(224, 224, 224);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnView.ForeColor = Color.Black;
            btnView.Location = new Point(11, 312);
            btnView.Name = "btnView";
            btnView.Size = new Size(194, 50);
            btnView.TabIndex = 2;
            btnView.Text = "View Reports";
            btnView.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(224, 224, 224);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHome.ForeColor = Color.Black;
            btnHome.Location = new Point(11, 411);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(194, 50);
            btnHome.TabIndex = 3;
            btnHome.Text = "Back to Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // box
            // 
            box.BackColor = Color.Cornsilk;
            box.BorderStyle = BorderStyle.FixedSingle;
            box.Controls.Add(lblTitleReport);
            box.Controls.Add(txtTitle);
            box.Controls.Add(lblType);
            box.Controls.Add(cmbType);
            box.Controls.Add(lblCat);
            box.Controls.Add(cmbCategory);
            box.Controls.Add(txtCategoryCustom);
            box.Controls.Add(lblDesc);
            box.Controls.Add(txtDescription);
            box.Controls.Add(lblLoc);
            box.Controls.Add(txtLocation);
            box.Controls.Add(lblDate);
            box.Controls.Add(dtDate);
            box.Controls.Add(btnSelectImage);
            box.Controls.Add(picImage);
            box.Controls.Add(lblPhone);
            box.Controls.Add(txtPhone);
            box.Controls.Add(btnPublish);
            box.Dock = DockStyle.Fill;
            box.Location = new Point(0, 0);
            box.Name = "box";
            box.Size = new Size(1312, 777);
            box.TabIndex = 2;
            box.Paint += box_Paint;
            // 
            // lblTitleReport
            // 
            lblTitleReport.Anchor = AnchorStyles.None;
            lblTitleReport.Font = new Font("Sitka Small", 11F);
            lblTitleReport.ForeColor = Color.FromArgb(68, 68, 68);
            lblTitleReport.Location = new Point(726, 88);
            lblTitleReport.Name = "lblTitleReport";
            lblTitleReport.Size = new Size(150, 35);
            lblTitleReport.TabIndex = 0;
            lblTitleReport.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.None;
            txtTitle.Font = new Font("Segoe UI", 11F);
            txtTitle.Location = new Point(726, 126);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(321, 37);
            txtTitle.TabIndex = 1;
            // 
            // lblType
            // 
            lblType.Anchor = AnchorStyles.None;
            lblType.Font = new Font("Sitka Small", 11F);
            lblType.ForeColor = Color.FromArgb(68, 68, 68);
            lblType.Location = new Point(229, 95);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 28);
            lblType.TabIndex = 2;
            lblType.Text = "Report Type (Lost / Found)";
            // 
            // cmbType
            // 
            cmbType.Anchor = AnchorStyles.None;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Font = new Font("Segoe UI", 11F);
            cmbType.Items.AddRange(new object[] { "مفقود", "موجود" });
            cmbType.Location = new Point(235, 126);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(378, 38);
            cmbType.TabIndex = 3;
            // 
            // lblCat
            // 
            lblCat.Anchor = AnchorStyles.None;
            lblCat.Font = new Font("Sitka Small", 11F);
            lblCat.ForeColor = Color.FromArgb(68, 68, 68);
            lblCat.Location = new Point(229, 166);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(100, 35);
            lblCat.TabIndex = 4;
            lblCat.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.None;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 11F);
            cmbCategory.Items.AddRange(new object[] { "بطاقة", "ذهب", "جوال", "حقيبه", "فلوس", "محفضة", "أخرى" });
            cmbCategory.Location = new Point(235, 204);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 38);
            cmbCategory.TabIndex = 5;
            // 
            // txtCategoryCustom
            // 
            txtCategoryCustom.Anchor = AnchorStyles.None;
            txtCategoryCustom.Location = new Point(726, 210);
            txtCategoryCustom.Name = "txtCategoryCustom";
            txtCategoryCustom.Size = new Size(304, 31);
            txtCategoryCustom.TabIndex = 6;
            // 
            // lblDesc
            // 
            lblDesc.Anchor = AnchorStyles.None;
            lblDesc.Font = new Font("Sitka Small", 11F);
            lblDesc.Location = new Point(229, 244);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(100, 38);
            lblDesc.TabIndex = 7;
            lblDesc.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.None;
            txtDescription.Font = new Font("Segoe UI", 11F);
            txtDescription.Location = new Point(231, 282);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(700, 80);
            txtDescription.TabIndex = 8;
            // 
            // lblLoc
            // 
            lblLoc.Anchor = AnchorStyles.None;
            lblLoc.Font = new Font("Sitka Small", 11F);
            lblLoc.Location = new Point(229, 365);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new Size(100, 33);
            lblLoc.TabIndex = 9;
            lblLoc.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.Anchor = AnchorStyles.None;
            txtLocation.Font = new Font("Segoe UI", 11F);
            txtLocation.Location = new Point(229, 401);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(378, 37);
            txtLocation.TabIndex = 10;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.None;
            lblDate.Font = new Font("Sitka Small", 11F);
            lblDate.Location = new Point(704, 364);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 34);
            lblDate.TabIndex = 11;
            lblDate.Text = "Date & Time";
            // 
            // dtDate
            // 
            dtDate.Anchor = AnchorStyles.None;
            dtDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtDate.Font = new Font("Segoe UI", 11F);
            dtDate.Format = DateTimePickerFormat.Custom;
            dtDate.Location = new Point(704, 401);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(300, 37);
            dtDate.TabIndex = 12;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Anchor = AnchorStyles.None;
            btnSelectImage.BackColor = Color.FromArgb(74, 144, 226);
            btnSelectImage.Font = new Font("Sitka Small", 9F, FontStyle.Bold);
            btnSelectImage.ForeColor = Color.White;
            btnSelectImage.Location = new Point(229, 444);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(150, 35);
            btnSelectImage.TabIndex = 13;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.UseVisualStyleBackColor = false;
            // 
            // picImage
            // 
            picImage.Anchor = AnchorStyles.None;
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(390, 444);
            picImage.Name = "picImage";
            picImage.Size = new Size(217, 120);
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.TabIndex = 14;
            picImage.TabStop = false;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.None;
            lblPhone.Font = new Font("Sitka Small", 11F);
            lblPhone.Location = new Point(704, 449);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 30);
            lblPhone.TabIndex = 15;
            lblPhone.Text = "Contact Phone";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.Location = new Point(704, 486);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 37);
            txtPhone.TabIndex = 16;
            // 
            // btnPublish
            // 
            btnPublish.Anchor = AnchorStyles.None;
            btnPublish.BackColor = Color.FromArgb(74, 144, 226);
            btnPublish.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            btnPublish.ForeColor = Color.White;
            btnPublish.Location = new Point(567, 610);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(250, 45);
            btnPublish.TabIndex = 17;
            btnPublish.Text = "Publish Report";
            btnPublish.UseVisualStyleBackColor = false;
            // 
            // AddReportForm
            // 
            ClientSize = new Size(1312, 777);
            Controls.Add(topBar);
            Controls.Add(sideMenu);
            Controls.Add(box);
            Name = "AddReportForm";
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            box.ResumeLayout(false);
            box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
        }
    }
}
