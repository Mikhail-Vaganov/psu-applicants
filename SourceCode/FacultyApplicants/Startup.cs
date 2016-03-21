using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacultyApplicants.Startup))]
namespace FacultyApplicants
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
