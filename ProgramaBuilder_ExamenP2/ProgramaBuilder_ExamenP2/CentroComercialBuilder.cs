using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaBuilder_ExamenP2
{
    //Esta clase maneja el mismo tipo de implementacion de la clase "CasaBuilder"
    public class CentroComercialBuilder : ConstruccionBuilder
    {
        public CentroComercialBuilder()
        {
            descripcion = "\nConstruccion de Centro Comercial";
            Console.WriteLine(descripcion);
        }
        public override Planos BuildPlanos()
        {
            return new EstructuraMedia();
        }
        public override Materiales BuildMateriales()
        {
            return new Pesados();
        }
        public override Maquinaria BuildMaquinaria()
        {
            return new Mediana();
        }
    }
}
