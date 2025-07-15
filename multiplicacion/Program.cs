// See https://aka.ms/new-console-template for more information
string Nombre;
int Multi1,Multi2,Multi3,Resultado;
Console.WriteLine("Por favor digite el su nombre");
Nombre=Console.ReadLine();
Console.WriteLine("Por favor digite el primer numero");
Multi1=int.Parse(Console.ReadLine());
Console.WriteLine("Por favor digite el segundo numero");
Multi2=int.Parse(Console.ReadLine());
Console.WriteLine("Por favor digite el tercer numero");
Multi3=int.Parse(Console.ReadLine());
Resultado=Multi1*Multi2*Multi3;
Console.WriteLine(Nombre+", El resultado de la opercion es: "+Resultado);

