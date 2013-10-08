using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fahrzeugverwaltung
{
    class Motorrad : BaseFahrzeuge
    {
        //public string fzArt = "MOTORRAD";
        public string extras;
        public string tankVolumen;

        public Motorrad ()
	{
        fahrzeugArt = "MOTORRAD";
        extras = userIn("Bitte geben Sie die Extras ein:", "");
        tankVolumen = userIn("Bitte geben Sie das Tankvolumen ein:", "");
	}

    }
}
