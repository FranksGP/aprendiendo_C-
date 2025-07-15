// See https://aka.ms/new-console-template for more information
double num, porce=0.20f, resul;

Console.WriteLine("Bienvenido a la calculadora 20% ingresa un valor: ");
num = double.Parse(Console.ReadLine());
resul = num * porce;
Console.WriteLine($"El 20% de {num} es {resul}");
