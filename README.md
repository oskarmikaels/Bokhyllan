# Bokhyllan - Programmering 2

Ett bibliotekssystem som hanterar olika typer av böcker med hjälp av arv och objektorienterad programmering.

# Bok.cs

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

---

# Underklass Roman.cs
```csharp
public override string ToString()
{
    return $"Roman: {Titel} av {Skribent}, {AntalSidor} sidor";
}
```

---

## Förklaring del för del:

### `public override string ToString()`

**public** = Metoden är tillgänglig för alla

**override** = Skriver över den vanliga ToString() metoden som alla objekt har

**string** = Metoden returnerar en textsträng

**ToString()** = Namnet på metoden som omvandlar objektet till en textrepresentation

---

### `return`

**return** = Returnerar värdet som kommer efter

När ToString() anropas returnerar metoden det som står efter return.

---

### Dollartecknet `$` framför citattecknet
```csharp
$"Roman: {Titel} av {Skribent}, {AntalSidor} sidor"
```

**Dollartecknet aktiverar string interpolation**

Med `$` framför strängen kan variabler stoppas in direkt i texten med `{}`.

**Utan dollartecken (vanlig sträng):**
```csharp
"Roman: " + Titel + " av " + Skribent + ", " + AntalSidor + " sidor"
// Kräver mycket konkatenering med plus
```

**Med dollartecken (string interpolation):**
```csharp
$"Roman: {Titel} av {Skribent}, {AntalSidor} sidor"
// Variablerna skrivs direkt i texten
```

---

### Krullparenteserna `{Titel}`

**Krullparenteser markerar var värden ska stoppas in**
```csharp
$"Roman: {Titel} av {Skribent}, {AntalSidor} sidor"
         ↑       ↑             ↑              ↑
         |       |             |              |
    Värdet av   Värdet av  Värdet av     Vanlig text
    Titel       Skribent   AntalSidor    
```

**Exempel med faktiska värden:**

Om boken har:
- Titel = "1984"
- Skribent = "George Orwell"  
- AntalSidor = 328

Blir resultatet:
```
"Roman: 1984 av George Orwell, 328 sidor"
```

---

## Sammanfattning:

**`$`** framför strängen = Aktiverar string interpolation

**`{variabelnamn}`** = Platshållare där variabelns värde stoppas in

**Allt annat** = Vanlig text som skrivs ut som den är

---

## Exempel på användning:
```csharp
string namn = "Oskar";
int ålder = 25;

Console.WriteLine($"Hej, jag heter {namn} och är {ålder} år gammal!");
// Output: "Hej, jag heter Oskar och är 25 år gammal!"
```

`{namn}` ersätts med "Oskar" och `{ålder}` ersätts med "25".

Detta är samma princip som används i ToString().
```

**AI-assistans:** Google Gemini AI hjälpte mig förstå get/set-konceptet och varför man inte kan kombinera virtual och override på samma metod.

**Nästa steg:** Skapa tre underklasser med unika egenskaper och egna ToString()-implementationer.