using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsoleAppTutorial.Tutorials
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class DictionaryExample
    {
        public DictionaryExample()
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                Name = "Iman"
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "Sahidul"
            };

            Dictionary<int, Customer> customerDictionaries = new Dictionary<int, Customer>();

            customerDictionaries.Add(customer1.Id, customer1);
            customerDictionaries.Add(customer2.Id, customer2);

            // Check key exist or not
            if (!customerDictionaries.ContainsKey(customer1.Id))
            {
                customerDictionaries.Add(customer1.Id, customer2);
            }

            foreach (KeyValuePair<int, Customer> CustomerKeyValuePair in customerDictionaries)
            {
                Customer customer = CustomerKeyValuePair.Value;
                Console.WriteLine($"Key = {CustomerKeyValuePair.Key}");
                Console.WriteLine($" id = {customer.Id}, name = {customer.Name} ");
            }
        }
    }
}
