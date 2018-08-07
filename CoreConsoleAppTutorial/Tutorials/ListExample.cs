using CoreConsoleAppTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreConsoleAppTutorial.Tutorials
{
    class ListExample
    {
        public ListExample()
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                Name = "Iman"
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "shahidul"
            };

            Customer customer3 = new Customer
            {
                Id = 3,
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

            Console.WriteLine("=========List to dictionary distionaries============");
            
            Dictionary<int, Customer> custDictionaries = customers.ToDictionary(x => x.Id, x => x);

            foreach (KeyValuePair<int, Customer> kvp in custDictionaries)
            {
                Customer cust = kvp.Value;
                Console.WriteLine($"Name = {cust.Name}");
            }
        }
    }
}
