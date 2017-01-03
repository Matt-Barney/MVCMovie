using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVcMovie.Startup))]
namespace MVcMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
