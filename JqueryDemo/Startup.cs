using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JqueryDemo.Startup))]
namespace JqueryDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
