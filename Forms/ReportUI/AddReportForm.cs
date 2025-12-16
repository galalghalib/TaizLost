using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Windows.Forms;
using TaizlostSmart.Models;
using TaizlostSmart.Services;
using TaizlostSmart.Forms.Home;

namespace TaizlostSmart.Forms.ReportUI
{
    public partial class AddReportForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IReportService _reportService;
        private Users _currentUser;

        private string selectedImagePath;

        public AddReportForm(IReportService reportService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _reportService = reportService;

            SetupEvents();
        }

        // استلام المستخدم القادم من HomeForm
        public void SetUser(Users user)
        {
            _currentUser = user;
        }


        // ================================
        // ربط الأحداث
        // ================================
        private void SetupEvents()
        {
            cmbCategory.SelectedIndexChanged += CmbCategory_SelectedIndexChanged;
            btnSelectImage.Click += BtnSelectImage_Click;
            btnPublish.Click += BtnPublish_Click;

            btnSearch.Click += BtnSearch_Click;
            btnView.Click += BtnView_Click;
            btnHome.Click += BtnHome_Click;
        }


        // ===================================
        //  عند تغيير الفئة
        // ===========================
        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCategoryCustom.Visible = (cmbCategory.SelectedItem?.ToString() == "Other" ||
                                         cmbCategory.SelectedItem?.ToString() == "أخرى");
        }


        // ===================================
        //  زر اختيار الصورة
        // ===================================
        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = dialog.FileName;
                picImage.Image = Image.FromFile(selectedImagePath);
            }
        }


        // ===========================
        //  زر نشر البلاغ
        // =========================
        private void BtnPublish_Click(object sender, EventArgs e)
        {
            
            

            
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter report title.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Please select report type.", "Warning");
                return;
            }

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Warning");
                return;
            }

            // الفئة
            string category = cmbCategory.SelectedItem.ToString();

            if (category == "Other" || category == "أخرى")
            {
                category = txtCategoryCustom.Text;
                if (string.IsNullOrWhiteSpace(category))
                {
                    MessageBox.Show("Please enter custom category.", "Warning");
                    return;
                }
            }

          
            Reports report = new Reports
            {
                Title = txtTitle.Text,
                Type = cmbType.SelectedItem.ToString(),
                Category = category,
                Description = txtDescription.Text,
                Location = txtLocation.Text,
                Date = dtDate.Value,
                ImagePath = selectedImagePath,
                Phone = txtPhone.Text,
                UserId = _currentUser.Id
            };


            _reportService.AddReport(report);

            MessageBox.Show("Your report has been published successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
        }


        // ===================================
        //  أزرار التنقل
        // =======================
        // 
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<SearchReportsForm>();
            this.Hide();
            frm.Show();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
          
            var frm = _serviceProvider.GetRequiredService<ViewReportForm>();
            frm.ShowDialog();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            var home = _serviceProvider.GetRequiredService<HomeForm>();
            home.SetUser(_currentUser);
            this.Hide();
            home.Show();
        }


        // ===================================
        //  تنظيف الحقول بعد الإرسال
        // ===================================
        private void ClearForm()
        {
            txtTitle.Clear();
            cmbType.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;

            txtCategoryCustom.Visible = false;
            txtCategoryCustom.Clear();

            txtDescription.Clear();
            txtLocation.Clear();
            txtPhone.Clear();
            picImage.Image = null;

            selectedImagePath = null;
        }

        private void box_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
