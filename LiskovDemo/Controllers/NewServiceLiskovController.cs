namespace LiskovDemo.LiskovDemo.Controllers
{
    using global::LiskovDemo.Services;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class NewServiceLiskovController : ControllerBase
    {
        private readonly INewService newService;

        public NewServiceLiskovController(INewService newService)
        {
            this.newService = newService;
        }

        // GET: api/<LegacyServiceLiskovController>
        [HttpGet]
        public User Get()
        {
            var user = this.newService.GetUser();

            return user;
        }
    }
}
