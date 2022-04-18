namespace LiskovDemo.AbstractionDemo.Controllers
{
    using global::LiskovDemo.AbstractionDemo.Abstractions;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class LegacyServiceAdapterController : ControllerBase
    {
        // GET: api/<NewServiceAdapterController>
        [HttpGet]
        public UserAbstraction Get()
        {
            var adapter = new LegacyServiceAdapter();

            var userAbstraction = adapter.GetUser();

            return userAbstraction;
        }
    }
}
