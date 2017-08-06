using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using TicketStore.Domain.DbContext;
using TicketStore.Web.Models;
using Microsoft.AspNet.Identity;

namespace TicketStore.Web.Controllers
{
    //[RequireHttps]
    //[Authorize]
    public class CartController : Controller
    {
        public CartController()
        {
            StoreTicketDb db = new StoreTicketDb();
        }

        [HttpGet]
        [Authorize]
        public ActionResult SearchTicket()
        {
            //var busStop = ViewData["BusStop"];
            //var busStop1 = ViewData["BusStop1"];

            return View();
        }

        [HttpPost]
        //[Authorize]
        public ActionResult SearchTicket(BuyModelTicket model)
        {
            StoreTicketDb db = new StoreTicketDb();
            var result = db.VoyageDatas.Where(w => w.BusStop.Name == model.BusStop || w.BusStop1.Name == model.BusStop1).Select(s => s);

            //ViewData["BusStop"] = model.BusStop;
            //ViewData["BusStop1"] = model.BusStop1;

            ViewBag.Result = result;
            return View();
        }

        //[Authorize]
        public RedirectToRouteResult AddToCart(Cart cart, string returnUrl)
        {
            StoreTicketDb db = new StoreTicketDb();
            var voyageId = RouteData.Values["id"];
            VoyageData voyage = db.VoyageDatas
                .FirstOrDefault(g => g.VoyageID.ToString() == voyageId);
            if (voyage != null)
            {
                GetCart().AddItem(voyage, 1);
            }
            ViewBag.Message = "Ticket has been reserved!";
            return RedirectToAction("SearchTicket", new { returnUrl });
        }

        //[Authorize]
        public RedirectToRouteResult RemoveFromCart(Cart cart, int voyageId, string returnUrl)
        {
            StoreTicketDb db = new StoreTicketDb();
            VoyageData voyage = db.VoyageDatas
                .FirstOrDefault(g => g.VoyageID == voyageId);

            if (voyage != null)
            {
                GetCart().RemoveLine(voyage);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        //[Authorize]
        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        [Authorize]
        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        //[Authorize]
        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }


    }

}
