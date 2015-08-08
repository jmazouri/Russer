using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using Russer.Shared.App;
using Russer.Web.App;
using Russer.Web.App.Service;
using Topshelf;

namespace Russer.Web
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<ServiceStarter>(s =>
                {
                    s.ConstructUsing(name => new ServiceStarter());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetDescription("Russer Web App");
                x.SetDisplayName("Russer");
                x.SetServiceName("Russer");
            });
        }
    }
}
