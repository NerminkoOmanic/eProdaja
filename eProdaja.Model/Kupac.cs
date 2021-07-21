using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model
{
    public class Kupac
    {
        public int KupacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string ImePrezime => Ime+" "+Prezime;
    }
}
