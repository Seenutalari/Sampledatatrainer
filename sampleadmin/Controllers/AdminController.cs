using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sampleadmin.Models;
using System.IO;

namespace sampleadmin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(product pro)
        {
            string fileName = Path.GetFileNameWithoutExtension(pro.ImageFile.FileName);
            string extension = Path.GetExtension(pro.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            pro.p_image = "~/Image/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
            pro.ImageFile.SaveAs(fileName);
            using (projectEntities db = new projectEntities())
            {
                db.products.Add(pro);
                db.SaveChanges();
            }
            ModelState.Clear();

            

            return View();
        }
      
    }
}