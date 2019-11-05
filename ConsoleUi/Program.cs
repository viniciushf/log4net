using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch=true)] //2 - 1 appconfig

namespace ConsoleUi
{
    class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();//log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); //3

        static void Main(string[] args)
        {
            log.Debug("Developer: Tutorial was run");
            log.Info("Maintence: water pump turnet on");
            log.Warn("Maintence: the water pump is getting hot");

            var i = 0;

            try
            {
                var x = 10 / i;
            }
            catch(DivideByZeroException ex)
            {
                log.Error("Developer: we tired to divide by zero again");
            }

            Counter j = new Counter();

            log4net.GlobalContext.Properties["Counter"] = j;

            for (j.LoopCounter = 0; j.LoopCounter < 5; j.LoopCounter++)
            {
                log.Fatal("This is a fatal erro in the process " );
            }

            log.Fatal("Maintence: water pump exploded");

            Console.ReadLine();
        }
    }
}
