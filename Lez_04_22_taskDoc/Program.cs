using Lez_04_22_taskDoc.Classes;

namespace Lez_04_22_taskDoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
			/**
			 * Creare un sistema in grado di immagazinare i dati relativi ad una persona.
			 * Inoltre, sarà necessario immagazinare, all'interno di una persona, i dati 
			 * relativi a:
			 * - Codice Fiscale
			 * |- CODICE
			 * |_ Data di scadenza
			 * 
			 * - Carta di Identita: 
			 * |- CODICE
			 * |- Data di Emissione
			 * |- Data di Scadenza
			 * |_ Emissione (comune || zecca dello stato)
			 */

			CodiceFiscale codiceFiscale = new CodiceFiscale()
			{
				Codice = 349580950,
				Scadenza="19/11/2054"
			};

			CartaDIdentita cartaDIdentita = new CartaDIdentita()
			{
				Codice=998012892,
				DataEmissione="19/11/2012",
				DataScadenza="19/11/2034",
				TipoEmissione="sos"
			};

			if (!cartaDIdentita.TipoEmissione.ToUpper().Equals("COMUNE") || !cartaDIdentita.TipoEmissione.ToUpper().Equals("ZECCA DELLO STATO"))
			{
				cartaDIdentita.TipoEmissione = null;
			}
			
				

			Persona persona = new Persona()
			{
				Nominativo="Lorenzo",
				Eta=19,
				cFiscale= codiceFiscale,
				cIdentita= cartaDIdentita
			};

			Console.WriteLine(persona.ToString());

        }
    }
}
