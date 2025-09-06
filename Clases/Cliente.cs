using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Clases
{
    internal class Cliente
    {
        public string nombre { get; set; }
        public string direccion { get; set; }

        public Cliente(string nom, string dir)
        {
            nombre = nom;
            direccion = dir;
        }
        public override string ToString()
        {
            return "Nombre: " + nombre + " Direccion: " + direccion;
        }
    }
}
