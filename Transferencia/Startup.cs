using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Transferencia.Startup))]
namespace Transferencia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
