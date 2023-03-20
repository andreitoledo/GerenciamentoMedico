using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Applications.Extensions
{
    public static class ImportUtils
    {
        //Essa classe tem apenas uma única responsabilidade.
        public static string GetFilePath(string raiz, string filename, string extension)
        {
            // A maneira como é implementado.
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var csvPath = Path.Combine(outPutDirectory, $"{raiz}\\{filename}{extension}");
            return new Uri(csvPath).LocalPath;
         
        }
    }
}
