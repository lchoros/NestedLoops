using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RatingSystemWeb.Startup))]
namespace RatingSystemWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
