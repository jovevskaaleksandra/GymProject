using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymProject.Startup))]
namespace GymProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
