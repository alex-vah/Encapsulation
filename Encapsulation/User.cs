using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class User
    {
        private readonly Guid _id;
        private string _name;
        public decimal _balance;
        public User()
        {
            _id = Guid.NewGuid();
        }
        public User(string name)
        {
            _name = name;
            _id = Guid.NewGuid();
            _balance = default(decimal);
        }
        public string Name
        {
            get { return _name; }
        }
        public Guid Id
        {
            get { return _id; }
        }
        protected decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
