namespace Fahrzeugverwaltung
{
    class Auto : BaseFahrzeuge
    {
        public string AnzAirBags { get; set; }
        public string InnenFarbe { get; set; }
        public string KlimaAnlage { get; set; }


        public Auto()
	    {
            FahrzeugArt = "AUTO";
            AnzAirBags = UserIn("Bitte geben Sie die Anzahl Air-Bags ein:", "");
            InnenFarbe = UserIn("Bitte geben Sie die Innenfarbe ein:", "");
            KlimaAnlage = UserIn("Hat dieses Fahrzeug eine Klimaanlage?:", "");        
        }
    }
}