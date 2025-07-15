// See https://aka.ms/new-console-template for more information
using System;

int lunes, martes, miercoles, jueves, viernes, sabado, domingo, tempTotal;
int calor = 35, frio = 15; 
float temperatura;
Console.WriteLine("Bienvenido a la calculadora de terpelratura");
Console.WriteLine("Ingrese ingresa la tempretura de los dias de la semana:");
Console.Write("Lunes: ");
lunes = int.Parse(Console.ReadLine());
Console.Write("Martes: ");
martes = int.Parse(Console.ReadLine());
Console.Write("Miércoles: ");
miercoles = int.Parse(Console.ReadLine());
Console.Write("Jueves: ");
jueves = int.Parse(Console.ReadLine());
Console.Write("Viernes: ");
viernes = int.Parse(Console.ReadLine());
Console.Write("Sábado: ");
sabado = int.Parse(Console.ReadLine());
Console.Write("Domingo: ");
domingo = int.Parse(Console.ReadLine());
tempTotal = lunes + martes + miercoles + jueves + viernes + sabado + domingo;
temperatura = tempTotal / 7f;

if (temperatura > calor)
{
    Console.WriteLine($"La temperatura del la semana es: {temperatura}°C");
    Console.WriteLine("¡Que semana tan calurosa!");
}
else if (temperatura < frio)
{
    Console.WriteLine($"La temperatura del la semana es: {temperatura}°C");
    Console.WriteLine("¡Que semana tan fria!");
}
else
{
    Console.WriteLine($"La temperatura del la semana es: {temperatura}°C");
    Console.WriteLine("Que clima tan delicioso");

}
