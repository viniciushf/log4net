using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4net
{
    class Program
    {
        static protected ILog log = LogManager.GetLogger("AplicacaoMacoratti");

        static void log4net_demo()
        {
            FileInfo fi = new FileInfo("log4net.xml");
            log4net.Config.XmlConfigurator.Configure(fi);
            log4net.GlobalContext.Properties["host"] = Environment.MachineName;
        }

        static void Main(string[] args)
        {
            log4net_demo();

            log.Info("this is an info msg");
            log.Debug("this is an info msg");
            log.Error("this is an info msg");
            log.Fatal("this is an info msg");
            log.Info("this is an info msg");


            log4net.Config.BasicConfigurator.Configure();
            log = log4net.LogManager.GetLogger("Program");

            log.Debug("Registrando eventos com log4net ; Debug");
            log.Info("Registro de log nivel Info...");
            log.Warn("Registro de log nível Warn...");
            log.Error("Registro de log nível Error");
            log.Fatal("Registro de log nível Fatal");

            Console.ReadLine();

        }


    }
}
