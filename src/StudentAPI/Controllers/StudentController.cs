using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController:ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"this", "is", "hard", "coded"};
        }

    }
}