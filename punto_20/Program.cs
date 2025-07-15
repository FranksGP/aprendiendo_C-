// See https://aka.ms/new-console-template for more information
using System;
int numero = 0;
Console.WriteLine("Bienvenido a la calculadore de numero pares");
Console.WriteLine("Ingrese un numero entero Positivo: ");
numero = int.Parse(Console.ReadLine());
if (numero % 2 == 0)
{
    Console.WriteLine($"El numero {numero} es par");
}
else 

    Console.WriteLine($"El numero {numero} es impar");

