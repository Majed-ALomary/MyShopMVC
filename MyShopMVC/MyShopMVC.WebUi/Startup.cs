using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopMVC.WebUi.Startup))]
namespace MyShopMVC.WebUi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
