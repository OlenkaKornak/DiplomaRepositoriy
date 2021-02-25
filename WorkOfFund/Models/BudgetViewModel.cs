using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkOfFund.Models;
using System.ComponentModel.DataAnnotations;

namespace WorkOfFund.Models
{
    public class BudgetViewModel
    {
        public int fundbudget_id { get; set; }
        public Nullable<int> fondbudget_sum { get; set; }
        public string fundbudget_baccount { get; set; }
        public int ffund_id { get; set; }
    }
}