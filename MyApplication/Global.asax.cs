namespace MyApplication
{
	public class MvcApplication : System.Web.HttpApplication
	{
		public MvcApplication():base()
		{

		}
		protected void Application_Start()
		{
			System.Web.Mvc.AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);
		}
	}
}
