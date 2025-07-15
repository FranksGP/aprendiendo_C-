// See https://aka.ms/new-console-template for more information
float numero = 0, numeroIngre=0;
Console.WriteLine("Ingrese por favor un numero:");
numeroIngre = float.Parse(Console.ReadLine());
if (numero == numeroIngre)
{
    Console.WriteLine("El valor que digitaste es 0(cero).");
}
else if (numero > numeroIngre)
{
    Console.WriteLine($"{numeroIngre} es menor que 0(cero)");
}
else
    Console.WriteLine($"{numeroIngre} es mayor que 0(cero)");