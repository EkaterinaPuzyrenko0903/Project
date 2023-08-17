using Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;
using SQLitePCL;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Linq;
using Microsoft.AspNetCore.Components.Forms;
using System.Xml.Schema;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationContext _context;


        public HomeController(ILogger<HomeController> logger, ApplicationContext applicationContext)
        {
            _logger = logger;
            _context = applicationContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            var listpay = _context.DataInvoicesPays.ToList();
            return View(listpay);
        }
 
        [HttpPost]
        public IActionResult Result(Output update)
        {
            var viewModel = new HomeViewModel();
            //Сохранение данных
            if (!string.IsNullOrEmpty(update.Name))
            {
                var exist = _context.DataInvoicesPays.FirstOrDefault(x => x.Name == update.Name);

                if (exist != null)
                {
                    exist.Name = update.Name;
                    exist.payCondition = update.payCondition;
                    exist.DayPay = update.DayPay;
                    _context.DataInvoicesPays.Update(exist);
                    _context.SaveChanges();
                }
                
            }
            viewModel.Unpaids = _context.UnpaidBills.ToList();
            viewModel.Invoices = _context.DataInvoicesPays.ToList();
   
            return View(viewModel);

        }
        [HttpGet]
        public IActionResult Main()
        {
            var result = _context.UnpaidBills.ToList();
            return View(result);

        }
        [HttpPost]
        public IActionResult MainResult(Output update)
        {
            
            var viewModel = new HomeViewModel();
            //var sum = new List<DataInvoicesPay>();
            //sum = ( from e in _context.DataInvoicesPays join p in _context.UnpaidBills on e.Id equals p.Id  select e).ToList();
            //var total = _context.DataInvoicesPays.Join(_context.UnpaidBills, u=>u.Id, c=>c.Id, (u,c)=> new
            //{
            //    koding = u.Kod,
            //    koldate = u.DayPay
            //    //dateing = c.Date
            //}).ToList();

            viewModel.Unpaids = _context.UnpaidBills.ToList();
            viewModel.Invoices = _context.DataInvoicesPays.ToList();


            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}