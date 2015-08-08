using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.SimpleAuthentication;
using Nancy.TinyIoc;
using Russer.Shared.App;
using Russer.Web.App.Auth;
using SimpleAuthentication.Core;
using SimpleAuthentication.Core.Providers;

namespace Russer.Web.App
{
    public class RusserBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            var googleProvider = new GoogleProvider(new ProviderParams
            {
                PublicApiKey = GlobalConfig.GoogleConsumerKey,
                SecretApiKey = GlobalConfig.GoogleConsumerSecret
            });

            var authenticationProviderFactory = new AuthenticationProviderFactory();

            authenticationProviderFactory.AddProvider(googleProvider);
            
            container.Register<IAuthenticationCallbackProvider>(new RusserAuthenticationCallbackProvider());
        }
    }
}
