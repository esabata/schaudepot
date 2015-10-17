using System;
using System.Configuration;
using System.Reflection;
using System.Web.Http;
using Microsoft.Owin;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using Schaudepots.Api;
using Schaudepots.Api.Data;

[assembly: OwinStartup(typeof(Startup))]
namespace Schaudepots.Api
{
    public class Startup
    {
        private readonly Lazy<IKernel> kernel = new Lazy<IKernel>(() =>
        {
            var kernel = new StandardKernel();

            kernel.Load(Assembly.GetExecutingAssembly());

            kernel.Bind<IDbConnectionFactory>().To<SqlConnectionFactory>()
                .WithConstructorArgument(
                    "connectionString",
                    ConfigurationManager.ConnectionStrings[0].ConnectionString
                );

            kernel.Bind<ISlideRepository>().To<SlideRepository>();

            return kernel;
        });

        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            WebApiConfig.Register(config);

            app.UseNinjectMiddleware(() => kernel.Value).UseNinjectWebApi(config);
        }
    }
}
