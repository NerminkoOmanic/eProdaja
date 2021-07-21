using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eProdaja.Model
{
    public class CovidPass
    {
        public int CovidPassId { get; set; }
        public DateTime DatumPocetak { get; set; } 
        public DateTime DatumKraj { get; set; }
        public int KupacId { get; set; }
        public virtual Kupac Kupac { get; set; }

        public string ImePrezime => Kupac?.ImePrezime;

    }
}
