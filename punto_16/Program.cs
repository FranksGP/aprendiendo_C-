// See https://aka.ms/new-console-template for more information
float num1 = 0, num2 = 0, total=0;
Console.WriteLine("Bienvenio. Por favor, ingresa un numero: ");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Por favor, ingresa otro numero: ");
num2 = float.Parse(Console.ReadLine());

if (num1 == num2)
{
    total = num1 - num2;
    Console.WriteLine($"Los numeros son Iguales. la resto de estos numeros es: {total}");
}
else if (num1 != num2)
{
    total = num1 + num2;
    Console.WriteLine($"Los dos numeros ingresados son diferesntes . La suma de estos numeros es: {total}");
}
else
    Console.WriteLine("Por favor ingresa un numero valido");