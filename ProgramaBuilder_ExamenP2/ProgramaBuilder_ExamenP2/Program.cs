using System;

namespace ProgramaBuilder_ExamenP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patron de Diseño Builder!");
            //Por ultimo, implementamos las instancias de los objetos que construimos,
            //en nuestra parte principal del programa, asi como tambien, el metodo Build
            //Objeto "Casa"
            CasaBuilder casa = new CasaBuilder();
            casa.BuildConstruccion();
            //Objeto "Comercial"
            CentroComercialBuilder comercial = new CentroComercialBuilder();
            comercial.BuildConstruccion();
            //Objeto "Fabrica"
            //En esta parte utilizamos los metodos Build con el fin de demostrar que
            //se puede hacer uso de estos, aunque con fines practicos conviene utilizar
            //el planteado con el patron
            FabricaBuilder fabrica = new FabricaBuilder();
            fabrica.BuildPlanos();
            fabrica.BuildMateriales();
            fabrica.BuildMaquinaria();

        }
    }
}
