using System;

namespace Microsoft.Extensions.DependencyInjection.Issue.Reproduce.Desktop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IServiceCollection services = new ServiceCollection()
                .AddSingleton<ILogger, Logger>();

            ServiceProvider Provider = services.BuildServiceProvider();
        }
    }

    public interface ILogger
    {
    }

    public class Logger : ILogger
    {
    }
}
