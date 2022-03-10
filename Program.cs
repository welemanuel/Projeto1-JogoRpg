// See https://aka.ms/new-console-template for more information
using projeto1.source.Entities;

knight arus = new knight("Arus", 23, "kinght");
wizardMago mago = new wizardMago("Jennica", 23, "White wizard");
BlackWizard topaza = new BlackWizard("Topaza", 42, "Black wizard");
Ninja wedge = new Ninja ("Wedge", 42, "Ninja");

Console.WriteLine(arus.Attack());
Console.WriteLine(mago.Attack(1));

Console.WriteLine(topaza.Attack());
Console.WriteLine(wedge.Attack());

 

