using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewProjectImc.Startup))]
namespace NewProjectImc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
