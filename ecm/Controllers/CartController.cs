using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ecm.Models;

namespace ecm.Controllers
{
    public class CartController : Controller
    {
        //
        // GET: /Cart/
        private ecm.Models.ecmEntities2 db = new ecm.Models.ecmEntities2();

        public ActionResult Cart()
        {
            ViewBag.title = "Cart";
            return View();
        }

        private int isExisting(int id)
        {
            List<Product> cart = (List<Product>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Prod.Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public ActionResult Delete(int id)
        {
            int index = isExisting(id);
            List<Product> cart = (List<Product>)Session["cart"];
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return View("cart");
        }

        public ActionResult OrderNow(int id)
        {
            if (Session["cart"] == null)
            {
                List<Product> cart = new List<Product>();
                cart.Add(new Product(db.items.Find(id), 1));
                Session["cart"] = cart;
            }
            else
            {
                List<Product> cart = (List<Product>)Session["cart"];
                int index = isExisting(id);
                if (index == -1)
                {
                    cart.Add(new Product(db.items.Find(id), 1));
                }
                else
                {
                    cart[index].Quantity++;
                }
                
                Session["cart"] = cart;
            }

            return View("Cart");
        }

        public ActionResult CheckoutBefore()
        {
            ViewBag.title = "Authentication";
            return View();
        }

        public ActionResult Step1()
        {
            ViewBag.title = "Step1";
            return View();
        }

        public ActionResult Step2()
        {
            ViewBag.title = "Step2";
            return View();
        }

        public ActionResult Step3()
        {
            ViewBag.title = "Step3";
            return View();
        }

        public ActionResult Step4()
        {
            ViewBag.title = "Step4";
            return View();
        }

        public ActionResult Step5()
        {
            ViewBag.title = "Step5";
            return View();
        }

        public ActionResult ThanksForOrder()
        {
            ViewBag.title = "Thanks For Order";
            return View();
        }

    }
}
