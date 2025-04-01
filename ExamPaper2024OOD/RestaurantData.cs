using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPaper2024OOD
{
    public class RestaurantData : DbContext
    {
        public RestaurantData():base("<OODExam>_<Daniel Polland>") { }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
