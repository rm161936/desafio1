using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1App.Models
{
    internal static class ActiveSession
    {
        public static string UserName { get; set; } = string.Empty;
        public static bool Sesion { get; set; }
        public static List<CategoriaModel> Categorias { get; set; } = new List<CategoriaModel>();
    }
}
