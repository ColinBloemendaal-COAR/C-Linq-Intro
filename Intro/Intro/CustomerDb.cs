using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class CustomerDb
    {
        public List<Customer> GetAllCustomers()
        {
            using (Context context = new Context())
            {
                List<Customer> CustomerList = (from customer in context.Customers select customer).Take(20).ToList();
                return CustomerList;
            }
        }
    }
}
