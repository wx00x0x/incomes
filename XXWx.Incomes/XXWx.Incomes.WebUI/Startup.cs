using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XXWx.Incomes.WebUI.Startup))]
namespace XXWx.Incomes.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
