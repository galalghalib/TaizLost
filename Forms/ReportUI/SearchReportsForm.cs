using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TaizlostSmart.Forms.Home;
using TaizlostSmart.Services;
using TaizlostSmart.Models;

namespace TaizlostSmart.Forms.ReportUI
{
    public partial class SearchReportsForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IReportService _reportService;

        public SearchReportsForm(IServiceProvider serviceProvider, IReportService reportService)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;
            _reportService = reportService;

            // تحميل الصفحة
            Load += SearchReportsForm_Load;

            // البحث
            btnSearch.Click += BtnSearch_Click;

            // أزرار القائمة
            btnAdd.Click += BtnAdd_Click;
            btnHome.Click += BtnHome_Click;
            btnView.Click += BtnView_Click;
        }

        // =====================================================
        // تحميل الفئات عند فتح الصفحة
        // ===================================
        private void SearchReportsForm_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("بطاقة");
            cmbCategory.Items.Add("جوال");
            cmbCategory.Items.Add("ذهب");
            cmbCategory.Items.Add("فلوس");
            cmbCategory.Items.Add("محفظة");
            cmbCategory.Items.Add("حقيبة");
            cmbCategory.Items.Add("أخرى");

            // إفراغ الجدول عند الفتح
            dgvResults.Columns.Clear();
            dgvResults.Rows.Clear();

            dgvResults.AutoGenerateColumns = false;
        }

        // =========================================
        // زر البحث
        // ==============================
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string category = cmbCategory.Text.Trim();
            string description = txtDescription.Text.Trim();

            var results = _reportService.GetAll()
                .Where(r =>
                    (string.IsNullOrEmpty(category) || r.Category.Contains(category)) &&
                    (string.IsNullOrEmpty(description) || r.Description.Contains(description))
                  )
                .ToList();
            if (results.Count == 0)
            {
                MessageBox.Show(
                    "لا يوجد بلاغ مشابه لهذه البيانات، جرب وصف آخر أو اختر فئة مختلفة.",
                    "لا توجد نتائج",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            DisplayResults(results);
        }

        // =============================
        // عرض النتائج في الجدول
        // ===============================
        private void DisplayResults(System.Collections.Generic.List<Reports> reports)
        {
            dgvResults.Columns.Clear();
            dgvResults.Rows.Clear();

            // ------------------
            // عمود الصورة
            // ------------------
            var imgCol = new DataGridViewImageColumn
            {
                HeaderText = "الصورة",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 120
            };
            dgvResults.Columns.Add(imgCol);

            dgvResults.Columns.Add("Type", "نوع البلاغ");
            dgvResults.Columns.Add("Category", "الفئة");
            dgvResults.Columns.Add("Title", "العنوان");
            dgvResults.Columns.Add("Description", "الوصف");
            dgvResults.Columns.Add("Location", "الموقع");
            dgvResults.Columns.Add("Phone", "رقم التواصل");
            dgvResults.Columns.Add("Date", "التاريخ");

            foreach (var r in reports)
            {
                Image img = null;

                if (!string.IsNullOrEmpty(r.ImagePath) && System.IO.File.Exists(r.ImagePath))
                {
                    try
                    {
                        img = Image.FromFile(r.ImagePath);
                    }
                    catch
                    {
                        img = null;
                    }
                }

                dgvResults.Rows.Add(
                    img,
                    r.Type,
                    r.Category,
                    r.Title,
                    r.Description,
                    r.Location,
                    r.Phone,
                    r.Date.ToString("dd/MM/yyyy HH:mm")
                );
            }

            dgvResults.RowTemplate.Height = 130;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // =====================================================
        // أزرار القائمة الجانبية
        // =====================================================

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<AddReportForm>();
            this.Hide();
            frm.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<HomeForm>();
        
            this.Hide();
            frm.Show();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<ViewReportForm>();

            frm.ShowDialog();
        }

        
        
    }
}
