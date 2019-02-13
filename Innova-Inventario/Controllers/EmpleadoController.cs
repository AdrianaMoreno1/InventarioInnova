using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Innova_Inventario.Models;



namespace Innova_Inventario.Controllers
{
    public class EmpleadoController : Controller
    {
        //
        // GET: /Empleado/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            using (DBModel db = new DBModel())
            {
               // List<empleado> empList = db.empleado.ToList<empleado>();
                List<empleado> empList = db.empleado.Where(e => e.id_empleado >= 1).ToList();
                return Json(new{data=empList},JsonRequestBehavior.AllowGet);
            }

        }

        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new empleado());
            else
            {
                using (DBModel db = new DBModel())
                {
                    return View(db.empleado.Where(x => x.id_empleado == id).FirstOrDefault<empleado>());
                }
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(empleado emp)
        {
            using (DBModel db = new DBModel())
            {
                if (emp.id_empleado == 0)
                {
                    db.empleado.Add(emp);
                    db.SaveChanges();
                    return Json(new { success = true, message = "Saved Successfully" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    db.Entry(emp).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                    return Json(new { success = true, message = "Updated Successfully" }, JsonRequestBehavior.AllowGet);
                }
            }


        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (DBModel db = new DBModel())
            {
                empleado emp = db.empleado.Where(x => x.id_empleado == id).FirstOrDefault<empleado>();
                db.empleado.Remove(emp);
                db.SaveChanges();
                return Json(new { success = true, message = "Deleted Successfully" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
