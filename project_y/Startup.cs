using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(project_y.Startup))]
namespace project_y
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
