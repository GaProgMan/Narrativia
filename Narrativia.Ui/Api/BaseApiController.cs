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
        public JsonResult Version()
        {
            return Json(new
            {
                Success = true,
                Result = Assembly.GetEntryAssembly()
                    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                    .InformationalVersion
            });
        }
    }
}