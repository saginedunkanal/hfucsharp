using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeugverwaltung
{
    class Lieferwagen : BaseFahrzeuge
    {
        
        public string anzSeats;
        public string maxLoad;
       

        public Lieferwagen ()
	{
        fahrzeugArt = "LIEFERWAGEN";
        anzSeats = userIn("Bitte geben Sie die Anzahl Sitze ein:", "");
        maxLoad = userIn("Bitte geben Sie die max. Zuladung ein:", "");
	}

    }
}
