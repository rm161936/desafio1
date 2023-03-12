using Desafío1App.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1App.Models
{
    internal class DatosLibrosModel
    {
        public DatosLibrosModel() { }

        public DatosLibrosModel(string nombre, string autor, List<string> genero, List<string> subGenero, List<string> paginas, List<string> protagonistas, List<string> antagonistas, string argumento, int idRecurso, int id)
        {
            Nombre = nombre;
            Autor = autor;
            Genero = StringHelper.CadenaCreator(genero);
            SubGenero = StringHelper.CadenaCreator(subGenero);
            Paginas = StringHelper.CadenaCreator(paginas);
            Protagonistas = StringHelper.CadenaCreator(protagonistas);
            Antagonistas = StringHelper.CadenaCreator(antagonistas);
            Argumento = argumento;
            IdRecurso = idRecurso;
            Id = id;
        }

        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; } = string.Empty;
        [DisplayName("Autor")]
        public string Autor { get; set; } = string.Empty;
        [DisplayName("Género")]
        public string Genero { get; set; } = string.Empty;
        [DisplayName("Subgénero")]
        public string SubGenero { get; set; } = string.Empty;
        [DisplayName("Páginas")]
        public string Paginas { get; set; } = string.Empty;
        [DisplayName("Protagonistas")]
        public string Protagonistas { get; set; } = string.Empty;
        [DisplayName("Antagonistas")]
        public string Antagonistas { get; set; } = string.Empty;
        [DisplayName("Argumento")]
        public string Argumento { get; set; } = string.Empty;
        public int IdRecurso { get; set; }

        public static DatosLibrosModel AsignarModelos(int id)
        {
            List<string> genresList;
            List<string> subGenresList;
            List<string> pagesList;
            List<string> mainCharactersList;
            List<string> antagonistsList;

            List<DatosLibrosModel> listaDatos = new();
            //*****************CREACIÓN DATOS 1*****************//
            genresList = new(new string[]{
                "Novela"
            });
            subGenresList = new(new string[]{
                "Literatura fantástica",
                "Literatura juvenil",
                "Novela de desarrollo",
                "Literatura infantil",
            });
            pagesList = new(new string[]{
                "3407 (ENG)",
                "3665 (ESP)"
            });
            mainCharactersList = new(new string[]{
                "Harry Potter",
                "Ron Weasley",
                "Hermione Granger",
                "Ginny Weasley",
                "Neville Longbottom",
                "Albus Dumbledore"
            });
            antagonistsList = new(new string[]{
                "Lord Voldemort",
                "Mortífagos"
            });
            DatosLibrosModel model= new(
                "Harry Potter",
                "J.K Rowling",
                genresList,
                subGenresList,
                pagesList,
                mainCharactersList,
                antagonistsList,
                "La historia comienza con la celebración del mundo mágico. Durante muchos años, había sido aterrorizado por el malvado mago Lord Voldermort. La noche del 31 de octubre, mató a Lily y James Potter. Sin embargo, cuando intenta matar a su hijo de 1 año, Harry, la maldición asesina Avada Kedavra se vuelve sobre sí mismo. El cuerpo de Voldemort resulta destruido, pero él sobrevive: no está muerto ni vivo. Por su parte, a Harry solo le queda una cicatriz con forma de rayo en la frente que es el único remanente físico de la maldición de Voldemort. Harry es el único sobreviviente de la maldición asesina, y a raíz de la misteriosa derrota de Voldemort, el mundo mágico empieza a llamarlo como <<el niño que sobrevivió>>",
                4,4);
            listaDatos.Add(model);

            genresList = new(new string[]{
                "Ciencia ficción",
                "Literatura infantil",
                "Suspenso"
            });
            subGenresList = new(new string[]{
                "Suspenso",
                "Terror",
                "Juvenil",
            });
            pagesList = new(new string[]{
                "",
            });
            mainCharactersList = new(new string[]{
                "El protagonista principal de una historia de Pesadillas/Escalofríos, es a menudo situado en una ubicación remota o de alguna manera aislada en algunas situaciones."
            });
            antagonistsList = new(new string[]{
                "",
            });
            DatosLibrosModel model1 = new(
                "GOOSEBUMPS",
                "Robert Lawrence Stine",
                genresList,
                subGenresList,
                pagesList,
                mainCharactersList,
                antagonistsList,
                "La serie consta de un total de 60 libros para España, el último de los cuales (Sangre de monstruo IV) se publicó en 1999, mientras que en Hispanoamérica consta de 45 historias.\r\nEl nombre se tradujo en España como Pesadillas y en Hispanoamérica como Escalofríos.",
                5,5);
            listaDatos.Add(model1);

            genresList = new(new string[]{
                "Novela policiaca"
            });
            subGenresList = new(new string[]{
                ""
            });
            pagesList = new(new string[]{
                "",
            });
            mainCharactersList = new(new string[]{
                "Perry Mason"
            });
            antagonistsList = new(new string[]{
                "",
            });
            DatosLibrosModel model2 = new(
                "PERRY MASON",
                "Erle Stanley Gardner",
                genresList,
                subGenresList,
                pagesList,
                mainCharactersList,
                antagonistsList,
                "El personaje era un abogado que llegó a aparecer en 80 novelas e historias cortas, la mayoría de las cuales versaban sobre la defensa de un cliente que había sido acusado de asesinato. En general, Perry Mason era capaz de demostrar la inocencia de su cliente mediante la averiguación de la culpabilidad del verdadero asesino, otro personaje de la historia.",
                6,6);
            listaDatos.Add(model2);

            return listaDatos.Find(e => e.IdRecurso.Equals(id));
        }
    }
}
