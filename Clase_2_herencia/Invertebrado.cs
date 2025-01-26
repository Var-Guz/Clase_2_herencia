
namespace Clase_2_herencia
{
    internal class Invertebrado : Animal
    {
        public string? Tipo { get; set; }
        public bool TienePatas { get; set; }
        public int NumeroPatas { get; set; }
        public bool TieneConcha { get; set; }
        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamano: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Tiene Patas: {(TienePatas ? "si" : "no")}");

            if (TienePatas)
            {
                Console.WriteLine($"Tiene Patas: {TienePatas}");
            }
        }

    }
}
