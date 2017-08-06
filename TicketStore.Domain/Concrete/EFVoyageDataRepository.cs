using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketStore.Domain.Abstract;
using TicketStore.Domain.DbContext;

namespace TicketStore.Domain.Concrete
{
    public class EFVoyageDataRepository : IVoyageDataRepository
    {
        StoreTicketDb context = new StoreTicketDb();

        public string GetArrivalBusStop(string name)
        {
            return null;//context.VoyageDatas.Where(w => w.BusStop1.ToString() == name).Select(s => s);
        }

        public IEnumerable<VoyageData> GetBusStopDepartureDateTime(DateTime datatime)
        {
            return context.VoyageDatas.Where(w => w.DepartureDateTime == datatime).Select(s=>s);
        }

        public string GetDepartureBusStop(string name)
        {
            return context.VoyageDatas.Where(w => w.BusStop.ToString() == name).Select(s => s).ToString();
        }

        public IEnumerable<VoyageData> VoyageDatas
        {
            get { return context.VoyageDatas; }
            
        }
    }
}
