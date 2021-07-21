using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Database;

namespace eProdaja.Services
{
    public class KupovineService : BaseReadService<Model.Narudzbe, Database.Narudzbe, object>, IKupovineService
    {
        public KupovineService(eProdajaContext context, IMapper mapper)
            :base(context, mapper)
        {
        }
    }
}
