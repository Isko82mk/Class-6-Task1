using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
   public class User
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string[] Mesages { get; set; }

        public User(int aId, string aUsername, string aPassword, string[] mesages)
        {
            id = aId;
            Username = aUsername;
            Password = aPassword;
            Mesages = mesages;

        }

    }
}
