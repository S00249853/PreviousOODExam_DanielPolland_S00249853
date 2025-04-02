using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaper2024OOD
{
    public partial class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public virtual List<Booking> Bookings { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Name, ContactNumber);
        }
    }
}
