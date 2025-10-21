using MechanicAppWebBased.BusinessEntities.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MechanicAppWebBased.Controllers
{
    public class MaintenanceController : Controller
    {
        Maintenance ObjMain = new Maintenance();
        // GET: Maintenance
        public ActionResult NewRequest()
        {
            return PartialView();
        }
        public ActionResult RetriveMachineUnscheduleStatus()
        {
            return Json(ObjMain.RetriveMachineUnscheduleStatus(1), JsonRequestBehavior.AllowGet);
        }
        public ActionResult SaveUnScheduleMaintenance()
        {
            bool Started = true;
            bool Ended = false;
            return Json(ObjMain.SaveUnScheduleMaintenance(2, 387, Started, Ended), JsonRequestBehavior.AllowGet);
        }
        public ActionResult UpdateUnscheduleMaintenance()
        {
            bool Ended = true;
            return Json(ObjMain.UpdateUnscheduleMaintenance(1, Ended), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ViewForm()
        {
            return PartialView();
        }
        public ActionResult RetriveDataTable()
        {
            return Json(ObjMain.RetriveDataTable(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult MachineHistory()
        {
            return PartialView();
        }
        public ActionResult RetriveMachineHistory()
        {
            return Json(ObjMain.RetriveMachineHistory(), JsonRequestBehavior.AllowGet);
        }
    }
}