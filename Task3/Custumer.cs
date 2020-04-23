using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Custumer
    {
        public string Name { get; set; }
        public string LastName {get;set;}
        public string [] CardNumber { get; set; }
        public string [] PinNumber { get; set; }
        
        public Custumer(string aName, string aLastName, string[]cardNumber,string[]pinNumber)
        {
            Name = aName;
            LastName = aLastName;
            CardNumber = cardNumber;
            PinNumber = pinNumber;
        }
    }
}
