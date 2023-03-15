using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhamGiaHuy_2011062154.Startup))]
namespace PhamGiaHuy_2011062154
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
