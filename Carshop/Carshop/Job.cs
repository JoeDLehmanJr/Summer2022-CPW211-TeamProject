using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carshop
{
    class Job
    {
        private int _jobId;

        public Job(string jobCategory)
        {
            JobCategory = jobCategory;
        }

        public int JobId
        {
            get { return _jobId; }
            set { _jobId = value; }
        }

        public string JobCategory { get; set; }

    }
}
