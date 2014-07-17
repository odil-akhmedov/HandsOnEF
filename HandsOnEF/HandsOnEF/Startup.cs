using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HandsOnEF.Startup))]
namespace HandsOnEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
