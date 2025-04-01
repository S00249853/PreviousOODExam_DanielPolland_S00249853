using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaper2024OOD
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}
