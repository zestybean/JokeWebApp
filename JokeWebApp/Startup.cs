using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JokeWebApp.Startup))]
namespace JokeWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
