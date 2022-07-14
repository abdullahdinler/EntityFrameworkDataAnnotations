using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkDataAnnotations.Context;
using EntityFrameworkDataAnnotations.Entites;

namespace EntityFrameworkDataAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new NorthwindContext())
            {
                List<Customer> customers = context.Customers.ToList();
                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                }
            }

            Console.ReadLine();
        }
    }
}
