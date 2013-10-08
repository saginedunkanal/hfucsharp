namespace Fahrzeugverwaltung
{
    class Lieferwagen : BaseFahrzeuge
    {
        public string AnzSeats { get; set; }
        public string MaxLoad { get; set; }


        public Lieferwagen()
        {
            FahrzeugArt = "LIEFERWAGEN";
            AnzSeats = UserIn("Bitte geben Sie die Anzahl Sitze ein:", "");
            MaxLoad = UserIn("Bitte geben Sie die max. Zuladung ein:", "");
        }
    }
}