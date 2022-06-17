using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Malupitang_Final_Projet_Group_4.Startup))]
namespace Malupitang_Final_Projet_Group_4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
