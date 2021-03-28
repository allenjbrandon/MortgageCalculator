using MortgageCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MortgageCalculator.Controllers
{
    public class BudgetController : Controller
    {
        // GET: Budget
        public async Task<ActionResult> Budget()
        {
            double interestRate = await RateProcessor.LoadRate();

            ViewData["InterestRate"] = interestRate;

            return View();
        }
    }
}