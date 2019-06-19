using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Learn_combining_WebAPI_with_MVC.Startup))]
namespace Learn_combining_WebAPI_with_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
