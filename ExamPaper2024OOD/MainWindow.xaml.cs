﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamPaper2024OOD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RestaurantData db;
        int Capacity = 40;
        int Bookings;
        int Avaliable;

        public string name;
        public string contact;
        public int no;
        public DateTime date;
        public MainWindow()
        {
            InitializeComponent();
         
            db = new RestaurantData();

            var query = from Booking b in db.Bookings
                        where b.BookingsDate == dbxShow.DisplayDate
                        select b;
            
            lbxBookings.ItemsSource = query.ToList();

            Bookings = db.Bookings.Count();
            Avaliable = Capacity - Bookings;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tblkAvaliable.Text = "Avaliable " + Avaliable;
            tblkBookings.Text = "Bookings " + Bookings;
            tblkCapacity.Text = "Capacity " + Capacity;
        }

        private void bttnSearch_Click(object sender, RoutedEventArgs e)
        {
           if( int.TryParse(tbxCustomerNo.Text, out no))
            if (dbxMake.DisplayDate != null  )
            {
                MakeBook book = new MakeBook();
                book.Owner = this;
                name = tbxCustomerName.Text;
                contact = tbxCustomerContact.Text;
                date = dbxMake.DisplayDate;
                book.ShowDialog();
            }
        }
    }
}
