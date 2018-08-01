using CoreConsoleAppTutorial.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsoleAppTutorial.Tutorials
{
    class ListExample
    {
        public ListExample()
        {
            Customer customer1 = new Customer
            {
                Name = "Iman"
            };

            Customer customer2 = new Customer
            {
                Name = "shahidul"
            };

            Customer customer3 = new Customer
            {
                Name = "Mizan"
            };

            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Insert(1, customer3);


            foreach (Customer c in customers)
            {
                Console.WriteLine($"Name = {c.Name}");
            }
        }
    }
}
