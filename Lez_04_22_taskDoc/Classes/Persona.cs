using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_22_taskDoc.Classes
{
    internal class Persona
    {
        public string? Nominativo { get; set; }
        public int Eta { get; set; }
        public CodiceFiscale? cFiscale { get; set; }
        public CartaDIdentita? cIdentita { get; set; }

        public override string ToString()
        {
            return $"[PERSONA] {Nominativo} {Eta} {cFiscale} {cIdentita}";
        }


    }
}
