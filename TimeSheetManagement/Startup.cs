using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeSheetManagement.Startup))]
namespace TimeSheetManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
