using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TaizlostSmart.Services;
using TaizlostSmart.Forms.Home;

namespace TaizlostSmart.Forms.Auth
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;

        public LoginForm(IUserService userService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userService = userService;
            _serviceProvider = serviceProvider;

            
            btnLogin.Click += BtnLogin_Click;
            linkRegister.Click += LinkRegister_Click;
        }

        // ================================
        //  زر تسجيل الدخول
        // ================================
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var user = _userService.Login(txtEmail.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid email or password!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // فتح الواجهة الرئيسية
            var home = _serviceProvider.GetRequiredService<HomeForm>();
            home.SetUser(user);

            this.Hide();
            home.Show();
        }

        // =======================
        // رابط إنشاء حساب
        // =====================
        private void LinkRegister_Click(object sender, EventArgs e)
        {
            var registerForm = _serviceProvider.GetRequiredService<RegisterForm>();
            registerForm.ShowDialog();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
