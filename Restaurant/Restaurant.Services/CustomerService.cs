namespace Restaurant.Services
{
    using Restaurant.Data;
    using Restaurant.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public  class CustomerService
    {
        private AppDbContext context;
        public string AddCustomer(string name,string adress,string phoneNumber)
        {
            StringBuilder sb = new StringBuilder();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(name))
            {
                sb.AppendLine($"Invalid {nameof(name)}!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(adress))
            {
                sb.AppendLine($"Invalid {nameof(adress)}!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                sb.AppendLine($"Invalid {nameof(phoneNumber)}!");
                isValid = false;
            }
            if (isValid)
            {
                Customer customer = new Customer()
                {
                    Name = name,
                    Address= adress,
                    PhoneNumber = phoneNumber
                };
                using (context = new AppDbContext())
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                    sb.AppendLine($"Customer {name} is added!");
                }
            }
            return sb.ToString().TrimEnd();


        }
        public List<string> GetCustomers()
        {
            List<string> customersInfo;
            using (context = new AppDbContext())
            {
                customersInfo = this.context.Customers.
                     OrderBy(x => x.Id)
                     .Select(x => $"{x.Id} - {x.Name}")
                     .ToList();
            }
            return customersInfo;
        }
    }
}
