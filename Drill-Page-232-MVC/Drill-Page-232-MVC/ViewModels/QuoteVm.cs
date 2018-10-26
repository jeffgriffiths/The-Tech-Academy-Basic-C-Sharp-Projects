using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Drill_Page_232_MVC.ViewModels
{
    public class QuoteVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string DUIStatus { get; set; }
        public int  SpeedingTicketNum { get; set; }
        public string TypeOfCoverage { get; set; }
        public string CustomerQuote { get; set; }
    }
}