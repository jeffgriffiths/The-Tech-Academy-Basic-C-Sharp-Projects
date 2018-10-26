using Drill_Page_232_MVC.Models;
using Drill_Page_232_MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Drill_Page_232_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, string carYear, 
                                    string carMake, string carModel, string duiStatus, int speedingTicketNum, string typeOfCoverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceQuotesEntities db = new InsuranceQuotesEntities())
                {
                    var quote = new Quote();
                    quote.FirstName = firstName;
                    quote.LastName = lastName;
                    quote.EmailAddress = emailAddress;
                    quote.DateOfBirth = Convert.ToDateTime(dateOfBirth);
                    quote.CarYear = carYear;
                    quote.CarMake = carMake;
                    quote.CarModel = carModel;
                    quote.DUIStatus = duiStatus;
                    quote.SpeedingTicketNum = speedingTicketNum.ToString();
                    quote.TypeOfCoverage = typeOfCoverage;
                    Calculation result = new Calculation();
                    quote.CustomerQuote = result.CalculateQuote(firstName, lastName, emailAddress, dateOfBirth, carYear, carMake, carModel, duiStatus, speedingTicketNum, typeOfCoverage);

                    db.Quotes.Add(quote);
                    db.SaveChanges();

                    var displayQuoteVm = new DisplayQuoteVm();
                    displayQuoteVm.CustomerQuote = result.CalculateQuote(firstName, lastName, emailAddress, dateOfBirth, carYear, carMake, carModel, duiStatus, speedingTicketNum, typeOfCoverage);


                    return View("QuoteDisplay", displayQuoteVm);
                }
            }
        }
    }
}