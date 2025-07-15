// See https://aka.ms/new-console-template for more information
int Edad, anoActual = 2025, anoNacimiento;
Console.WriteLine("Digite su año de nacimineto: ");
anoNacimiento = int.Parse(Console.ReadLine());
Edad = anoActual - anoNacimiento;
if (Edad >= 18)
{
    Console.WriteLine($"Usted tiene:{Edad}");
    Console.WriteLine("Es mayor de edad");
}
else
{
    Console.WriteLine($"Usted tiene:{Edad}");
    Console.WriteLine("Es menor de edad");                                      
}
