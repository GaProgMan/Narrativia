using System.Linq;
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
        
        [HttpGet("{title}")]
        public JsonResult Get(string title)
        {
            var page = _pageService.GetPage(title);
            return page == null
                ? ErrorResponse()
                : SingleResult(page);
        }

        [HttpGet("PagesForHeader")]
        public JsonResult PagesForHeader()
        {
            var pages = _pageService.GetPagesForHeader().ToList();
            return pages.Any()
                ? MultipleResults(pages)
                : ErrorResponse();
        }
    }
}