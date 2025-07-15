// See https://aka.ms/new-console-template for more information
var num = 0d;
var resultado = 0d;
Console.WriteLine("Ingresa un número entero:");
num = double.Parse(Console.ReadLine());
resultado = num / 2;
if (resultado > 100)
{
    Console.WriteLine($"la mitad de {num} es: {resultado}");
    Console.WriteLine("El resultado es mayor a 100");
}
else if (resultado < 100)
{
    Console.WriteLine($"la mitad de {num} es: {resultado}");
    Console.WriteLine("El resultado es menor a 100");
}
else
{
    Console.WriteLine($"la mitad de {num} es: {resultado}");
    Console.WriteLine("El resultado es igual a 100");
}
