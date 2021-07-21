using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.Requests
{
    public class CovidPassSearchRequest
    {
        public int? KupacId { get; set; }
        public DateTime? DatumKupovine { get; set; }
    }
}
