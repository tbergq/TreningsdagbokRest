using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
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
            //// Configure Web API for self-host. 
            //HttpConfiguration config = new HttpConfiguration();
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //AutoMapperConfiguration.Configure();
            //Mapper.AssertConfigurationIsValid();

            //var builder = new ContainerBuilder();
            //AutofacSetup.RegisterDependencies(ref builder);
            //var container = builder.Build();

            //var corsAttr = new EnableCorsAttribute("*", "*", "*");

            //config.EnableCors(corsAttr);

            //app.UseWebApi(config);
            //app.UseAutofacWebApi(config);

            ConfigureOAuth(app);
            AutoMapperConfiguration.Configure();
            Mapper.AssertConfigurationIsValid();
            var builder = new ContainerBuilder();

            HttpConfiguration config = new HttpConfiguration();
            config.Filters.Add(new AuthorizeAttribute());
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            WebApiConfig.Register(config);


            AutofacSetup.RegisterDependencies(ref builder);
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }
}