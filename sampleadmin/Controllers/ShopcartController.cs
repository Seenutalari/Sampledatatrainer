using sampleadmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.UI.WebControls;

namespace sampleadmin.Controllers
{
    public class ShopcartController : Controller
    {
        public ActionResult Cart()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cart(int id, int cd)
        {

            projectEntities db = new projectEntities();
            customer c = db.customers.Find(cd);
            product p = db.products.Find(id);
            cart o = new cart();
            if (p == null || c == null)
            {

                return HttpNotFound();
            }
            else if (p != null && c != null)
            {
                o.p_id = p.p_id;
                o.cid = c.cid;
                o.oname = p.pname;
                o.oimage = p.p_image;
                o.oprice = p.price;

                db.carts.Add(o);
                db.SaveChanges();
            }
            return View();
        }

        public ActionResult Display(int id)
        {
            projectEntities db = new projectEntities();
            cart p = db.carts.Find(id);
            if (p == null)
            {
                return HttpNotFound();
            }
            return View(p);

        }
    }

    //public ActionResult Index(int id)
    //{
    //    // Retrieve cart items and calculate total price
    //    List<cart> cartItems = GetCartItemsFromDatabase(id);
    //    int? totalPrice = cartItems.Sum(item => item.oprice);

    //    // Pass data to the view
    //    ViewBag.CartItems = cartItems;
    //    ViewBag.TotalPrice = totalPrice;

    //    return View();
    //}
    //public List<cart> GetCartItemsFromDatabase(int id)
    //{
    //    List<cart> cartItems = new List<cart>();

    //    // Assuming you have a database context named "YourDbContext"
    //    using (projectEntities dbContext = new projectEntities())
    //    {
    //        // Retrieve cart items based on the user's session or user ID
    //        List<product> cartItemEntities = dbContext.products.Where(x=> x.p_id==id).ToList();

    //        // Map the retrieved entities to CartItem model
    //        foreach (var cartItemEntity in cartItemEntities)
    //        {
    //            cart cartItem = new cart
    //            {
    //                oid = cartItemEntity.p_id,
    //                oimage = cartItemEntity.p_image,
    //                oname = cartItemEntity.pname,
    //                oprice = cartItemEntity.price,

    //            };
    //            cartItems.Add(cartItem);
    //            dbContext.SaveChanges();
    //        }
    //    }

    //    return cartItems;
    //}

    // Other actions for adding/removing items from the cart
    
}