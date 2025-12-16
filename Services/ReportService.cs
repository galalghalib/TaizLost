using System.Collections.Generic;
using System.Linq;
using TaizlostSmart.Data;
using TaizlostSmart.Models;

namespace TaizlostSmart.Services
{
    public class ReportService : IReportService
    {
        private readonly AppDbContext _context;

        public ReportService(AppDbContext context)
        {
            _context = context;
        }

        public Reports AddReport(Reports report)
        {
            _context.Reports.Add(report);
            _context.SaveChanges();
            return report;
        }

        public IEnumerable<Reports> GetAll()
        {
            return _context.Reports.ToList();
        }

        public Reports GetById(int id)
        {
            return _context.Reports.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Reports> Search(string keyword)
        {
            return _context.Reports
                .Where(r =>
                    r.Category.Contains(keyword) ||
                    r.Description.Contains(keyword) ||
                    r.Location.Contains(keyword))
                .ToList();
        }
        public int GetReportsCount()
        {
            return _context.Reports.Count();
        }

    }
}
