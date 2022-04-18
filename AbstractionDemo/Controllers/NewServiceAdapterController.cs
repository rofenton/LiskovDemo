// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LiskovDemo.AbstractionDemo.Controllers
{
    using global::LiskovDemo.AbstractionDemo.Abstractions;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class NewServiceAdapterController : ControllerBase
    {
        // GET: api/<NewServiceAdapterController>
        [HttpGet]
        public UserAbstraction Get()
        {
            var adapter = new NewServiceAdapter();

            var userAbstraction = adapter.GetUser();

            return userAbstraction;
        }
    }
}
