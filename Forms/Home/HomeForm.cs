using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Windows.Forms;
using TaizlostSmart.Forms.Auth;
using TaizlostSmart.Forms.ReportUI;
using TaizlostSmart.Models;
using TaizlostSmart.Services;

namespace TaizlostSmart.Forms.Home
{
    public partial class HomeForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Users _currentUser;
        private readonly IUserService _userService;
        private readonly IReportService _reportService;


        public HomeForm(IServiceProvider serviceProvider, IUserService userService,
                 IReportService reportService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _userService = userService;
            _reportService = reportService;

            LoadUI();
        }

        private void LoadUI()
        { 

            int usersCount = _userService.GetUsersCount();
            int reportsCount = _reportService.GetReportsCount();

            lblUsersCount.Text = usersCount.ToString();
            lblReportsCount.Text = reportsCount.ToString();


            btnAdd.Click += (s, e) =>
            {
                var frm = _serviceProvider.GetRequiredService<AddReportForm>();
                frm.SetUser(_currentUser);
                frm.ShowDialog();
            };

            btnSearch.Click += (s, e) =>
            {
                var frm = _serviceProvider.GetRequiredService<SearchReportsForm>();
                frm.ShowDialog();
            };

            btnView.Click += (s, e) =>
            {
                var frm = _serviceProvider.GetRequiredService<ViewReportForm>();
                frm.ShowDialog();
            };

            btnLogout.Click += (s, e) =>
            {
                this.Hide();
                var login = _serviceProvider.GetRequiredService<LoginForm>();
                login.Show();
            };
        }

        public void SetUser(Users user)
        {
            _currentUser = user;
            lblWelcome1.Text = $"Welcome, {user.FullName}";
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void lblReportsTitle_Click(object sender, EventArgs e)
        {

        }

        private void bigTitle_Click(object sender, EventArgs e)
        {

        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void topBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcome1_Click(object sender, EventArgs e)
        {

        }

        private void appLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
