using System.Collections.Generic;
using TaizlostSmart.Models;

namespace TaizlostSmart.Services
{
    public interface IReportService
    {
        Reports AddReport(Reports report);
        IEnumerable<Reports> GetAll();
        Reports GetById(int id);
        IEnumerable<Reports> Search(string keyword);
        int GetReportsCount();

    }
}
