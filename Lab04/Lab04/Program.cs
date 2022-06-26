//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");

//var lampe11 = new Lampe();
//lampe11.Eteindre();
//var lampe13 = new Lampe(true);
//lampe13.Allumer();
//var lampe12 = new Lampe(true, "Rouge");
//Console.WriteLine($"Etat Lampe 12 : {lampe12.Etat()}");

////afficher les lampes 11, 12, 13
//Console.WriteLine();
//Console.WriteLine();

//Console.WriteLine($"Afficher les lampes 11, 12, 13");
//Console.WriteLine();

//Console.WriteLine($"***Lampe 11***");
//lampe11.Afficher();
//Console.WriteLine();

//Console.WriteLine($"***Lampe 12***");
//lampe12.Afficher();
//Console.WriteLine();

//Console.WriteLine($"***Lampe 13***");
//lampe13.Afficher();
//Console.WriteLine();

//var employe = new Employe();
//employe.Afficher();

var emp1 = new Employe("bouhiel", "mohamed  salah", 4500, 2005, "123 Rue Charlemagne, Gatineau, A1B2C3, Canada");
var emp2 = new Employe("duval", "Eric", 2500, 2015);
var emp3 = new Employe("bouhiel", "mohamed  salah", 4500, 2005, "123 Rue Charlemagne, Gatineau, A1B2C3, Canada");
Console.WriteLine($"emp1 salaire annuel : {emp1.SalaireAnnuel()}$CAD");
Console.WriteLine($"emp2 salaire annuel : {emp2.SalaireAnnuel()}$CAD");
Console.WriteLine();

Console.WriteLine($"emp1 anciennete : {emp1.Anciennete()} annees");
Console.WriteLine();

Console.WriteLine($"emp2 prime de salaire est : {emp2.Prime()}$CAD");
Console.WriteLine();

Console.WriteLine($"Compare emp1 et emp2, si il sont egaux");
emp1.Equals(emp2);
Console.WriteLine();
Console.WriteLine($"Compare emp1 et emp3, si il sont egaux");
emp1.Equals(emp3);
Console.WriteLine();

emp1.Afficher();
Console.WriteLine();
emp2.Afficher();











