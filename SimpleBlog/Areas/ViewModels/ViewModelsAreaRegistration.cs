using System.Web.Mvc;

namespace SimpleBlog.Areas.ViewModels
{
    public class ViewModelsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ViewModels";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ViewModels_default",
                "ViewModels/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}