using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carshop
{
    class JobItemization
    {
        private int _jobItemizationId;

        public JobItemization(string jobType, double itemCost)
        {
            JobType = jobType;
            ItemCost = itemCost;
        }

        public int JobItemizationId
        {
            get { return _jobItemizationId; }
            set { _jobItemizationId = value; }
        }

        public string JobType { get; set; }

        public double ItemCost { get; set; }
    }
}
