using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
   public class CashServices
    {

        public int CheckBalance(int balance,int withdrawal)
        {

            return balance- withdrawal;

        }

        public int Deposite(int balance,int deposite)
        {
            return balance + deposite;
        }



    }
}
