using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Services;

namespace eProdaja.Controllers
{
    
    public class KupovineController : BaseReadController<Model.Narudzbe, object>
    {
        public KupovineController(IKupovineService service)
            : base(service)
        {
            
        }
    }
}
