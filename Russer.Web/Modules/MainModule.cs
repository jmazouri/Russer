using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace Russer.Web.Modules
{
    public class MainModule : NancyModule
    {
        public MainModule()
        {
            Get["/"] = x => View["Home", new { User = Context.CurrentUser?.UserName ?? "Nobody" }];
        }
    }
}
