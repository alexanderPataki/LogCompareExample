using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetExample
{
    public class LogHelper
    {
        /// <summary>
        /// http://www.thomaslevesque.com/2012/06/13/using-c-5-caller-info-attributes-when-targeting-earlier-versions-of-the-net-framework/
        /// https://msdn.microsoft.com/pt-br/library/system.runtime.compilerservices.callerfilepathattribute%28v=vs.110%29.aspx
        /// </summary>
        /// <param name="fileName">Valor definido em momento de compilacao</param>
        /// <returns></returns>
        public static log4net.ILog GetLogger([CallerFilePath] string fileName = "")
        {
            return log4net.LogManager.GetLogger(fileName);
        }
    }
}
