# Bokhyllan - Programmering 2

Ett bibliotekssystem som hanterar olika typer av böcker med hjälp av arv och objektorienterad programmering.

## Innehållsförteckning

- [Klassen Bok.cs](#klassen-bokcs)

## Utvecklingslogg

## Klassen Bok.cs

Började med att bygga grundstrukturen för alla böcker. Identifierade att Titel och Skribent är gemensamma egenskaper som alla boktyper behöver ha.

Valde att använda auto-properties med `{ get; set; }` istället för publika fält:
```csharp
public string Titel { get; set; }  // Modern C# standard
// vs
public string Titel;  // Äldre stil från övningsmaterialet
```

Auto-properties ger mer flexibilitet framöver, till exempel om jag senare vill lägga till validering eller göra egenskapen read-only.

Implementerade en konstruktor som tar emot titel och skribent för att säkerställa att alla böcker skapas med dessa värden från start. Överskrev också `ToString()` för att ge en tydlig strängrepresentation.

**Lärdomar från denna del:**
Fick klarhet i skillnaden mellan `virtual` och `override`. Försökte först använda `public virtual override string ToString()` men insåg att `ToString()` redan är virtual i Object-klassen, så jag behöver bara `override`.

Förstår nu också skillnaden mellan egenskaper (data som objektet innehåller) och metoder (handlingar som objektet kan utföra).

**AI-assistans:** Google Gemini AI hjälpte mig förstå get/set-konceptet och varför man inte kan kombinera virtual och override på samma metod.

**Nästa steg:** Skapa tre underklasser med unika egenskaper och egna ToString()-implementationer.