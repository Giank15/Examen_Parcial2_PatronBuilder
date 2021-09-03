using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaBuilder_ExamenP2
{
    public abstract class Maquinaria
    {
        protected string descripcion;
        public string Descripcion { get { return descripcion; } }
    }
    public class Liviana : Maquinaria
    {
        public Liviana()
        {
            descripcion = "Utilizar de Maquinaria: soldadora, mezcladora y volqueta.";
            Console.WriteLine(descripcion);
        }
    }
    public class Mediana : Maquinaria
    {
        public Mediana()
        {
            descripcion = "Utilizar de Maquinaria: concretera, retro-excavadora y volqueta.";
            Console.WriteLine(descripcion);
        }
    }
    public class Grande : Maquinaria
    {
        public Grande()
        {
            descripcion = "Utilizar de Maquinaria: grua, concretera, retro-excavadora y volqueta.";
            Console.WriteLine(descripcion);
        }
    }
}
