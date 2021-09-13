using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{   
    [Serializable]
    public class Visit
    {
        public int VisitID { get; set; }

        public Resident Resident { get; set; }

        public Guest Guest { get; set; }

        public DateTime Date { get; set; }

        public Boolean ProcessingStatus { get; set; }
    }
}
