using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Custumer bobJ = new Custumer("Bob","Johnson",new string[] { "123-123-123", "123-153-123", "723-123-123" },new string[] { "2244" } );
            Custumer simonB = new Custumer("Simon","Bronson",new string[] {"111-112-122", "151-112-122" },new string[] {"1212" });
            Custumer JohbA = new Custumer("John", "Abramson", new string[] { "423-323-223", "111-152-152" }, new string[] { "3244" });
            Custumer MikeR = new Custumer("Mike", "Rimus", new string[] { "511-612-722", "121-152-127" }, new string[] { "5216" });

            Custumer[] custumers = new Custumer[] { bobJ,simonB,JohbA,MikeR};
            bool isWrong = false;
            //LoopThruCustumersArr(custumers);

            Console.WriteLine("Welcome to the ATM app\n");

            Console.WriteLine("Please enter your card number:");
            string userCardNumberImput = Console.ReadLine();

            Console.WriteLine("Enter Pin:");
            string userPinNumberImput = Console.ReadLine();


            foreach (Custumer custumer in custumers)
            {
                for (int i=0; i<custumer.CardNumber.Length; i++)
                {
                    if(custumer.CardNumber[i] == userCardNumberImput && custumer.PinNumber[i]==userPinNumberImput)
                    {
                        isWrong = true;
                        Console.WriteLine($"Welcome{custumer.Name} {custumer.LastName}");
                       
                        Console.WriteLine("What would you like to do:\n" +
                            "1.Check Balance\n" +
                            "2.Cash Withdrawal\n" +
                            "3.Cash Deposit\n");

                    }
                    
                }
            }
            if (!isWrong)
            {
                Console.WriteLine("Eroor...Wrong card number or pin");
            }

           



            Console.ReadLine();
        }

        public static void LoopThruCustumersArr(Custumer []custumers)
        {
            foreach (Custumer custumer in custumers)
            {
                Console.WriteLine($"{custumer.Name}{custumer.LastName}");
            }
        }

    }
}
