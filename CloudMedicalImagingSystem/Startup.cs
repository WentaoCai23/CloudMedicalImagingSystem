using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudMedicalImagingSystem.Startup))]
namespace CloudMedicalImagingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
