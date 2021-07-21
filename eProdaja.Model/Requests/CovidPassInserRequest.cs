using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.Requests
{
    public class CovidPassInserRequest 
    {
        public int KupacId { get; set; }
        public DateTime DatumPocetak { get; set; }
        public DateTime DatumKraj { get; set; }
    }
}
