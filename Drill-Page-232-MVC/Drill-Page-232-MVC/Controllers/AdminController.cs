using Drill_Page_232_MVC.Models;
using Drill_Page_232_MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Drill_Page_232_MVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceQuotesEntities db = new InsuranceQuotesEntities())
            {
                var quotes = db.Quotes.ToList();
                var quoteVms = new List<QuoteVm>();
                foreach (var quote in quotes)
                {
                    var quoteVm = new QuoteVm();
                    quoteVm.Id = quoteVm.Id;
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.EmailAddress = quote.EmailAddress;
                    quoteVm.DateOfBirth = quote.DateOfBirth.Value;
                    quoteVm.CarYear = quote.CarYear;
                    quoteVm.CarMake = quote.CarMake;
                    quoteVm.CarModel = quote.CarModel;
                    quoteVm.DUIStatus = quote.DUIStatus;
                    quoteVm.SpeedingTicketNum = Convert.ToInt32(quote.SpeedingTicketNum);
                    quoteVm.TypeOfCoverage = quote.TypeOfCoverage;
                    quoteVm.CustomerQuote = quote.CustomerQuote;
                    quoteVms.Add(quoteVm);

                }
                return View(quoteVms);
            }
        }
    }
}