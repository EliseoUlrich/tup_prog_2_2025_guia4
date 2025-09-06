using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Clases
{
    internal class Mesa : Producto
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public double Grosor { get; set; }

        public Mesa(double ancho, double grosor, double largo, double precioBase):base(precioBase)
        {
            Ancho = ancho;
            Grosor = grosor;
            Largo = largo;
        }
        public override double Precio()
        {
            return Peso() * precioBase * 1.25;
        }
        public override double Peso()
        {
            return (Largo * Ancho * Grosor) * 0.3;
        }

    }
}
