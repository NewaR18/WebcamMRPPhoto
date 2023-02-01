using Operation.DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCamPopup.Controllers
{
    public class CamController : Controller
    {
        public DLL _dll;
        public CamController()
        {
            _dll = new DLL();
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SaveCapturedImage(string data)
        {
            return Json(new { Name = _dll.InsertImage(data) }, JsonRequestBehavior.AllowGet);
        }
    }
}