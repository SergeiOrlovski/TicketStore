using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketStore.Domain.DbContext;

namespace TicketStore.Domain.Abstract
{
    public interface IVoyageDataRepository
    {
        IEnumerable<VoyageData> VoyageDatas { get; }
        string GetDepartureBusStop(string name);
        string GetArrivalBusStop(string name);
        IEnumerable<VoyageData> GetBusStopDepartureDateTime(DateTime datetime);
    }
}
