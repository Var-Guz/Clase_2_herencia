
namespace Clase_2_herencia
{
    public class Vertebrado : Animal
    {
        public string Tipo { get; set; }
        public bool TienePatas { get; set; }
        public bool EsDomestico { get; set; }
        public bool EsHerbivoro { get; set; }
        public bool EsCarnivoro { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamano: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Tiene Patas: {(TienePatas ? "si" : "no")}");
            Console.WriteLine($"Es Domestico: {(EsDomestico ? "si" : "no")}");
            Console.WriteLine($"Es Hervivoro: {(EsHerbivoro ? "si" : "no")}");
            Console.WriteLine($"Es Carnivoro: {(EsCarnivoro ? "si" : "no")}");
        }

        

    }
} 
