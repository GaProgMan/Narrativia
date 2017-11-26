using Microsoft.AspNetCore.Mvc;
using Narrativia.Services;

namespace Narrativia.Ui.Api
{
    [Route("/api/[controller]")]
    public class PagesController : BaseApiController
    {
        private readonly IPageService _pageService;

        public PagesController(IPageService pageService)
        {
            _pageService = pageService;
        }
        
        [HttpGet("Home")]
        public JsonResult Home()
        {
            var page = _pageService.GetPage(1);
            return page == null
                ? ErrorResponse()
                : SingleResult(page);
        }
    }
}