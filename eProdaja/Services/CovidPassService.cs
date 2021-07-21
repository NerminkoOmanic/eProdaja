using eProdaja.Model;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Database;
using Microsoft.EntityFrameworkCore;

namespace eProdaja.Services
{
    public class CovidPassService : ICovidPassService
    {
        public eProdajaContext Context { get; set; }
        protected readonly IMapper _mapper;

        public CovidPassService(eProdajaContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public IList<Model.CovidPass> Get(CovidPassSearchRequest search = null)
        {
            var query = Context.CovidPass.AsQueryable();

            if (search?.KupacId != null)
            {
                query = query.Where(x => x.KupacId == search.KupacId);
            }

            if (search?.DatumKupovine != null)
            {
                query = query.Where(x => x.DatumPocetak < search.DatumKupovine && x.DatumKraj > search.DatumKupovine);
            }

            query = query.Include(x => x.Kupac);

            var dbSet = query.ToList();

            return _mapper.Map<IList<Model.CovidPass>>(dbSet);
        }

        public Model.CovidPass Insert(CovidPassInserRequest request)
        {
            var entity = _mapper.Map<Database.CovidPasss>(request);

            Context.CovidPass.Add(entity);
            Context.SaveChanges();

            return _mapper.Map<Model.CovidPass>(entity);
        }
    }
}
