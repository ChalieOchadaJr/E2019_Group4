using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RenttoRideFP.Startup))]
namespace RenttoRideFP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
