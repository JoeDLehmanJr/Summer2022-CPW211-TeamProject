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

        public PaymentType(string cardType, string cardNumber, string dateOfExpiration, 
            string cvs, string authorizationNumber)
        {
            
        }

        public int PaymentTypeId
        {
            get { return _paymentTypeId; }
            set { _paymentTypeId = value; }
        }

        public string CardType { get; set; }

        public string CardNumber { get; set; }

        public string DateOfExpiration { get; set; }

        public string Cvs { get; set; }

        public string AuthorizationNumber { get; set; }

    }
}
