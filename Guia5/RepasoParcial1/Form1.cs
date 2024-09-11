using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoParcial1
{
    public partial class FormPrincipal : Form
    {

        Presupuesto pedido;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {

            double precioBase = Convert.ToDouble(tbPrecioB.Text);
            int codigo = Convert.ToInt32(tbCodigo.Text);
            double largo = Convert.ToDouble(tbLargo.Text);

            Producto nuevo = null;

            if (rbBanco.Checked)
            {

                nuevo = new Banco(precioBase, largo);
                nuevo.Codigo = codigo;

            }
            else if (rbMesa.Checked) 
            {
            
                double ancho = Convert.ToDouble(tbAncho.Text);
                double grosor = Convert.ToDouble(tbGrosor.Text);

                nuevo = new Mesa(precioBase, largo, ancho, grosor);
                nuevo.Codigo = codigo;
            
            }

            if (pedido != null)
            {
                if (nuevo != null)
                {

                    pedido.AgregarProducto(nuevo);

                    cmbProducto.Items.Add(codigo);

                }

                else { MessageBox.Show("SELECCIONE UN TIPO"); }
            }
            else { MessageBox.Show("DEBE CREAR EL PRESUPUESTO"); }

        }

        private void btnIniciarPresupuesto_Click(object sender, EventArgs e)
        {

            string nombre = tbNombre.Text;
            string direccion = tbDir.Text;

            pedido = new Presupuesto(nombre, direccion);


        }

        private void btnCerrarPresupuesto_Click(object sender, EventArgs e)
        {

            if (pedido != null)
            {
                string[] lista = pedido.Resumen();


                Form2 formVer = new Form2();

                formVer.lbFVer.Items.AddRange(lista);

                formVer.ShowDialog();

                cmbProducto.Items.Clear();

                pedido = null;

            }
            else 
            {

                MessageBox.Show("DEBE CREAR EL PRESUPUESTO");
            
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            Producto selectedProducto = cmbProducto.SelectedItem as Producto;

            if(selectedProducto != null) 
            {

                pedido.QuitarProducto(selectedProducto.Codigo);

                cmbProducto.Items.Remove(selectedProducto);

                cmbProducto.Text = "";

            }




        }
    }
}
