using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaper2024OOD
{
    public class Booking
    {
        public int BookingID { get; set; }
        public DateTime BookingsDate { get; set; }
        public int NumberOfParticipants { get; set; }
        public virtual Customer Customer { get; set; }

        public override string ToString()
        {
            return $"{Customer.Name} ({Customer.ContactNumber}) - Party of {NumberOfParticipants}";
        }
    }
}
