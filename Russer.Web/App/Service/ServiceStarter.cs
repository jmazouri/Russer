using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using Russer.Shared.App;

namespace Russer.Web.App.Service
{
    public class ServiceStarter
    {
        private IDisposable _webapp;

        public void Start()
        {
            LoggingExtensions.Logging.Log.InitializeWith<LoggingExtensions.NLog.NLogLog>();
            Stop();
            
            this.Log().Info("Starting OWIN Webapp with url {0}", GlobalConfig.Url);

            _webapp = WebApp.Start<Startup>(GlobalConfig.Url);
        }

        public void Stop()
        {
            this.Log().Info("Stopping OWIN Webapp...", GlobalConfig.Url);
            _webapp?.Dispose();
        }
    }
}
