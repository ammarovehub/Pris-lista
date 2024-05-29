# Pris-lista
Sammanfattning

Programmet best�r av en huvudmeny med olika val som anv�ndaren kan g�ra. Varje val motsvarar en metod som utf�r en specifik uppgift, som att ber�kna pris baserat p� �lder, ber�kna totalkostnad f�r en grupp, upprepa text tio g�nger eller h�mta det tredje ordet i en mening. Programmet k�rs i en loop tills anv�ndaren v�ljer att avsluta det.

F�rklaring

    bool keepRunning = true;: Skapar en variabel som best�mmer om programmet ska forts�tta k�ra.
    while (keepRunning): En loop som forts�tter att k�ras s� l�nge keepRunning �r sant.
    switch (choice): En kontrollstruktur som v�ljer en kodblock att k�ra baserat p� anv�ndarens val.
    case "0": S�tter keepRunning till falskt och avslutar loopen, allts� programmet.
    case "1" till "4": Anropar olika metoder baserat p� anv�ndarens val.

Metoder
  Enkel
    
    Fr�gar anv�ndaren om deras �lder och ber�knar pris baserat p� deras svar.
    int.TryParse: F�rs�ker konvertera anv�ndarens input till ett heltal.

  Grupp
    
    Ber�knar den totala kostnaden f�r en grupp baserat p� �lder.
    for-loop: Itererar genom varje person i gruppen f�r att samla �lder och r�kna ut kostnaden.

  Upprepa

    Upprepar en given text tio g�nger och visar den i konsolen.
    for-loop: Anv�nds f�r att upprepa texten tio g�nger.

  Tredje
    
    Tar en mening fr�n anv�ndaren och returnerar det tredje ordet i meningen.
    string.Split: Delar upp meningen i en lista av ord baserat p� mellanslag.