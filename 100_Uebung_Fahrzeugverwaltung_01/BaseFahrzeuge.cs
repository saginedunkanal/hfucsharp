using System;

namespace Fahrzeugverwaltung
{
    class BaseFahrzeuge
    {
        //Fields
        public string FahrzeugArt { get; set; }   // Attribute würde ich generell nicht public machen
                                                  // Falls ein Attribut public sein soll, würde ich eine Eigenschaft (engl. Property) verwenden
                                                  // Eigenschaften werden per Coding Guideline mit einem Grossbuchstaben begonnen
        public string FahrzeugId { get; set; }
        public string Marke { get; set; }
        public string Modell { get; set; }
        public FarbAuswahl Farbe { get; set; }   // Die Farbe ist nicht vom Typ string, sondern vom Typ FarbAuswahl
                                                 // Die InnenFarbe bei der Auto-Klasse müsste man auch so anpassen; habe ich jetzt nicht gemacht
        public string HubRaum { get; set; }
        public string Preis { get; set; }
        public string JahrGang { get; set; }
        public string TreibStoff { get; set; }


        //Enum
        public enum FarbAuswahl { Rot, Gruen, Gelb, Weiss, Schwarz, Blau, Braun, Silber, Pink, Violett }


        //Constructor
        public BaseFahrzeuge()
        {
            //Ask the user for inputs
            FahrzeugId = UserIn("Bitte geben Sie eine Fahrzeug ID ein:", "");
            Marke = UserIn("Bitte geben Sie die Marke ein:", "");
            Modell = UserIn("Bitte geben Sie das Modell ein:", "");

            //Accept only values from enum FarbAuswahl!
            Farbe = UserInputFarbe();

            HubRaum = UserIn("Bitte geben Sie den Hubraum ein:", "");
            Preis = UserIn("Bitte geben Sie den Preis ein:", "");
            JahrGang = UserIn("Bitte geben Sie den Jahrgang ein:", "");
            TreibStoff = UserIn("Bitte geben Sie den Treibstoff ein:", "");
        }

        //handle the in/output to console
        public string UserIn(string outText, string auswahl) // Methodennamen werden per Coding Guideline mit einem Grossbuchstaben begonnen
        {
            string userOut;
            Console.WriteLine("{0}", outText + "\t" + auswahl);
            userOut = Console.ReadLine();
            return userOut;
        }

        /// <summary>
        /// Gets a color selection from the user and ensures that the input is a valid color defined in enum FarbAuswahl
        /// </summary>
        /// <returns>The color selected by the user</returns>
        private FarbAuswahl UserInputFarbe()
        {
            FarbAuswahl colorSelection = FarbAuswahl.Schwarz; // Set a default color
            bool accept = false; // Da diese Variable nur innerhalb dieser Methode verwendet wird, würde ich sie auch hier lokal deklarieren
                                 // anstatt ein Attribut (engl. Field) daraus zu machen; nur falls sie von mindestens zwei Methoden verwendet
                                 // wird, würde ich "accept" ganz oben deklarieren
            Type enumType = typeof (FarbAuswahl); // Das ist neu. Haben wir im Unterricht nicht gelernt. Aber so kannst du deine Anforderung umsetzen
            string auswahl = AuswahlMenue(enumType);
            while (accept == false)
            {
                string farbe = UserIn("Bitte geben Sie die Farbe ein:", auswahl);
                int colNumber;
                if (Int32.TryParse(farbe, out colNumber)) //if the input of the user can convert to int32 then choose the enum word
                {
                    if (0 <= colNumber && colNumber <= 9)
                        // Hier wird geschummelt: ich habe nachgeschaut wieviele Elemente im enum
                        // FarbAuswahl drin sind und habe hier dann 9 hardkodiert hingeschrieben.
                        // Wenn man die Farben im enum FarbAuswahl anpasst, muss man auch hier den
                        // Code anpassen. Das ist ganz schlecht. Man kann natürlich automatisch
                        // herausfinden wieviele Elemente ein Enum hat, das bedingt aber Code
                        // den wir noch nicht gelernt haben.
                    {
                        colorSelection = (FarbAuswahl)colNumber;
                        accept = true;
                    }
                }
                else
                {
                    Console.WriteLine("Sie müssen eine Zahl eingeben");
                }
            }
            return colorSelection;
        }

        //This is to create a string of menue items of a enum Type  <-- Ausgezeichnet, dass du die Methoden mit einem Kommentar versiehst! Verwende dazu
                                                                        // aber die Kommentar-Variante mit den drei Schrägstrichen "///" wie ich sie bei
                                                                        // der UserInputFarbe-Methode illustriere
        public string AuswahlMenue(Type enumType)
        {
            string availableColorOptions = "";
            foreach (int val in Enum.GetValues(enumType))
            {
                availableColorOptions += val + "=" + Enum.GetName(enumType, val) + " | ";
            }
            return availableColorOptions;
        }
    }
}