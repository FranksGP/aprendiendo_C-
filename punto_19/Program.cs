// See https://aka.ms/new-console-template for more information

using System;

string nombreProducto;
int valor = 0, valorTotal = 0, cantidad = 0, tope = 20000;
double descuento1 = 0.15,descuento2 = 0.35, valorFinal;
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
    Console.WriteLine($"Tu compra es de {valorTotal}. Se descuenta el 35% de tu compra.");
    valorFinal = valorTotal - (valorTotal * descuento2);
    Console.WriteLine($"El valor de tu compra es de: {valorFinal}");
}
else
{

    Console.WriteLine($"Tu compra es de {valorTotal}. Se descuenta el 15% de tu compra.");
    valorFinal = valorTotal - (valorTotal * descuento1);
    Console.WriteLine($"El valor de tu compra es de: {valorFinal}");
}



