using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
namespace WebApplication1.Models
{
    public class HomeViewModel
    {
        //public UnpaidBill? unpaidBill {get; set;}
        //public DataInvoicesPay invoicesPay { get; set;}
        public List<UnpaidBill> Unpaids { get; set; }
        public List<DataInvoicesPay> Invoices { get; set; }



    }
}
