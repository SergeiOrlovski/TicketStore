using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using TicketStore.Domain.DbContext;
using System.Threading.Tasks;
using System.Web.Mvc.Html;
using System.Web.Routing;
using Microsoft.AspNet.Identity;
using TicketStore.Web.Models;

namespace TicketStore.Web.Controllers
{
    //[RequireHttps]
    public class HomeController : Controller
    {
        private string userid;
        //private int orderid;
        //private int voyageid;
        
        
        //[HttpGet]
        public ActionResult Reservation()
        {
            //ViewBag.voyageId1 = RouteData.Values["id"];
            //Response.Cookies.Add(new HttpCookie("voyageId", RouteData.Values["id"]?.ToString()));
            return View();
        }

        [HttpPost]
        public ActionResult YesReservation(Ticket model)
        {
            StoreTicketDb db = new StoreTicketDb();           
            var voyageIdCookie = Request.Cookies["voyageId"];
            if (voyageIdCookie != null)
            {
                voyageIdCookie.Expires = DateTime.Now.AddHours(-1);
            }
            var voyageId1 = Request.Params["voyageId1"];
            userid = HttpContext.GetOwinContext().Authentication.User.Identity.GetUserId();

            Ticket ticket = new Ticket
            {                
                VoyageID = Int32.Parse(voyageId1),
                PassengerFirstName = model.PassengerFirstName,
                PassengerLastName = model.PassengerLastName,
                PassengerDocNumber = model.PassengerDocNumber,
                PassengerSeatNumber = model.PassengerSeatNumber,
                Status = 1
                
            };
            Order order = new Order
            {
                VoyageID = ticket.VoyageID,
                Status = 1,
                UserId = userid,
            };
            //order.Tickets.Add(ticket);

            db.Tickets.Add(ticket);
            db.Orders.Add(order);
            db.SaveChanges();
            
            ViewBag.Message = "Ticket has been reserved!";
            return View();
        }

        public ActionResult Index()
        {

            return View();
        }

       
        [HttpGet]
        public ActionResult BuyTicket()
        {
            return  View();
        }

        [HttpPost]
        public ActionResult BuyTicket(BuyModelTicket model)
        {
            StoreTicketDb db = new StoreTicketDb();
            //IEnumerable<BusStop> busStops = db.BusStops;
            //ViewBag.BusStops = busStops;
            var result = db.VoyageDatas.Where(w => w.BusStop.Name==model.BusStop|| w.BusStop1.Name == model.BusStop1).Select(s=>s);
            ViewBag.Result = result;
            return View();
        }


        public ActionResult Orders()
        {
            ViewBag.Message = "Your orders.";

            return View();
        }
    }
}