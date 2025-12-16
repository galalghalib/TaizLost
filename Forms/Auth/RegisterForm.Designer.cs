namespace TaizlostSmart.Forms.Auth
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfPassword;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfPassword;

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel linkLogin;


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
            panelMain = new Panel();
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfPassword = new Label();
            txtConfPassword = new TextBox();
            btnRegister = new Button();
            linkLogin = new LinkLabel();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.Cornsilk;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(lblName);
            panelMain.Controls.Add(txtName);
            panelMain.Controls.Add(lblEmail);
            panelMain.Controls.Add(txtEmail);
            panelMain.Controls.Add(lblPhone);
            panelMain.Controls.Add(txtPhone);
            panelMain.Controls.Add(lblPassword);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(lblConfPassword);
            panelMain.Controls.Add(txtConfPassword);
            panelMain.Controls.Add(btnRegister);
            panelMain.Controls.Add(linkLogin);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1312, 777);
            panelMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.SkyBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1310, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Account";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.Font = new Font("Sitka Small", 11F);
            lblName.Location = new Point(522, 143);
            lblName.Name = "lblName";
            lblName.Size = new Size(153, 34);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.BackColor = Color.WhiteSmoke;
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(522, 180);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 37);
            txtName.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.Font = new Font("Sitka Small", 11F);
            lblEmail.Location = new Point(522, 220);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(88, 30);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(522, 253);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 37);
            txtEmail.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.None;
            lblPhone.Font = new Font("Sitka Small", 11F);
            lblPhone.Location = new Point(522, 293);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(88, 32);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.BackColor = Color.WhiteSmoke;
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.Location = new Point(522, 326);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(260, 37);
            txtPhone.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.Font = new Font("Sitka Small", 11F);
            lblPassword.Location = new Point(522, 366);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(153, 30);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(522, 399);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(260, 37);
            txtPassword.TabIndex = 8;
            // 
            // lblConfPassword
            // 
            lblConfPassword.Anchor = AnchorStyles.None;
            lblConfPassword.Font = new Font("Sitka Small", 11F);
            lblConfPassword.Location = new Point(522, 438);
            lblConfPassword.Name = "lblConfPassword";
            lblConfPassword.Size = new Size(220, 30);
            lblConfPassword.TabIndex = 20;
            lblConfPassword.Text = "Confirm Password";
            // 
            // txtConfPassword
            // 
            txtConfPassword.Anchor = AnchorStyles.None;
            txtConfPassword.BackColor = Color.WhiteSmoke;
            txtConfPassword.Font = new Font("Segoe UI", 11F);
            txtConfPassword.Location = new Point(522, 471);
            txtConfPassword.Name = "txtConfPassword";
            txtConfPassword.PasswordChar = '*';
            txtConfPassword.Size = new Size(260, 37);
            txtConfPassword.TabIndex = 21;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.BackColor = Color.SkyBlue;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(522, 554);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(260, 45);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Create Account";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // linkLogin
            // 
            linkLogin.Anchor = AnchorStyles.None;
            linkLogin.AutoSize = true;
            linkLogin.Font = new Font("Sitka Small", 10F);
            linkLogin.LinkColor = Color.FromArgb(53, 122, 189);
            linkLogin.Location = new Point(501, 628);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(333, 29);
            linkLogin.TabIndex = 10;
            linkLogin.TabStop = true;
            linkLogin.Text = "Already have an account? Login";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 241);
            ClientSize = new Size(1312, 777);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Account";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }
    }
}
