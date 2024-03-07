using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_22_taskDoc.Classes
{
    internal class CodiceFiscale
    {
        public int Codice { get; set; }
        public string? Scadenza { get; set;}

        public override string ToString()
        {
            return $"[CODICE FISCALE] {Codice} {Scadenza}";
        }
    }
}
