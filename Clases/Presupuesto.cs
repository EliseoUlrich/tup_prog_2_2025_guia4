using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Clases
{
    internal class Presupuesto
    {
        private List<Producto> productos = new List<Producto>();

        public double Precio
        {
            get { return productos.Sum(p => p.Precio()); }
        }
        public Cliente Cliente { get; set; }

        public Presupuesto(Cliente cliente)
        { 
            Cliente = cliente;
        }
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }
        public bool QuitarProducto(Producto producto)
        {
            Producto encontrado = BuscarProducto(producto.Codigo);
            if (encontrado != null)
            {
                productos.Remove(encontrado);
                return true;
            }
             return false;
        }
        private Producto BuscarProducto(int codigo)
        {
            productos.Sort((p1, p2) => p1.Codigo.CompareTo(p2.Codigo));
            int izquierda = 0;
            int derecha = productos.Count - 1;
            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                Producto actual = productos[medio];
                int comparacion = codigo.CompareTo(actual.Codigo);

                if (comparacion == 0)
                { return actual;
                }
                else if (comparacion < 0)
                {
                    derecha = medio - 1;
                }
                else
                {
                    izquierda = medio + 1;
                }

            }
            return null;
        }
        public string Resumen()
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cliente : {Cliente.nombre} - Direccion {Cliente.direccion}");
            sb.AppendLine("Produtos:");

            foreach (var producto in productos)
            {
                sb.AppendLine($"Codigo: {producto.Codigo} - Precio: {producto.Precio():C}");
            }
            return sb.ToString();
        }
    }
}
