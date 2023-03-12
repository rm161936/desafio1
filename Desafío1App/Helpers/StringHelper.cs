using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1App.Helpers
{
    internal class StringHelper
    {
        public static string CadenaCreator(List<string> data)
        {
            string cadena = "";
            data.ForEach(e =>
            {
                cadena += e + "\r\n";
            });

            return cadena;
        }
    }
}
