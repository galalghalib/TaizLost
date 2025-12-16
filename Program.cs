using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TaizlostSmart.Data;
using TaizlostSmart.Services;
using TaizlostSmart.Forms.ReportUI;
using TaizlostSmart.Forms.Auth;
using TaizlostSmart.Forms.Home;

namespace TaizlostSmart.Forms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer("Server=DESKTOP-VMO6NJL;Database=TaizlostDB;Trusted_Connection=True;Encrypt=False;"));

                
                services.AddScoped<IUserService, UserService>();
                services.AddScoped<IReportService, ReportService>();

                
                services.AddScoped<LoginForm>();
                services.AddScoped<RegisterForm>();
                services.AddScoped<HomeForm>();
                services.AddScoped<AddReportForm>();
                services.AddScoped<SearchReportsForm>();
                services.AddScoped<ViewReportForm>();
            })
            .Build();

        using (var scope = host.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            Application.Run(services.GetRequiredService<LoginForm>());
        }
    }
}
