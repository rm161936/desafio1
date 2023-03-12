using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1App.Models
{
    internal class Users
    {
        public Users()
        {

        }
        public Users(string username, string password, int id)
        {
            Username = username;
            Password = password;
            Id = id;
        }
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        //BASE DE DATOS DE USUARIOS
        public static List<Users> LocalDbUsers()
        {
            List<Users> usersList = new();
            Users user = new("fcortez", "Flamenco01@", 1);
            Users user1 = new("pflores", "Flamenco02@", 2);
            Users user2 = new("jhernandez", "Flamenco03@", 3);
            Users user3 = new("eguerra", "Flamenco04@", 4);
            Users user4 = new("hramos", "Flamenco05@", 5);

            usersList.Add(user);
            usersList.Add(user1);
            usersList.Add(user2);
            usersList.Add(user3);
            usersList.Add(user4);

            return usersList;
        }

    }
}
