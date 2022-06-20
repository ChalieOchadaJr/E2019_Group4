using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentoRide.Startup))]
namespace RentoRide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
