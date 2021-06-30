using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bai1Book.Startup))]
namespace Bai1Book
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
