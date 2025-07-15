// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Ingrese el primer número:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer número:");
int num3 = int.Parse(Console.ReadLine());

int mayor = Math.Max(num1, Math.Max(num2, num3));
int menor = Math.Min(num1, Math.Min(num2, num3));
int medio = num1 + num2 + num3 - mayor - menor;

Console.WriteLine($"El mayor es: {mayor}");
Console.WriteLine($"El menor es: {menor}");
Console.WriteLine($"El de la mitad es: {medio}");
