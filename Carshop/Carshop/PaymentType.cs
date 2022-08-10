using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carshop
{
    class PaymentType
    {
        private int _paymentTypeId;

        public PaymentType(string cardType, int cardNumber, DateTime dateOfExpiration, 
            int cvs, int authorizationNumber)
        {

        }

        public int PaymentTypeId
        {
            get { return _paymentTypeId; }
            set { _paymentTypeId = value; }
        }

        public string CardType { get; set; }

        public int CardNumber { get; set; }

        public DateTime DateOfExpiration { get; set; }

        public int Cvs { get; set; }

        public int AuthorizationNumber { get; set; }

    }
}
