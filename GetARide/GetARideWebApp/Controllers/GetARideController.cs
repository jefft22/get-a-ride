namespace GetARideWebApp.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using GetARideService;
    using GetARideService.Managers.Models;


    [Route("[controller]")]
    [ApiController]
    public sealed class GetARideController : ControllerBase
    {
        private DomainFacade _service;
        private DomainFacade Service
        {
            get
            {
                return _service ?? (_service = new DomainFacade());
            }
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "You hit me.";
        }

        [HttpPost]
        public async Task<GetARideResponse> Post([FromBody] GetARideRequest getARideRequest)
        {
            return await Service.GetRides(getARideRequest);
        }
    }
}