# Pris-lista
Sammanfattning

Programmet består av en huvudmeny med olika val som användaren kan göra. Varje val motsvarar en metod som utför en specifik uppgift, som att beräkna pris baserat på ålder, beräkna totalkostnad för en grupp, upprepa text tio gånger eller hämta det tredje ordet i en mening. Programmet körs i en loop tills användaren väljer att avsluta det.

Förklaring

    bool keepRunning = true;: Skapar en variabel som bestämmer om programmet ska fortsätta köra.
    while (keepRunning): En loop som fortsätter att köras så länge keepRunning är sant.
    switch (choice): En kontrollstruktur som väljer en kodblock att köra baserat på användarens val.
    case "0": Sätter keepRunning till falskt och avslutar loopen, alltså programmet.
    case "1" till "4": Anropar olika metoder baserat på användarens val.

Metoder
  Enkel
    
    Frågar användaren om deras ålder och beräknar pris baserat på deras svar.
    int.TryParse: Försöker konvertera användarens input till ett heltal.

  Grupp
    
    Beräknar den totala kostnaden för en grupp baserat på ålder.
    for-loop: Itererar genom varje person i gruppen för att samla ålder och räkna ut kostnaden.

  Upprepa

    Upprepar en given text tio gånger och visar den i konsolen.
    for-loop: Används för att upprepa texten tio gånger.

  Tredje
    
    Tar en mening från användaren och returnerar det tredje ordet i meningen.
    string.Split: Delar upp meningen i en lista av ord baserat på mellanslag.