using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Web.Http.Cors;

[assembly: OwinStartup(typeof(TreningsdagbokRest.App_Start.Startup))]
namespace TreningsdagbokRest.App_Start
{

    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder app)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            AutoMapperConfiguration.Configure();
            Mapper.AssertConfigurationIsValid();

            var builder = new ContainerBuilder();
            AutofacSetup.RegisterDependencies(ref builder);
            var container = builder.Build();

            var corsAttr = new EnableCorsAttribute("*", "*", "*");

            config.EnableCors(corsAttr);

            app.UseWebApi(config);
            app.UseAutofacWebApi(config);
        }
    }
}