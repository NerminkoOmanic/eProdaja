using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IKupovineStavkeService
    {
        List<Model.NarudzbaStavke> Get();
    }
}
