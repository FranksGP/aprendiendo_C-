// See https://aka.ms/new-console-template for more information
int cantiJamon = 0, valorJamon = 15000, cantManzanas = 0, valorManzanas = 400, total;
double totalCompra, iva = 0.16;
Console.WriteLine("Bienvenido a la tienda");
Console.WriteLine("El valor del jamones es de $15000, el valor de la manzana es de $400");
Console.WriteLine("¿Cuantos jamones compraste?:");
cantiJamon = int.Parse(Console.ReadLine());
Console.WriteLine("¿Cuantas mazanas compraste?:");
cantManzanas = int.Parse(Console.ReadLine());

total = (cantiJamon * valorJamon) + (cantManzanas * valorManzanas);
double valorIva = total * iva;
totalCompra = total + valorIva;

Console.WriteLine($"El total de la compra es: {totalCompra}");
