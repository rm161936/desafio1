using Desafío1App.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1App.Models
{
    internal class DatosModel
    {
        public DatosModel(string title, int seasons, int chapters, string synopsis, List<string> creators, List<string> characters, List<string> countries, int id, int idRecurso)
        {
            Title = title;
            CreatedBy = StringHelper.CadenaCreator(creators);
            MainCharacters = StringHelper.CadenaCreator(characters);
            CountryOrigin = StringHelper.CadenaCreator(countries);
            Seasons = seasons;
            Chapters = chapters;
            Synopsis = synopsis;
            Id = id;
            IdRecurso = idRecurso;
        }

        public DatosModel()
        {
        }

        public int Id { get; set; }
        [DisplayName("Título en español")]
        public string Title { get; set; } = string.Empty;
        [DisplayName("Creado por")]
        public string CreatedBy { get; set; } = string.Empty;
        [DisplayName("Protagonistas")]
        public string MainCharacters { get; set; } = string.Empty;
        [DisplayName("País de origen")]
        public string CountryOrigin { get; set; } = string.Empty;
        [DisplayName("Temporadas")]
        public int Seasons { get; set; }
        [DisplayName("Episodios")]
        public int Chapters { get; set; }
        [DisplayName("Sinopsis")]
        public string Synopsis { get; set; } = string.Empty;
        public int IdRecurso { get; set; }

        public static DatosModel AsignarModelos(int id)
        {
            List<string> creatorsList;
            List<string> mainCharactersList;
            List<string> countryOriginList;

            List<DatosModel> listaDatos = new();
            //*****************CREACIÓN DATOS 1*****************//
            creatorsList = new(new string[]{
                "David Benioff",
                "D. B. Weiss"
            });

            mainCharactersList = new(new string[]
            {
                "Sean Bean",
                "Nikolaj Coster-Waldau",
                "Peter Dinklage",
                "Emilia Clarke",
                "Lena Healdey",
                "Iain Glen",
                "Kit Harington",
                "Sophie Turner",
                "Maisie Williams",
                "Isaac Hempstead-Wright",
                "Natalie Dormer"
            });

            countryOriginList = new(new string[]
            {
                "Estados Unidos"
            });


            DatosModel datos = new(
                "Juego de tronos", 
                8, 
                73, 
                "La trama de Game of Thrones está basada en la serie de novelas Canción de hielo y fuego, y relata las vivencias de un grupo de personajes de distintas casas nobiliarias en el continente ficticio Poniente para tener el control del Trono de Hierro y gobernar los siete reinos que conforman el territorio.",
                creatorsList,
                mainCharactersList,
                countryOriginList,
                1,1);

            //*****************CREACIÓN DATOS 2*****************//
            creatorsList = new(new string[]{
                "Craig Mazin"
            });

            mainCharactersList = new(new string[]
            {
                "Jared Harris",
                "Stellan Skarsgård",
                "Emily Watson"
            });

            countryOriginList = new(new string[]
            {
                "Estados Unidos",
                "Reino Unido"
            });

            DatosModel datos1 = new(
                "Chernóbil",
                1,
                5,
                "La serie gira en torno al desastre nuclear de Chernóbil de abril de 1986 y los esfuerzos de limpieza sin precedentes que siguieron.",
                creatorsList,
                mainCharactersList,
                countryOriginList,
                2,2);

            //*****************CREACIÓN DATOS 3*****************//
            creatorsList = new(new string[]{
                "Amy Sherman-Palladino"
            });

            mainCharactersList = new(new string[]
            {
                "Rachel Brosnahan",
                "Michael Zegen",
                "Alex Borstein",
                "Tony Shalhoub",
                "Marin Hinkle"
            });

            countryOriginList = new(new string[]
            {
                "Estados Unidos"
            });

            DatosModel datos2 = new(
                "La maravillosa Señora Maisel",
                3,
                26,
                "La serie cuenta la historia de un ama de casa en Nueva York que descubre que tiene una habilidad especial para la comedia en vivo. El primer episodio se estrenó como parte de la temporada de pilotos de primavera de Amazon Studois el 17 de marzo de 2017, recibiendo la aclamación de la crítica.",
                creatorsList,
                mainCharactersList,
                countryOriginList,
                3, 3);

            listaDatos.Add(datos);
            listaDatos.Add(datos1);
            listaDatos.Add(datos2);

            return listaDatos.Find(e => e.IdRecurso.Equals(id));
        }


    }
}
