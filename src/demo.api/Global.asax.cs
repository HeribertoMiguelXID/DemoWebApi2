using demo.api.App_Start;
using System.Web.Http;

namespace demo.api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutofacWebapiConfig.Initialize(GlobalConfiguration.Configuration);
        }
    }
}
