// See https://aka.ms/new-console-template for more information
using System.Reflection;

int ano_hoy, ano_nacimiento, edad;
Console.WriteLine("¿Que años es hoy?");
ano_hoy = int.Parse(Console.ReadLine());
Console.WriteLine("¿Que año naciste?");
ano_nacimiento = int.Parse(Console.ReadLine());

edad = ano_hoy - ano_nacimiento;
Console.WriteLine($"Tu edad es {edad} años");
