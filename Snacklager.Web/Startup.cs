using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Snacklager.Web.Startup))]

namespace Snacklager.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
