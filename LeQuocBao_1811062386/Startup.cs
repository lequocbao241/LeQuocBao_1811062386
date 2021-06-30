using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeQuocBao_1811062386.Startup))]
namespace LeQuocBao_1811062386
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
