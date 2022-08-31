using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carshop
{
    class Customers
    {
        private int _customersId;

        public Customers(string firstName, string lastName, string payment)
        {
            FirstName = firstName;
            LastName = lastName;
            Payment = payment;

        }

        public int CustomersId
        {
            get { return _customersId; }
            set { _customersId = value; }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Payment { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
    }
}
