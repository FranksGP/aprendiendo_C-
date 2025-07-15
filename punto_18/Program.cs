// See https://aka.ms/new-console-template for more information

using System;

string nombreProducto;
int valor = 0, valorTotal = 0, cantidad = 0, tope = 100;
double descuento = 0.20, valorFinal;
Console.WriteLine("Bienvenido");
Console.WriteLine("Ingrese por por vabor le nombre del articulo");
nombreProducto = Console.ReadLine();
Console.WriteLine("Ingresa el valor del articulo: ");
cantidad = int.Parse(Console.ReadLine());
Console.WriteLine($"Ingrese cuentos {nombreProducto} desea comprar: ");
valor = int.Parse(Console.ReadLine());
valorTotal = valor * cantidad;
Console.WriteLine($"Total de compra:{valorTotal}");
if (valorTotal >= tope)
{
    Console.WriteLine("Tu compra supera los 100mil!! aplicaste pare el descuente del 20%");
    valorFinal = valorTotal - (valorTotal * descuento);
    Console.WriteLine($"El valor de tu compra es de: {valorFinal}");
}
else
    Console.WriteLine($"El valor total es {valorTotal}");



