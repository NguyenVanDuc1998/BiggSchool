using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BiggSchool.Startup))]
namespace BiggSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
