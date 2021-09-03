using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaBuilder_ExamenP2
{
    //Implementacion concreta de las construcciones
    public class CasaBuilder : ConstruccionBuilder
    {
        //Esta clase nos obliga a implementar las construcciones de las clases generales,
        //ahora si, permitiendose usar los metodos especificos dependiendo de cada caso
        public CasaBuilder()
        {
            descripcion = "\nConstruccion de Casa";
            Console.WriteLine(descripcion);
        }
        //Como esta clase maneja una "casa", devolvemos las instancias correspondientes
        //a dicho tipo de cosntruccion
        public override Planos BuildPlanos()
        {
            return new EstructuraPequeña();
        }
        public override Materiales BuildMateriales()
        {
            return new Basicos();
        }
        public override Maquinaria BuildMaquinaria()
        {
            return new Liviana();
        }
    }
}
