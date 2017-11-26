using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Narrativia.DTO;

namespace Narrativia.Ui.Api
{
    [Route("/api")]
    public class BaseApiController : Controller
    {
        protected JsonResult ErrorResponse(string message = "Not Found")
        {
            return Json (new {
                Success = false,
                Result = message
            });
        }

        protected JsonResult MessageResult(string message, bool success = true)
        {
            return Json(new {
                Success = success,
                Result = message
            });
        }

        protected JsonResult SingleResult(BaseDto singleResult)
        {
            return Json(new {
                Success = true,
                Result = singleResult
            });
        }

        protected JsonResult MultipleResults(IEnumerable<BaseDto> multipleResults)
        {
            return Json(new {
                Success = true,
                Result = multipleResults
            });
        }

        [HttpGet("Version")]
        public string Version()
        {
            return Assembly.GetEntryAssembly()
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                .InformationalVersion;
        }

        [HttpGet("About")]
        public JsonResult About()
        {
            // TODO get this information from a service (i.e. from the db)
            return MessageResult(
                @"<p>Welcome to my blogging platform. I call it Narrativia</p><p>Not to be confused with the Production company of the same name, but it does have the <a href='https://wiki.lspace.org/mediawiki/Narrativia_(goddess)' target='_blank' rel='noopener'>same root</a></p>");
        }
    }
}