using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenBinhMinh_Bigschool.Startup))]
namespace NguyenBinhMinh_Bigschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
