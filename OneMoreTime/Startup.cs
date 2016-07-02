using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneMoreTime.Startup))]
namespace OneMoreTime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
