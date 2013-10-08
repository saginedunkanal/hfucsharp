namespace Fahrzeugverwaltung
{
    class Motorrad : BaseFahrzeuge
    {
        //public string fzArt = "MOTORRAD";
        public string Extras { get; set; }
        public string TankVolumen { get; set; }


        public Motorrad()
        {
            FahrzeugArt = "MOTORRAD";
            Extras = UserIn("Bitte geben Sie die Extras ein:", "");
            TankVolumen = UserIn("Bitte geben Sie das Tankvolumen ein:", "");
        }
    }
}