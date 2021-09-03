using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaBuilder_ExamenP2
{
    //Esta clase maneja el mismo tipo de implementacion de la clase "CasaBuilder"
    public class FabricaBuilder : ConstruccionBuilder
    {
        public FabricaBuilder()
        {
            descripcion = "\nConstruccion de Fabrica";
            Console.WriteLine(descripcion);
        }
        public override Planos BuildPlanos()
        {
            return new EstructuraGrande();
        }
        public override Materiales BuildMateriales()
        {
            return new MuyPesados();
        }
        public override Maquinaria BuildMaquinaria()
        {
            return new Grande();
        }
    }
}
