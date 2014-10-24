using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRijschool.Startup))]
namespace MVCRijschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
