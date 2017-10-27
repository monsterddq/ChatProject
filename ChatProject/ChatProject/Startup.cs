using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatProject.Startup))]
namespace ChatProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
