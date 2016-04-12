using Nancy;

namespace NancyBlogDemo.Modules
{
    public class AdminModule : NancyModule
    {
        public AdminModule(WebApplicationService webApplicationService):base("/admin")
        {
            Get["/"] = parameters => {
                var model = new Views.Admin.Models.IndexModel
                {
                    CreationDate = webApplicationService.GetCreationDate(),
                    TotalRequests = webApplicationService.TimesRequested()
                };

                return View["Index", model];
            };
        }
    }
}