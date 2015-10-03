using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MsgBoard.Startup))]
namespace MsgBoard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
