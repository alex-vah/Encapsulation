using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Bank
    {
        public User _user;
        public void MoneyOut(decimal cash)
        {
            if(_user._balance>=cash)
            {
                _user._balance = _user._balance - cash;
                Console.WriteLine("Transfer completed successfully");
            }
            else
            {
                Console.WriteLine("Transfer declined");
            }
        }
        public void MoneyIn(decimal cash)
        {
            _user._balance = _user._balance + cash;
        }


        
    }
}
