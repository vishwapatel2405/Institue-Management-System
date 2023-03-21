using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Institue_MS.Startup))]
namespace Institue_MS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
