using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carshop
{
    class AutoShop
    {
        private int _autoShopId;

        public AutoShop(string make, string model, string releaseYear, string status)
        {
            Make = make;
            Model = model;
        }

        public int autoShopId
        {
            get { return _autoShopId; }
            set { _autoShopId = value; }
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public string releaseYear { get; set; }

        public string userStatus { get; set; }
    }
}
