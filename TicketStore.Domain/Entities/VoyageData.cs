using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketStore.Domain.Entities
{
    public class VoyageData
    {
        public int VoyageId { get; set; }
        public int DepartureStopId { get; set; }
        public int ArrivalStopId { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public DateTime TravelTime { get; set; }
        public int VoyageNumber { get; set; }
        public string VoyageName { get; set; }
        public int NumberSeats { get; set; }
        public decimal TicketCoast { get; set; }

        public BusStop BusStop { get; set; }
    }
}
