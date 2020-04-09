using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Users fistUser = new Users("John Doe", "JDo@somthing.com", "abracadabra123",);
            Users secUser = new Users("Simon Shoore", " LowSelfEsteem.com", "Adune_altar2519");
            Users thirdUser = new Users("John Hop", "WhatDAF@shityWeb.com", " aida64_$ ");

             Users[] Mesages =new Users[]{fistUser,secUser,thirdUser};

            //foreach (Users user in Mesages)
            //{
            //    Console.WriteLine(user.Password);
            //}

            Console.WriteLine("Plesea log in\n" +
                "Enter user name");
            string usernameImput = Console.ReadLine();
            foreach (Users user in Mesages)
            {
                if (user.Password == usernameImput)
                {

                }
            }
             

            Console.ReadLine();
        }
    }
}
