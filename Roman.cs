public class Roman : Bok // Roman ärver från Bok, får alla egenskaper och metoder därifrån
{
    public int AntalSidor { get; set; } // HYLLAN där sidantalet bor permanent i objektet

    // Konstruktor som tar emot tre PAKET med information
    public Roman(string inkommandeTitel, string inkommandeFörfattare, int inkommandeSidor) 
        : base(inkommandeTitel, inkommandeFörfattare) // Skicka två paket vidare till Bok-klassen
    {
        // Ta värdet ur paketet och lägg på hyllan
        AntalSidor = inkommandeSidor;
    }

    public override string ToString()
    {
        return $"Roman: {Titel} av {Skribent}, {AntalSidor} sidor";
    }
}