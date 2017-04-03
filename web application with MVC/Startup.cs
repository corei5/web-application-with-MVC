using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web_application_with_MVC.Startup))]
namespace web_application_with_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
