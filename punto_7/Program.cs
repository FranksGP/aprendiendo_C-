// See https://aka.ms/new-console-template for more information
float lado, lado2, area;
Console.WriteLine("---------------Calculadora del area cuadrada.----------------------");
Console.WriteLine("Por favor ingrese el valor del lado del cuadrado: ");
lado = float.Parse(Console.ReadLine());
Console.WriteLine("Por favor ingrese el valor del segundo area del cuadrado: ");
lado2 = float.Parse(Console.ReadLine());
area = lado * lado2;
Console.WriteLine($"El area del cuadrado es: {area}cm2");