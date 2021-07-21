using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Services;
using Microsoft.AspNetCore.Authorization;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class KupovineStavkeController : ControllerBase
    {
        private readonly IKupovineStavkeService _service;

        public KupovineStavkeController(IKupovineStavkeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IList<Model.NarudzbaStavke> GetAll()
        {
            return _service.Get();
        }
    
    }
}
