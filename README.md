# Calculator Project with C#

In diesem Projekt baue ich gerade einen kleinen Taschen welche ich mit meinem jetzigen Wissenstand baue.
Ich versuche in diesem Projekt den Taschen Rechner Objekt Orientiert zu bauen, um ein besseres Verständnis zu kriegen.
Dazu möchte ich noch mein ganzes Projekt einwenig dokumentieren, um später einen guten Rückblick zu haben.

- [X] Menu Erstellt
- [X] Operationen eingebaut
- [ ] Error-handling einbauen
- [ ] Testfälle gebaut

---

# Dokumentation

### 10.11.2024

Ich habe heute am 10.11.2024 mit meinem Projekt gestartet. Ich habe zuerst mir einen Boot screen gebaut.
Mit einem ``For-Loop`` und der Systemfunktion ``Thread`` konnte ich einen gut animierten Screen erstellen.

```C#
for (int i = 0; i < 2; i++) {
    // Loading Screen Text
    Thread.Sleep(1000);
    Console.Clear();
}
```

Im ``Program.cs`` habe eine Variable erstellt welche meine Klasse Service erstellt.

```C#
var Service = new CalcService();

Service.Start();
```

Im ``CalcService`` erstelle ich verschiedene Methoden welche gegenseite dann Aufrufe. z.B. habe ich heute das Menu gebaut welche die Methode ``StartMenu`` aufruft. Die Methode gibt einen ``string`` zurück welche ich dann validiere um meine bestimmte Methode aufzurufen.

```C#
public string StartMenu () {

    // Function

    return indexOptions;
}
```

Heute konnte ich das Menu fertigstellen, weitergeht es mit dem Rechner!

---

### 15.11.2024

Heute habe ich weiter an meinem Taschenrechner gearbeitet. Er kann jetzt die 4 Operationen **(+,-,*,/)**. Um meine Zahlen und Operationen zu bekommen, habe ich meinen ``String`` mit `Console.ReadLine()` ausgelesen.Dabei gab es ein Problem, da ich versucht habe einen ``Stringwert`` in einen ``Double`` einzufügen, hatte ich Konvertierungsprobleme. Diese konnte ich lösen, indem ich den ``String`` in einen ``Double`` konvertierte. Das ging ganz einfach mit `Convert.ToDouble(num)`.

```C#
result = Convert.ToDouble(num1) + Convert.ToDouble(num2);
```

Als ich meine Konvertierung gebaut habe, wollte ich noch einbauen, dass man das immer wiederholen kann. Also habe ich einen ``Bool`` eingebaut, der prüft, ob die Person weiterrechnen will oder nicht. Diesen habe ich in eine ``Do-While-Loop`` gepackt. Am Ende sah das Code Snippet so aus:

```C#
bool isValid = false;

do
{
    Console.WriteLine("Do you want to proceed? (yes/no)");
    string answer = Console.ReadLine()?.Trim().ToLower();
    Console.Clear();

    if (answer == "yes" || answer == "y")
    {
        isValid = true;
        CalcProcess();
    }
    else if (answer == "no" || answer == "n")
    {
        isValid = true;
        StopCalc();
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
        isValid = false;
    }
} while (!isValid);
```

Jetzt muss ich noch ein Errorhandling einbauen, da die Leute gerne Buchstaben in Operatoren oder Zahlen einbauen. Das möchte ich verhindern und bei einer Fehlermeldung bitten, dies noch einmal einzugeben.

---