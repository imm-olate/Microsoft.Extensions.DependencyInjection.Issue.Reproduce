using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace Unit.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Initialise()
        {
            IServiceCollection services = new ServiceCollection()
                .AddSingleton<ILogger, Logger>();

            ServiceProvider Provider = services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }

    public interface ILogger
    {
    }

    public class Logger : ILogger
    {
    }
}
