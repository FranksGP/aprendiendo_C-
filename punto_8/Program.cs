// See https://aka.ms/new-console-template for more information
Console.WriteLine("---------------calculadora de promedios---------------");
int val1,val2,val3,val4,val5,result;
Console.WriteLine("Ingrese un valor el primer valor");
val1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un valor el segundo valor");
val2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un valor el tercer valor");
val3 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un valor el cuarto valor");
val4 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un valor el quinto valor");
val5 = int.Parse(Console.ReadLine());

result = (val1 + val2 + val3 + val4 + val5);
Console.WriteLine("El resultado de la suma es: " + result);