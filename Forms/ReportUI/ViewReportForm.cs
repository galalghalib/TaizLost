using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TaizlostSmart.Forms.Home;
using TaizlostSmart.Models;
using TaizlostSmart.Services;

namespace TaizlostSmart.Forms.ReportUI
{
    public partial class ViewReportForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IReportService _reportService;

        public ViewReportForm(IServiceProvider serviceProvider, IReportService reportService)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;
            _reportService = reportService;

            // تحميل البيانات عند فتح الواجهة
            this.Load += ViewReportForm_Load;

            // ربط الروابط
            btnAddReport.Click += BtnAddReport_Click;
            btnSearchReport.Click += BtnSearchReport_Click;
            btnHome.Click += BtnHome_Click;
        }

    
        //   تحميل البلاغات داخل الجدول
 
        private void ViewReportForm_Load(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void LoadReports()
        {
            dgvReports.Columns.Clear();
            dgvReports.Rows.Clear();

            var reports = _reportService.GetAll()?.ToList();

            if (reports == null)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البلاغات!", "خطأ");
                return;
            }

            // ----------- إنشاء الأعمدة -------------

           
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "الصورة";
            imgCol.Width = 200;
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvReports.Columns.Add(imgCol);

            dgvReports.Columns.Add("Type", "نوع البلاغ");
            dgvReports.Columns.Add("Category", "الفئة");
            dgvReports.Columns.Add("Title", "عنوان البلاغ");
            dgvReports.Columns.Add("Description", "الوصف");
            dgvReports.Columns.Add("Location", "الموقع");
            dgvReports.Columns.Add("Phone", "رقم التواصل");
            dgvReports.Columns.Add("Date", "التاريخ");

            // ----------- تعبئة البيانات -------------

            foreach (var r in reports)
            {
                Image img = null;

                if (!string.IsNullOrEmpty(r.ImagePath) && File.Exists(r.ImagePath))
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

                dgvReports.Rows.Add(
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

            dgvReports.RowTemplate.Height = 180;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ======================================================
        //   الأزرار الجانبية
        // ======================================================

        private void BtnAddReport_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<AddReportForm>();

            this.Hide();
            frm.Show();
        }

        private void BtnSearchReport_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<SearchReportsForm>();
            
            frm.ShowDialog();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<HomeForm>();
            
            this.Hide();
            frm.Show();
        }
    }
}
