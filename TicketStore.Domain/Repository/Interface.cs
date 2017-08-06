using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TicketStore.Domain.DbContext;

namespace TicketStore.Domain.Repository
{
    public interface IDataVoyageRepository : IDisposable
    {
        IQueryable<VoyageData> SearchTicket(VoyageData model);
    }
}
