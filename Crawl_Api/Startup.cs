using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Crawl_Api.Startup))]
namespace Crawl_Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
