using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaOdev
{
    internal class Araba
    { 
        public int Id { get; set; }

        public string Marka { get; set; }
           
        public string Model { get; set; }

        public byte KapiSayisi { get; set; }

        public short BeygirGucu { get; set; }

        public string ArabaTuru { get; set; }

        public short MaksimumHiz { get; set; }

        public string Cekis { get; set; }

        public byte SifirdanYuzeYukselme { get; set; }

        public short Agirlik { get; set; }

        public double MotorHacmi { get; set; }
    
    }
    

    
}
