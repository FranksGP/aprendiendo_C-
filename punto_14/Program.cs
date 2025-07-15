// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido al clegio Enrique Olaya Herrera");
string nombre; 
int grado;


Console.WriteLine("Ingrese el nombre del estudiante:");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese el grado del estudiante (1-11):");
grado = int.Parse(Console.ReadLine());
if (grado == 1 || grado == 2 || grado == 3 || grado == 4 || grado == 5 || grado == 6)
{
    Console.WriteLine($"El estudiante {nombre} esta en el grado {grado}°");
    Console.WriteLine($"Resive refrigerio - si");
}
else if (grado == 7 || grado == 8 || grado == 9 || grado == 10 || grado == 11)
{
    Console.WriteLine($"El estudiante {nombre} esta en el grado {grado}°");
    Console.WriteLine($"Resive refrigerio - no");
}
else
    Console.WriteLine("El grado ingresado no es valido, por favor ingrese un numero del 1 al 11");
