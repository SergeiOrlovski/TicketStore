using System.Collections.Generic;
using System.Linq;
using TicketStore.Domain.Abstract;
using TicketStore.Domain.DbContext;

namespace TicketStore.Domain.Concrete
{
    public class EFBusStopRepository : IBusStopRepository
    {
        StoreTicketDb context = new StoreTicketDb();
        public IEnumerable<BusStop> GetAllBusStops
        {
            get { return context.BusStops; }
        }

        public string GetBusStopName(string name)
        {
            return context.BusStops.Where(w => w.Name == name).Select(s => s).ToString();
        }
    }
}
