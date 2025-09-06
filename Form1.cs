using Ejercicio_1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        private Presupuesto presupuesto;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarPresu_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string direccion = tbDir.Text;
            Cliente cliente = new Cliente(nombre, direccion);
            presupuesto = new Presupuesto(cliente);
            MessageBox.Show("Presupuesto iniciado para " + nombre);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double precioBase = Convert.ToDouble(tbPrecio.Text);
            if (rbtMesa.Checked)
            {
                double largo = Convert.ToDouble(tbLargo.Text);
                double ancho = Convert.ToDouble(tbAncho.Text);
                double grosor = Convert.ToDouble(tbGrosor.Text);
                Mesa mesa = new Mesa(precioBase, largo, ancho, grosor);
                mesa.Codigo = Convert.ToInt32(tbCodigo.Text);
                presupuesto.AgregarProducto(mesa);
                cbBorrar.Items.Add(mesa);
            }
            else if (rbtBanco.Checked)
            {
                double largo = Convert.ToDouble(tbLargo.Text);
                Banco banco = new Banco(precioBase, largo);
                banco.Codigo = Convert.ToInt32(tbCodigo.Text);
                presupuesto.AgregarProducto(banco);
                
                cbBorrar.Items.Add(banco);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cbBorrar.SelectedItem is Producto productoSeleccionado)
            {
                Producto codigoSeleccionado = (Producto)cbBorrar.SelectedItem;
                if (presupuesto.QuitarProducto(codigoSeleccionado))
                {
                    cbBorrar.Items.Remove(codigoSeleccionado);
                    MessageBox.Show("Producto eliminado");
                }
                else
                { 
                    MessageBox.Show("Producto no encontrado" );
                }
            }
            else
            {
                 MessageBox.Show("Seleccione un producto para eliminar" );
            }
        }

        private void btnCerrarPresu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presupuesto cerrado. Precio total: " + presupuesto.Precio);
        }
    }
}
