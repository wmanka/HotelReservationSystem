using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelReservationSystem.Startup))]
namespace HotelReservationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
