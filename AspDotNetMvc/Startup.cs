using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspDotNetMvc.Startup))]
namespace AspDotNetMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
