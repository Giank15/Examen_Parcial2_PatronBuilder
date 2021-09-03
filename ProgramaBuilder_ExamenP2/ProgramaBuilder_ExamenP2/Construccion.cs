using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaBuilder_ExamenP2
{
    //Clase concreta que tendra relacion con el resto de clases generales y que se utilizara como modelo para cada objeto que creemos
    public class Construccion
    {
        //Clase generales que seran usadas por cada objeto que vayamos a crear
        Planos plano;
        Materiales material;
        Maquinaria maquinas;
        string tipo;

        public override string ToString()
        {
            return $"{tipo}, Plano: {plano.Descripcion} \nMateriales: {material.Descripcion} \nMaquinas: {maquinas.Descripcion}";
        }
        //Constructor de tipo Construccion y recibe por parametros planos, materiales, maquinarias y el tipo de objeto
        public Construccion(Planos planos, Materiales materiales, Maquinaria maquinaria, string tipos)
        {
            plano = planos;
            material = materiales;
            maquinas = maquinaria;
            tipo = tipos;
        }
    }
}
