using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContractProcessingApp.Startup))]
namespace ContractProcessingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
