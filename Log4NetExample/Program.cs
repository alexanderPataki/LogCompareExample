using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Log4NetExample
{
    class Program
    {
        //Utilizar o reflection eh mais lento, mas isso eh feito uma vez por classe (Para framework anteriores a 4.5)
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //Para Framework 4.5 ou superior (Definindo o log em momento de compilacao)
        private static readonly log4net.ILog log = LogHelper.GetLogger();

        static void Main(string[] args)
        {
            log.Debug("Mensagem de debug");
            log.Info("Mensagem de info");
            log.Warn("Mensagem de warning");

            int i = 0;
            try
            {
                int result = 10 / i;
            }
            catch(DivideByZeroException e)
            {
                log.Error("Mensagem de Erro", e);
            }

            log.Fatal("Mensagem de erro Fatal");

            Console.ReadLine();
        }
    }
}
