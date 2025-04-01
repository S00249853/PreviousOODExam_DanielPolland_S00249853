using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamPaper2024OOD;

namespace DataManagement
{
     class Program
    {
        static void Main(string[] args)
        {
            RestaurantData db = new RestaurantData();

            Customer c1 = new Customer() { CustomerID = 1, Name = "Tom McGuire", ContactNumber = "087 674 3967" };
            Customer c2 = new Customer() { CustomerID = 2, Name = "John McGuire", ContactNumber = "087 980 4537" };
            Customer c3 = new Customer() { CustomerID = 3, Name = "Daniel McGuire", ContactNumber = "087 685 3121" };

            db.Customers.Add(c1);
            db.Customers.Add(c2);
            db.Customers.Add(c3);

            Console.WriteLine("Added Customers to Database");

            db.SaveChanges();

            Console.WriteLine("Saved Changes to Database");
        }
    }
}
