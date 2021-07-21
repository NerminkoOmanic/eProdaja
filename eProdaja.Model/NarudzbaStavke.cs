using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model
{
    public class NarudzbaStavke
    {
        public int NarudzbaStavkaId { get; set; }
        public int NarudzbaId { get; set; }
        public int ProizvodId { get; set; }
        public int Kolicina { get; set; }

        public virtual Proizvodi Proizvod { get; set; }
    }
}
