using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketStore.Domain.DbContext;

namespace TicketStore.Domain.Abstract
{
    public interface IBusStopRepository
    {
        IEnumerable<BusStop> GetAllBusStops { get; }
        string GetBusStopName(string n);
    }

}
