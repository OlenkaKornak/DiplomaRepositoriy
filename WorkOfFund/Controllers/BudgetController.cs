using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkOfFund.Models;

namespace WorkOfFund.Controllers
{
    public class BudgetController : Controller
    {
        // GET: Budget
        public ActionResult Index()
        {
            FundWorkEntities db = new FundWorkEntities();
            FundBudget fb = db.FundBudget.SingleOrDefault(x => x.fundbudget_id == 1);
            BudgetViewModel budgetVM = new BudgetViewModel();
            budgetVM.fundbudget_id = fb.fundbudget_id;
            budgetVM.fondbudget_sum = fb.fondbudget_sum;
            budgetVM.fundbudget_baccount = fb.fundbudget_baccount;
            budgetVM.ffund_id = fb.ffund_id;
            return View(budgetVM);
        }
        [HttpGet]
        public PartialViewResult Edit(int fundbudget_id)
        {
            FundWorkEntities db = new FundWorkEntities();
            FundBudget fb = db.FundBudget.Where(x => x.fundbudget_id == fundbudget_id).FirstOrDefault();
            BudgetViewModel budgetVM = new BudgetViewModel();
            budgetVM.fundbudget_id = fb.fundbudget_id;
            budgetVM.fondbudget_sum = fb.fondbudget_sum;
            budgetVM.fundbudget_baccount = fb.fundbudget_baccount;
            budgetVM.ffund_id = fb.ffund_id;
            return PartialView(budgetVM);
        }
        [HttpPost]
        public JsonResult Edit(FundBudget fbb)
        {
            FundWorkEntities db = new FundWorkEntities();
            FundBudget fb = db.FundBudget.Where(x => x.fundbudget_id == fbb.fundbudget_id).FirstOrDefault();
            BudgetViewModel budgetVM = new BudgetViewModel();
            fb.fundbudget_id = fbb.fundbudget_id;
            fb.fondbudget_sum = fbb.fondbudget_sum;
            db.SaveChanges();
            return Json(fb, JsonRequestBehavior.AllowGet);
        }
    }
}