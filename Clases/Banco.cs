using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Clases
{
    internal class Banco:Producto
    {
        public double Largo { get; set; }
        public Banco(double precio, double largo): base(precio)
        {
            Largo = largo;
        }
        public override double Precio()
        {
            return Peso() * precioBase * 1.15;
        }
        public override double Peso()
        {
            return (Largo * 0.25) * 0.42;
        }
    }
}
