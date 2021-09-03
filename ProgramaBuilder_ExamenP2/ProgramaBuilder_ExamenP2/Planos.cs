using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaBuilder_ExamenP2
{
    //Clase general que permite describir que tipo de "plano" es independientemente del objeto
    public abstract class Planos
    {
        protected string descripcion;
        public string Descripcion { get { return descripcion; } }
    }
    //Metodos especificos usados para cada objeto diferente
    public class EstructuraPequeña : Planos
    {
        public EstructuraPequeña()
        {
            descripcion = "Planos de Estructura Pequeña Tipo Residencial...";
            Console.WriteLine(descripcion);
        }
    }
    public class EstructuraMedia : Planos
    {
        public EstructuraMedia()
        {
            descripcion = "Planos de Estructura Media Tipo Comercial...";
            Console.WriteLine(descripcion);
        }
    }
    public class EstructuraGrande : Planos
    {
        public EstructuraGrande()
        {
            descripcion = "Planos de Estructura Grande Tipo Industrial...";
            Console.WriteLine(descripcion);
        }
    }
}
