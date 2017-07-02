using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MingMVC02.Startup))]
namespace MingMVC02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
