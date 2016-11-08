using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViajaNet.Produto.Web.Startup))]
namespace ViajaNet.Produto.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
