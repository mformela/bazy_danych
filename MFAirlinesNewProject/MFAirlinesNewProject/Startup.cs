using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MFAirlinesNewProject.Startup))]
namespace MFAirlinesNewProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
