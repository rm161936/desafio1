using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1App.Models
{
    internal class CategoriaModel
    {
        public CategoriaModel()
        {
        }

        public CategoriaModel(int id, string categoria,List<RecursoModel> recursos)
        {
            Id = id;
            Categoria = categoria;
            RecursoModelList = recursos;
        }

        public int Id { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public List<RecursoModel> RecursoModelList { get; set; } = new List<RecursoModel>();

        public static List<CategoriaModel> LocalDbCategories()
        {
            List<CategoriaModel> catList = new();
            CategoriaModel cat = new(1, "Programas de entretenimiento",RecursoModel.LocalDbRecursos(1));
            CategoriaModel cat1 = new(2, "Libros", RecursoModel.LocalDbRecursos(2));
            CategoriaModel cat2 = new(3, "Lenguajes de programación", RecursoModel.LocalDbRecursos(3));

            catList.Add(cat);
            catList.Add(cat1);
            catList.Add(cat2);

            return catList;
        }

    }
}
