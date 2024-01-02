using Krypton_toolKitDemo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PosManager.Helper;
using Serilog;
using System.Runtime.InteropServices;

namespace PosManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        private static readonly IHost _host = CreateHostBuilder();
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Debug()
                 .WriteTo.File("LOGSAPP/myapp.txt", rollingInterval: RollingInterval.Day)
                 .CreateLogger();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            try
            {
                _host.Start();
                //Đoạn này mặc định của winform kệ nó thôi.
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                InputLanguage vietnameseInputLanguage = null;
                foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
                {
                    if (lang.Culture.Name == "vi-VN")
                    {
                        vietnameseInputLanguage = lang;
                        break;
                    }
                }
                Application.CurrentInputLanguage = vietnameseInputLanguage;
                //Lấy ra cái fThemNhanVien đã được khai báo trong services
                try
                {
                    var form1 = _host.Services.GetRequiredService<fLogin>();
                    //Lệnh chạy gốc là: Application.Run(new fThemNhanVien);
                    //Đã được thay thế bằng lệnh sử dụng service khai báo trong host
                    Application.Run(form1);
                    Log.Information("Application start");
                }
                catch (Exception ex)
                {

                    Log.Error(ex.Message);
                    if (ex.InnerException != null)
                    {
                        Log.Error(ex.ToString());
                        Log.Error(ex.InnerException.Message);
                    }
                    MessageCommon.ShowMessageBox(ex.Message, 4);
                }
                //Khi form chính (form1) bị đóng <==> chương trình kết thúc ấy
                //thì dừng host
                _host.StopAsync().GetAwaiter().GetResult();
                //và giải phóng tài nguyên host đã sử dụng.
                _host.Dispose();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                if (ex.InnerException != null)
                {
                    Log.Error(ex.ToString());
                    Log.Error(ex.InnerException.Message);
                }
                MessageCommon.ShowMessageBox(ex.Message, 4);
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
        static IHost CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<fLogin>();
                }).Build();
        }
    }
}