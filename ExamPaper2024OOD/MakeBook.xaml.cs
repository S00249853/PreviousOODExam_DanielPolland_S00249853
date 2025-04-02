using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamPaper2024OOD
{
    /// <summary>
    /// Interaction logic for MakeBook.xaml
    /// </summary>
    public partial class MakeBook : Window
    {
        RestaurantData db;
        string name;
        string contact;
        int no;
        DateTime date;
        Customer customer;
        public MakeBook()
        {
            InitializeComponent();

            db = new RestaurantData();

            var query = from Customer in db.Customers
                        where Customer.Name.Contains(name)
                        select Customer;

            lbxCustomers.ItemsSource = query.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           MainWindow main = this.Owner as MainWindow;
            name = main.name;
            contact = main.contact;
            no = main.no;
            date = main.date;
            tblkDate.Text = $"Date of booking - {date}";
            tblkNo.Text = $"Number of customers - {no}";
            tbxName.Text = name;
            tbxContact.Text = contact;
        }

        private void bttnCreate_Click(object sender, RoutedEventArgs e)
        {
            foreach (var c in db.Customers)
            {
                if (c.Name == tbxName.Text && c.ContactNumber == tbxContact.Text)
                {
                    db.Bookings.Add(new Booking() { BookingsDate = date, NumberOfParticipants = no, Customer = c });

                    this.Close();
                }
            }
            customer = new Customer() { Name = tbxName.Text, ContactNumber = tbxContact.Text };
            db.Customers.Add(customer);
            db.Bookings.Add(new Booking() { BookingsDate = date, NumberOfParticipants = no, Customer = customer });
            this.Close();
        }

        private void lbxCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Customer c = lbxCustomers.SelectedItem as Customer;
            tbxName.Text = c.Name;
            tbxContact.Text = c.ContactNumber;
        }
    }
}
