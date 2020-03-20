using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutionClassManagementSystem.Startup))]
namespace TutionClassManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
