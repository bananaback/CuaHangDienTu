using CuaHangDienTu.UI.Login;
using Microsoft.Extensions.DependencyInjection;

namespace CuaHangDienTu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Create a service collection for dependency injection
            var services = new ServiceCollection();

            // Register the login view and presenter
            services.AddSingleton<ILoginView, LoginForm>();
            //services.AddTransient<ILoginPresenter, LoginPresenter>();

            // Build the service provider
            var serviceProvider = services.BuildServiceProvider();

            var loginView = serviceProvider.GetRequiredService<ILoginView>();
            var loginPresenter = new LoginPresenter(serviceProvider, loginView);


            // Start the application with the login view
            Application.Run(loginView as Form);

        }
    }
}