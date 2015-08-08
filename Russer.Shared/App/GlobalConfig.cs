using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russer.Shared.App
{
    public static class GlobalConfig
    {
        public static string GoogleConsumerKey = ConfigurationManager.AppSettings["googleKey"];
        public static string GoogleConsumerSecret = ConfigurationManager.AppSettings["googleSecret"];
        public static string Url = ConfigurationManager.AppSettings["urlPath"];
    }
}
