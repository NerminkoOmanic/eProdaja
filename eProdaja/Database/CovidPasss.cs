using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Database
{
    public class CovidPasss
    {
        [Key]
        public int CovidPassId { get; set; }
        public DateTime DatumPocetak { get; set; }
        public DateTime DatumKraj { get; set; }

        [ForeignKey("KupciId")]
        public int KupacId { get; set; }
        public Kupci Kupac { get; set; }
    }
}
