
using Clase_2_herencia;

Vertebrado vertebrado = new Vertebrado();
Invertebrado invertebrado = new Invertebrado();
int opcion;

Console.WriteLine("*************************");
Console.WriteLine("**          menu          **");
Console.WriteLine("*1 Animal Vertebrado*");
Console.WriteLine("*2 Animal Invertebrado*");
Console.WriteLine("*************************");

opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Escriba el nombre:");
        vertebrado.Nombre = Console.ReadLine();

        Console.WriteLine("Escriba el COLOR:");
        vertebrado.Color = Console.ReadLine();

        Console.WriteLine("Escriba el Tamano:");
        vertebrado.Tamano = Console.ReadLine();

        Console.WriteLine("Escriba la familia:");
        vertebrado.Nombre = Console.ReadLine();

        break;

}


