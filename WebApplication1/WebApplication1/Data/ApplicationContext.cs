using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Data
{
    public class ApplicationContext:DbContext
    {
        public DbSet<DataInvoicesPay> DataInvoicesPays { get; set; }
        public DbSet<UnpaidBill> UnpaidBills { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

    }
}
