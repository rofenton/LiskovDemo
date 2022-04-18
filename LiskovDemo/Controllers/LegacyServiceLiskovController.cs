// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LiskovDemo.LiskovDemo.Controllers
{
    using global::LiskovDemo.Services;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    [ApiController]
    public class LegacyServiceLiskovController : ControllerBase
    {
        private readonly ILegacyService legacyService;

        public LegacyServiceLiskovController(ILegacyService legacyService)
        {
            this.legacyService = legacyService;
        }

        // GET: api/<LegacyServiceLiskovController>
        [HttpGet]
        public dynamic Get()
        {
            var username = this.legacyService.GetUsername();

            var response = new
            {
                username = username,
                email = this.legacyService.GetUserEmail(username)
            };

            return response;
        }
    }
}
