using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaBuilder_ExamenP2
{
    public abstract class Materiales
    {
        protected string descripcion;
        public string Descripcion { get { return descripcion; } }
    }
    public class Basicos : Materiales
    {
        public Basicos()
        {
            descripcion = "Utilizar de Materiales: arena, varillas, piedras, cemento y zinc.";
            Console.WriteLine(descripcion);
        }
    }
    public class Pesados : Materiales
    {
        public Pesados()
        {
            descripcion = "Utilizar de Materiales: angulos, vigas, correas y cemento.";
            Console.WriteLine(descripcion);
        }
    }
    public class MuyPesados : Materiales
    {
        public MuyPesados()
        {
            descripcion = "Utilizar de Materiales: angulos, vigas, correas, laminas de acero, cemento y bloques.";
            Console.WriteLine(descripcion);
        }
    }
}
