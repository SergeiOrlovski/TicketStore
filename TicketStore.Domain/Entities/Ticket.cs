using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketStore.Domain.Entities
{
    public class Ticket
    {
        public int? Id { get; set; }
        public int? OrderId { get; set; }
        public string PassengerFirstName { get; set; }
        public string PassengerLastNAme { get; set; }
        public int? PassengerDocNumber { get; set; }
        public int? PassengerSeatNumber { get; set; }
        public short? Status { get; set; }
    }
}
