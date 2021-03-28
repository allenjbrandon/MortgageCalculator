using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MortgageCalculator.Models
{
    public class Rate
    {
        public Record Record { get; set; }
    }

    public class Record
    {
        public double Rates { get; set; }
    }

}
