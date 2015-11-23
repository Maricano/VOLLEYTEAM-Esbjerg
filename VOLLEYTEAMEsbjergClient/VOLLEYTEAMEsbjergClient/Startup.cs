using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VOLLEYTEAMEsbjergClient.Startup))]
namespace VOLLEYTEAMEsbjergClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
