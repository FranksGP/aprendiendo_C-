// See https://aka.ms/new-console-template for more information
float num1, num2;
Console.WriteLine("Ingresa el un numero: ");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingresa otro numero: ");
num2 = float.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"{num1} es mayor que {num2}");
}
else if (num2 > num1)
{
    Console.WriteLine($"{num2} es mayor que {num1}");
}
else
    Console.WriteLine($"{num1} es igual que {num2}");



