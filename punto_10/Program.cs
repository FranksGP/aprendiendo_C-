// See https://aka.ms/new-console-template for more information
double salario=0, deSalud=0.15, despension=0.10, dias=0, totalSalario=0;
Console.WriteLine("----------salario de empleado----------");
Console.WriteLine("Por favor ingrese el valor del salario: ");
salario = double.Parse(Console.ReadLine());
dias = salario / 30;
totalSalario = salario - (salario * deSalud) - (salario * despension);
Console.WriteLine("dia de trabajo: " + dias);
Console.WriteLine("El salario total es: " + totalSalario);

