using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiquorStore.Startup))]
namespace LiquorStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
