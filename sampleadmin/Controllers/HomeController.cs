using PagedList;
using sampleadmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;


namespace sampleadmin.Controllers
{
    public class HomeController : Controller
    {
        projectEntities db = new projectEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
        public ActionResult Men(int? Page_No)
        {
            List<product> p = db.products.Where(pr => pr.cat_id == 1).ToList();
            int Size_Of_Page = 4;
            int No_Of_Page = (Page_No ?? 1);
            return View(p.ToPagedList(No_Of_Page, Size_Of_Page));


        }
        public ActionResult Women(int? Page_No)
        {

            List<product> p = db.products.Where(pr => pr.cat_id ==2 ).ToList();
            int Size_Of_Page = 4;
            int No_Of_Page = (Page_No ?? 1);
            return View(p.ToPagedList(No_Of_Page, Size_Of_Page));
        }
        public ActionResult Kids(int? Page_No)
        {
            List<product> p = db.products.Where(pr => pr.cat_id == 3).ToList();
            int Size_Of_Page = 4;
            int No_Of_Page = (Page_No ?? 1);
            return View(p.ToPagedList(No_Of_Page, Size_Of_Page));
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup(customer c)
        {
            if (ModelState.IsValid)
            {
                db.customers.Add(c);
                db.SaveChanges();
                return View(c);
            }
            return View(c);
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(customer c)
        {
            if (ModelState.IsValid)
            {
                var log = db.customers.FirstOrDefault(a => a.username.Equals(c.username, StringComparison.OrdinalIgnoreCase) && a.password.Equals(c.password));
                if (log != null)
                {
                    TempData["Message"] = "Login successful!";
                    return RedirectToAction("Search","Home");
                }


                
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password.");
                
                return View(c);
            }

            return View(c);
        }
        public ActionResult AdR()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdR(admin a)
        {
            if (ModelState.IsValid)
            {
                db.admins.Add(a);
                db.SaveChanges();
                return View(a);
            }
            return View(a);
        }
        public ActionResult AdLogin()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdLogin(admin a)
        {
            if (ModelState.IsValid)
            {
                var log = db.admins.FirstOrDefault(x => x.aname.Equals(a.aname, StringComparison.OrdinalIgnoreCase) && x.apassword.Equals(a.apassword));
                if (log != null)
                {
                    TempData["Message"] = "Login successful!";
                    return RedirectToAction("Add", "Admin");
                }

                ModelState.AddModelError("", "Invalid username or password.");
            }
            return View(a);
        }
        public ActionResult Details(int id)
        {
            projectEntities db = new projectEntities();
            product p = db.products.Find(id);
            if (p == null)
            {
                return HttpNotFound();
            }
            return View(p);
        }
        
        public ActionResult Search(string Sorting_Order, string Search_Data, int? Page_No)
        {
            ViewBag.CurrentSortOrder = Sorting_Order;
            ViewBag.SortingName = String.IsNullOrEmpty(Sorting_Order) ? "Name_Description" : "";


            ViewBag.FilterValue = Search_Data;

            var pr = from product in db.products select product;

            if (!String.IsNullOrEmpty(Search_Data))
            {
                pr = pr.Where(product => product.pname.Contains(Search_Data));
            }
            switch (Sorting_Order)
            {
                case "Name_Description":
                    pr = pr.OrderByDescending(product => product.pname);
                    break;

                default:
                    pr = pr.OrderBy(product => product.pname);
                    break;
            }

            int Size_Of_Page = 4;
            int No_Of_Page = (Page_No ?? 1);
            return View(pr.ToPagedList(No_Of_Page, Size_Of_Page));

        }
        

    }
    
}