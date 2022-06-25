// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var lampe11 = new Lampe();
lampe11.Eteindre();
var lampe13 = new Lampe(true);
lampe13.Allumer();
var lampe12 = new Lampe(true, "Rouge");
Console.WriteLine($"Etat Lampe 12 : {lampe12.Etat()}");

// afficher les lampes 11, 12, 13
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Afficher les lampes 11, 12, 13");
Console.WriteLine();

Console.WriteLine($"***Lampe 11***");
lampe11.Afficher();
Console.WriteLine();

Console.WriteLine($"***Lampe 12***");
lampe12.Afficher();
Console.WriteLine();

Console.WriteLine($"***Lampe 13***");
lampe13.Afficher();
Console.WriteLine();




