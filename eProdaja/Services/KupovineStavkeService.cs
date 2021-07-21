using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Database;
using Microsoft.EntityFrameworkCore;

namespace eProdaja.Services
{
    public class KupovineStavkeService : IKupovineStavkeService
    {
        public eProdajaContext Context { get; set; }
        protected readonly IMapper _mapper;

        public KupovineStavkeService(eProdajaContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public List<Model.NarudzbaStavke> Get()
        {
            var dbSet = Context.NarudzbaStavkes.Include(x => x.Proizvod).ToList();
            return _mapper.Map<List<Model.NarudzbaStavke>>(dbSet);
        }
    }
}
