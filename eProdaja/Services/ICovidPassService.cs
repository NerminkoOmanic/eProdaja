using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.Model.Requests;

namespace eProdaja.Services
{
    public interface ICovidPassService
    {
        IList<Model.CovidPass> Get(CovidPassSearchRequest search);
        Model.CovidPass Insert(CovidPassInserRequest request);
    }
}
