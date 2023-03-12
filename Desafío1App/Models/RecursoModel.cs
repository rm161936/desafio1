using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1App.Models
{
    internal class RecursoModel
    {
        public RecursoModel(int id, string nombre, int percentage, int categoriaId, DatosModel? datosModel, DatosLibrosModel? datosLibros, DatosProgramacionModel? datosProgramacion)
        {
            Id = id;
            Nombre = nombre;
            Percentage = percentage;
            CategoriaId = categoriaId;
            DatosPrograma = datosModel;
            DatosLibros = datosLibros;
            DatosProgramacion = datosProgramacion;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Percentage { get; set; }
        public int CategoriaId { get; set; }
        public DatosModel? DatosPrograma { get; set; }
        public DatosLibrosModel? DatosLibros { get; set; }
        public DatosProgramacionModel? DatosProgramacion { get; set; }

        public static List<RecursoModel> LocalDbRecursos(int id)
        {
            List<RecursoModel> recList = new();
            RecursoModel rec = new(1, "GAME OF THRONES",40,1,DatosModel.AsignarModelos(1),null,null);
            RecursoModel rec1 = new(2, "CHERNOBYL", 34, 1, DatosModel.AsignarModelos(2), null, null);
            RecursoModel rec2 = new(3, "THE MARVELOUS MRS. MAISEL", 26, 1, DatosModel.AsignarModelos(3), null, null);
            RecursoModel rec3 = new(4, "HARRY POTTER", 44, 2, null, DatosLibrosModel.AsignarModelos(4), null);
            RecursoModel rec4 = new(5, "GOOSEBUMPS", 30, 2, null, DatosLibrosModel.AsignarModelos(5), null);
            RecursoModel rec5 = new(6, "PERRY MASON", 26, 2, null, DatosLibrosModel.AsignarModelos(6), null);
            RecursoModel rec6 = new(7, "PYTHON", 47, 3,null,null,DatosProgramacionModel.AsignarModelos(7));
            RecursoModel rec7 = new(8, "JAVA", 38, 3, null, null, DatosProgramacionModel.AsignarModelos(8));
            RecursoModel rec8 = new(9, "JAVASCRIPT", 15, 3, null, null, DatosProgramacionModel.AsignarModelos(9));

            recList.Add(rec);
            recList.Add(rec1);
            recList.Add(rec2);
            recList.Add(rec3);
            recList.Add(rec4);
            recList.Add(rec5);
            recList.Add(rec6);
            recList.Add(rec7);
            recList.Add(rec8);

            return recList.Where(e => e.CategoriaId.Equals(id)).ToList();
        }

    }
}
