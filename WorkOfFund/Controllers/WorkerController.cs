using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkOfFund.Models;
using System.Globalization;
using System.Threading;

namespace WorkOfFund.Controllers
{
    public class WorkerController : Controller
    {
        // GET: Worker
        public ActionResult Index()
        {
            FundWorkEntities db = new FundWorkEntities();
            List<Worker> workerlist = db.Worker.ToList();
            WorkerViewModel workerVM = new WorkerViewModel();
            List<WorkerViewModel> workerVMList = workerlist.Select(x => new WorkerViewModel
            {
                worker_id = x.worker_id,
                worker_name = x.worker_name,
                worker_surname = x.worker_surname,
                worker_login = x.worker_login,
                wposition_id = x.wposition_id,
                position_name = x.Position.position_name,
                worker_password = x.worker_password,
                wfund_id = x.wfund_id
            }).ToList();

            return View(workerVMList);
        }
        public ActionResult WorkerDetails(int worker_id)
        {
            FundWorkEntities db = new FundWorkEntities();
            Worker worker = db.Worker.SingleOrDefault(x => x.worker_id == worker_id);
            WorkerViewModel workerVM = new WorkerViewModel();
            workerVM.worker_id = worker.worker_id;
            workerVM.worker_name = worker.worker_name;
            workerVM.worker_surname = worker.worker_surname;
            workerVM.worker_login = worker.worker_login;
            workerVM.worker_password = worker.worker_password;
            workerVM.wfund_id = worker.wfund_id;
            workerVM.wposition_id = worker.wposition_id;
            workerVM.position_name = worker.Position.position_name;
            return View(workerVM);
        }
        //Add worker
        [HttpGet]
        public ActionResult AddWorker()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWorker(WorkerViewModel model)
        {
            if (ModelState.IsValid)
            {
                FundWorkEntities db = new FundWorkEntities();
                int lastWorkerId = db.Worker.Max(item => item.worker_id);
                Worker worker = new Worker();
                worker.worker_id = lastWorkerId + 1;
                worker.worker_name = model.worker_name;
                worker.worker_surname = model.worker_surname;
                worker.worker_login = model.worker_login;
                worker.worker_password = model.worker_password;
                worker.wposition_id = 2;
                worker.wfund_id = 1;

                db.Worker.Add(worker);
                db.SaveChanges();

                return RedirectToAction("Index", "Worker");
            }
            return View(model);
        }

        //Update
        [HttpPost]
        public ActionResult UpdateWorker(Worker worker)
        {
            FundWorkEntities db = new FundWorkEntities();
            using (db)
            {
                Worker uworker = (from w in db.Worker
                                           where w.worker_id == worker.worker_id
                                           select w).FirstOrDefault();
                uworker.worker_name = worker.worker_name;
                uworker.worker_surname = worker.worker_surname;
                uworker.worker_login = worker.worker_login;
                db.SaveChanges();
            }
            return new EmptyResult();
        }
        //Delete
        [HttpPost]
        public ActionResult DeleteWorker(int worker_id)
        {
            FundWorkEntities db = new FundWorkEntities();
            using (db)
            {
                Worker dworker = (from w in db.Worker
                                  where w.worker_id == worker_id
                                  select w).FirstOrDefault();
                db.Worker.Remove(dworker);
                db.SaveChanges();
            }
            return new EmptyResult();
        }
    }
}