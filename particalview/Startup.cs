using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(particalview.Startup))]
namespace particalview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
