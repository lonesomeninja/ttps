using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrungPetStore.Startup))]
namespace TrungPetStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
