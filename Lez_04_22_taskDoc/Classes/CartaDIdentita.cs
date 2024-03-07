using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_04_22_taskDoc.Classes
{
    internal class CartaDIdentita
    {
        public int Codice { get; set; }
        public string? DataEmissione { get; set; }
        public string? DataScadenza { get; set; }
        public string? TipoEmissione { get; set; }

        public override string ToString()
        {
            return $"[CARTA D'IDENTITA'] {Codice} {DataEmissione} {DataScadenza} {TipoEmissione}";
        }
    }
}
