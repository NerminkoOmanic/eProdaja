using AutoMapper;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Database;
using eProdaja.Model;

namespace eProdaja.Mapping
{
    public class eProdajaProfile : Profile
    {
        public eProdajaProfile()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.JediniceMjere, Model.JediniceMjere>();
            CreateMap<Database.VrsteProizvodum, Model.VrsteProizvodum>();
            CreateMap<Database.Proizvodi, Model.Proizvodi>();
            CreateMap<Database.Uloge, Model.Uloge>();
            CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>();
            CreateMap<Database.CovidPasss, Model.CovidPass>();
            CreateMap<Kupci, Kupac>();
            CreateMap<Database.Narudzbe, Model.Narudzbe>();
            CreateMap<Database.NarudzbaStavke, Model.NarudzbaStavke>();

            CreateMap<ProizvodiInsertRequest, Database.Proizvodi>();
            CreateMap<ProizvodiUpdateRequest, Database.Proizvodi>();
            CreateMap<KorisniciInsertRequest, Database.Korisnici>();
            CreateMap<KorisniciUpdateRequest, Database.Korisnici>();
            CreateMap<CovidPassInserRequest, Database.CovidPasss>();

        }
    }
}
