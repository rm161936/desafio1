using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1App.Models
{
    internal class DatosProgramacionModel
    {
        public DatosProgramacionModel(string nombre, int id, string developers, string extensions, string appears, string operativeSystem, string paradigm, string latestVersion, string license, int idRecurso)
        {
            Id = id;
            Nombre = nombre;
            Developers = developers;
            Extensions = extensions;
            Appears = appears;
            OperativeSystem = operativeSystem;
            Paradigm = paradigm;
            LatestVersion = latestVersion;
            License = license;
            IdRecurso = idRecurso;
        }

        public DatosProgramacionModel() { }

        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; } = string.Empty;
        [DisplayName("Desarrolladores")]
        public string Developers { get; set; } = string.Empty;
        [DisplayName("Extensiones")]
        public string Extensions { get; set; } = string.Empty;
        [DisplayName("Apareció en")]
        public string Appears { get; set; } = string.Empty;
        [DisplayName("Sistema operativo")]
        public string OperativeSystem { get; set; } = string.Empty;
        [DisplayName("Paradigma")]
        public string Paradigm { get; set; } = string.Empty;
        [DisplayName("Ultima versión estable")]
        public string LatestVersion { get; set; } = string.Empty;
        [DisplayName("Licencia")]
        public string License { get; set; } = string.Empty;
        public int IdRecurso { get; set; }

        public static DatosProgramacionModel AsignarModelos(int id)
        {

            List<DatosProgramacionModel> listaDatos = new();
            DatosProgramacionModel model = new(
                "PYTHON",
                7,
                "Python Software Foundation", 
                ".py, .pyc, .pyd, .pyo, .pyw, .pyz",
                "1991",
                "Multiplataforma",
                "Multiparadigma: orientado a objetos, imperativo, funcional, reflexivo",
                "3.8.3",
                "Pyrhon Software Foundation License",
                7);
            DatosProgramacionModel model1 = new(
                "JAVA",
                8,
                "James Gosling y Sun Microsystems",
                "java, class, jar, jad y jmod",
                "1996",
                "Multiplataforma",
                "Orientado a objetos, imperativo",
                "14.01",
                "GNU PL / Java Community Process",
                8);
            DatosProgramacionModel model2 = new(
                "JAVASCRIPT",
                9,
                "",
                ".js",
                "1995",
                "",
                "Multiparadigma, programación funcional, programación basada en prototipos, imperativo, interpretado (scripting)",
                "ECMAScript2016",
                "",
                9);
            listaDatos.Add(model);
            listaDatos.Add(model1);
            listaDatos.Add(model2);

            return listaDatos.Find(e => e.IdRecurso.Equals(id));

        }
    }
}
