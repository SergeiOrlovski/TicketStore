using System;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketStore.Web.Startup))]
namespace TicketStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}
