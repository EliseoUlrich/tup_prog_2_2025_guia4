using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Clases
{
    internal abstract class Producto
    {
        protected double precioBase;
        protected double largo;
        private int codigo;
        public int Codigo
        { 
            get {return codigo; }
            set { codigo = value; }
        }
        public Producto(double precio)
        {
            precioBase = precio;
        }
        public abstract double Peso();
        public abstract double Precio();
        public override string ToString()
        {
            return Codigo.ToString();
        }

    }
}
