using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketStore.Web.Models
{
    public class CartViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}