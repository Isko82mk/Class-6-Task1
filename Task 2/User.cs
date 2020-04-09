using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
   public class Users
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string [] Mesages  { get; set; }

        public Users(string aId, string aUsername, string aPassword, string[] aMesages)
        {
            Id = aId;
            Username = aUsername;
            Password = aPassword;
            Mesages = aMesages;
        }

       

    }



}
