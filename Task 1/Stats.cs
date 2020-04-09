using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
  public class Stats
    {

        public void NumberStats()
        {
            Console.WriteLine("Enter Number");

            double userImput = 0;
            bool isDouble = double.TryParse(Console.ReadLine(),out userImput);

            if (isDouble == true)
            {
                if (userImput < 0)
                {
                    Console.WriteLine("Negative");
                }
                else Console.WriteLine("Positive");

                if (userImput % 2 == 0)
                {
                    Console.WriteLine("eaven");
                }
                else Console.WriteLine("odd");

                if (userImput % 1 == 0)
                {
                    Console.WriteLine("not decimal");
                }
                else Console.WriteLine("decimal");

            }
            else Console.WriteLine("Eror...You chose poorly...Enter Number pls!");
        }

















    }
}
