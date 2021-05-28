using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class InvoiceDb
    {
        public List<Invoice> GetAllInvoices()
        {
            using(Context context = new Context())
            {
                List<Invoice> InvoiceList = (from invoice in context.Invoices select invoice).Take(20).ToList();
                return InvoiceList;
            }
        }
    }
}
