using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model.Requests;
using eProdaja.Services;
using Microsoft.AspNetCore.Authorization;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class CovidPassController : ControllerBase
    {
        private readonly ICovidPassService _service;

        public CovidPassController(ICovidPassService service)
        {
            _service = service;
        }

        [HttpGet]
        public IList<Model.CovidPass> Get([FromQuery] CovidPassSearchRequest request)
        {
            return _service.Get(request);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public Model.CovidPass Insert(CovidPassInserRequest request)
        {
            return _service.Insert(request);
        }
    }
}
