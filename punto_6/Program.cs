// See https://aka.ms/new-console-template for more information
double novent=0.90f, treint=0.30f, sesent=0.60f, valor, resultado1,resultado2, resultado3;
Console.WriteLine("\nBienvenido a la calculadora de 30%, 90% y 60%\n");
Console.WriteLine("Por favor ingrese el valor del producto: ");

valor = double.Parse(Console.ReadLine());
resultado1 = valor * treint;
resultado2 = resultado1 * novent;
resultado3 = resultado1 * sesent;

Console.WriteLine($"  Ingresate {valor} el 30% de es de: {resultado1} \n  El 90% de {valor} es de: {resultado2} \n  El 60% de {valor} es de: {resultado3}");

