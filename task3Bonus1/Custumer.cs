using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Custumer
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public string[] cardNumber { get; set; }
        private string[] pinNumber;
        private int balance;

        
        public Custumer(string aName,string aLastName, string[] aCardNumber,string[] aPinNumber, int aBalance)
        {
            name = aName;
            lastName = aLastName;
            cardNumber = aCardNumber;
            pinNumber = aPinNumber;
            balance = aBalance;
        }


        //public string Name
        //{
        // get { return name; }
        //}

        public string[] PinNumber
        {
            get { return pinNumber; }
        }

        public int Balance
        {
            get { return balance; }
        }


    }
}
