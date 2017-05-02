using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using ThorAPI;
using Owin;
using System.Web.Http;
using Microsoft.Owin.Cors;


[assembly:OwinStartup(typeof(Startup))]
namespace ThorAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            ConfigureAuthZero(app);
            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);

        }      
    }  
}