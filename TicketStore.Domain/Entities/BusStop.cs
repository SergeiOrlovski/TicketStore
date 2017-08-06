using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketStore.Domain.Entities
{
    public class BusStop
    {
        public int? BusStopId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StatusStop { get; set; }

        //navigation property
        public virtual ICollection<VoyageData> VoyageData1 { get; set; }
        public virtual ICollection<VoyageData> VoyageData2 { get; set; }

        public BusStop()
        {
            VoyageData1 = new HashSet<VoyageData>();
            VoyageData2 = new HashSet<VoyageData>();
        }

    }
}
