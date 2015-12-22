using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SingleCodeFirst.Startup))]
namespace SingleCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
