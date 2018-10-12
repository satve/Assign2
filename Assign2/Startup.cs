using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assign2.Startup))]
namespace Assign2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
