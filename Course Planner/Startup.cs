using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Course_Planner.Startup))]
namespace Course_Planner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
