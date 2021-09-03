using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaBuilder_ExamenP2
{
    //Esta clase maneja todo de forma abstracta
    //Clase donde se aplica el patron Builder y donde se nos permitira implementar tres operaciones abstractas,
    //las cuales devolveran "planos", "materiales" y "maquinaria"
    public abstract class ConstruccionBuilder
    {
        protected string descripcion;
        public abstract Planos BuildPlanos();
        public abstract Materiales BuildMateriales();
        public abstract Maquinaria BuildMaquinaria();
        
        public override string ToString()
        {
            return descripcion;
        }
        //Esta operacion concreta permitira generar "planos", "materiales" y "maquinaria", a partir de la invocacion
        //de las invocaciones abstractas, esto es posible gracias al principio del patron Builder que nos permite 
        //producir diferentes tipos de un objeto utilizando el mismo código de construcción
        public Construccion BuildConstruccion()
        {
            Planos planos = BuildPlanos();
            Materiales materiales = BuildMateriales();
            Maquinaria maquinaria = BuildMaquinaria();

            return new Construccion(planos, materiales, maquinaria, descripcion);
        }
    }
}
