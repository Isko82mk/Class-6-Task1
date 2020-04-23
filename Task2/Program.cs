using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            User bob = new User(1289, "bob1", "12346", new string[] { "mesage1", "mesage2", "mesage3" });
            User john = new User(1279, "john1", "1235", new string[] { "mesage1", "mesage2", "mesage3", "mesage4" });
            User mike = new User(1233, "mike1", "4659", new string[] { "mesage1" });
            User david = new User(1256, "david1", "46", new string[] { });

            User[] users = new User[] { bob, john, mike, david };

            bool isItEmptyArr = false;

            Console.WriteLine("Select\n" +
                " 1 to Log in or\n " +
                " 2 to Register");


            string userImput = Console.ReadLine();


            if (userImput == "1")
            {

                Console.WriteLine("Enter your usere name");

                string userNameImput = Console.ReadLine();

                foreach (User user in users)
                {
                    if (user.Username == userNameImput && userImput != "")
                    {
                        Console.WriteLine("Enter password");

                        string userPassImput = Console.ReadLine();
                        if (user.Password == userPassImput && userPassImput != "")
                        {

                            Console.WriteLine($" Welcome  {user.Username}.\n" +
                                $" Here are your messages:");

                            for (int i = 0; i < user.Mesages.Length; i++)
                            {
                                if (user.Mesages.Length > 0)
                                {
                                    Console.WriteLine($"{user.Mesages[i]}");
                                    isItEmptyArr = true;

                                }
                            }
                            if (!isItEmptyArr)
                            {
                                Console.WriteLine("error...no mesages");
                            }
                        }
                    }
                }
            }
            else if (userImput == "2")
            {
                Console.WriteLine("Pls. fill out Registration form");

                Console.WriteLine("Enter user name ");
                string userNameReg = Console.ReadLine();

                Console.WriteLine("Enter id ");
                int userIdReg = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter password ");
                string userPassReg = Console.ReadLine();


                foreach (User user in users)
                {
                    if (user.Username == userNameReg)
                    {
                        Console.WriteLine("There is already a user called like that");
                        break;

                    }
                    else if (user.Username != userNameReg)
                    {
                        User newUser = new User(userIdReg, userNameReg, userPassReg, new string[] { });
                        Array.Resize(ref users, users.Length + 1);
                        users[users.Length - 1] = newUser;
                        PringIndexAndValues(users);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("eror...pls selec 1 or 2");
            }
            Console.ReadLine();



        }

        public static void PringIndexAndValues(User[] arr)
        {
            Console.WriteLine("Registration complete! Users:");
            foreach (User user in arr)
            {
                Console.WriteLine($"User id: {user.id} User Name : {user.Username}");
            }
        }

    }
}
