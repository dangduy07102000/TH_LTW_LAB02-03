using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BT2_3_DANGNGUYENHOAIDUY.Startup))]
namespace BT2_3_DANGNGUYENHOAIDUY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
