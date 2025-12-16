using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TaizlostSmart.Models;
using TaizlostSmart.Services;

namespace TaizlostSmart.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;

        public RegisterForm(IUserService userService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userService = userService;
            _serviceProvider = serviceProvider;

            btnRegister.Click += BtnRegister_Click;
            linkLogin.Click += LinkLogin_Click;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // التحقق من البيانات
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfPassword.Text))
            {
                MessageBox.Show("Please fill all fields!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // التحقق من تطابق كلمة المرور
            if (txtPassword.Text != txtConfPassword.Text)
            {
                MessageBox.Show(" Passwords do NOT match!\nPlease re-enter the password.",
                    "Password Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            var user = new Users
            {
                FullName = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };

            var result = _userService.Register(user, txtPassword.Text);

            if (result == null)
            {
                MessageBox.Show("Email already exists!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Account created successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            var login = _serviceProvider.GetRequiredService<LoginForm>();
            login.Show();
        }

        private void LinkLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {

        }
    }
}
