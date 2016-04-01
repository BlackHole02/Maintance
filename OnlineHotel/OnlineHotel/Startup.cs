using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineHotel.Startup))]
namespace OnlineHotel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
