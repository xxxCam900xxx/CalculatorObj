# Calculator Project with C#

In diesem Projekt baue ich gerade einen kleinen Taschen welche ich mit meinem jetzigen Wissenstand baue.
Ich versuche in diesem Projekt den Taschen Rechner Objekt Orientiert zu bauen, um ein besseres Verständnis zu kriegen.
Dazu möchte ich noch mein ganzes Projekt einwenig dokumentieren, um später einen guten Rückblick zu haben.

[X] Menu Erstellt
[] Operationen eingebaut
[] Testfälle gebaut

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