// Gör en Bok-klass med egenskaperna Titel och Skribent.
// Separat fil för Bok-klassen, För att det ska vara lättare att hitta och ändra i koden.

public class Bok // Kallar klass för själva blueprinten för att skapa bokobjekt.
{
    public string Titel { get; set; } // Egenskap för boktitel, med get och set så att vi kan läsa och ändra den.
    public string Skribent { get; set; } // Egenskap för skribent.

    public Bok(string titel, string skribent) // Konstruktor som tar titel och skribent som argument och definierar dem i egenskaperna.
    {
        Titel = titel;
        Skribent = skribent;
    }

    public override string ToString() // Metod som returnerar en strängrepresentation av bokobjektet.
    {
        return $"Titel: {Titel}, Skribent: {Skribent}";
    }
}