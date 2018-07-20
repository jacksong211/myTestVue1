using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vuejs.Startup))]
namespace vuejs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
