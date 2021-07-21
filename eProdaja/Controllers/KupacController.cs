using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.Services;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KupacController : BaseReadController<Model.Kupac, object>
    {
        public KupacController(IReadService<Kupac, object> service)
            : base(service)
        {
        }
    }
}
