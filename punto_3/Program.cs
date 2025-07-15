// See https://aka.ms/new-console-template for more information
float X,V,T;

Console.WriteLine("Ingresa el valor de la velocidad: ");
V= float.Parse(Console.ReadLine());
Console.WriteLine("Ingresa el valor del tiempo: ");
T= float.Parse(Console.ReadLine());
X=V*T;
Console.WriteLine("El resultado es: "+ X);
