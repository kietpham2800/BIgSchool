using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewPJ.Startup))]
namespace NewPJ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
