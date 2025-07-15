// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Bienvenido.\n");
float Nota1 = 0, nota2 = 0, nota3 = 0, notaFinal = 0;
var promedio = 4.0d;
string codigoEstudiante, nombreEstudiante, asignatura;
Console.WriteLine("Por favor, ingresa el CODIGO del estudiante: ");
codigoEstudiante = Console.ReadLine();
Console.WriteLine("Por favor ingresa el NOMBRE de le estuadiante:");
nombreEstudiante = Console.ReadLine();
Console.WriteLine("Por favor Ingresa el NOMBRE DE LA ASIGNATURA: ");
asignatura = Console.ReadLine();
Console.WriteLine($"El estudiante -{nombreEstudiante}- con codigo -{codigoEstudiante}-\nha ingresado a la asignatura -{asignatura}-, por favor ingresa las notas del estudiante:\n");
Console.WriteLine("Nota 1: \t");
Nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Nota 2: \t");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Nota 3: \t");
nota3 = float.Parse(Console.ReadLine());

notaFinal = (Nota1 + nota2 + nota3) / 3;
if (notaFinal >= promedio)
{
    Console.WriteLine($"El estudiante {nombreEstudiante} con codigo {codigoEstudiante}\nha APROABADO la asignatura {asignatura} con una nota final de: {notaFinal}");

}
else if (notaFinal < promedio)
{
    Console.WriteLine($"El estudiante {nombreEstudiante} con codigo {codigoEstudiante} ha REPROBADO la asignatura {asignatura} con una nota final de: {notaFinal}");
}
else
    Console.WriteLine("Parese que hubo un error, Por favor intentelo de nuevo.");
 
