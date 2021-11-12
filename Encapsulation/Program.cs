using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bank bank = new Bank();
            bank._user = new User("Arsen");
            bank.MoneyIn(5000);
            bank.MoneyOut(4000);
           
        }

    }
}
