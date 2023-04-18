using myProduct;
using System.Security.Cryptography;

Product oggettoMaglia = new Product ("maglia", "maglia a maniche corte blu", 123445567);

    Console.WriteLine();


Console.WriteLine("IL CODICE DEL PRODOTTO E: " + 123445567 + oggettoMaglia.getRandomNumber());

    Console.WriteLine();

Console.WriteLine ("IL NOSTRO PRODOTTO E UNA: " + oggettoMaglia.getName());

    Console.WriteLine();

Console.WriteLine(oggettoMaglia.getDescription());

    Console.WriteLine();

Console.WriteLine ("IL PREZZO DEL PRODOTTO E DI: " + oggettoMaglia.getPrice() + "e");

    Console.WriteLine();

Console.WriteLine ("IL PREZZO COMPLESSIVO DI IVA E: " + oggettoMaglia.getIvaPrice() + "e");

    Console.WriteLine();

Console.WriteLine ("IL NOME ESTESO DEL PRODOTTO E: " + oggettoMaglia.getCodeName() + oggettoMaglia.getRandomNumber());


































































