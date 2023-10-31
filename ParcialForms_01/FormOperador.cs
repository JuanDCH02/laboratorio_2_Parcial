using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialForms_01
{
    public partial class FormOperador : Form
    {
        public FormOperador()
        {
            InitializeComponent();
        }

        private void bttnCrearProduct_Click(object sender, EventArgs e)
        {
            //crear prodct
            int index = Productos.SelectedIndex;
            int cant = (int)this.numericUpDown1.Value;

            if (index == 0)
            {
                if (Mueble.CrearMueble(cant))
                {
                    MessageBox.Show("Articulo Creado");
                }
                else
                {
                    MessageBox.Show("No se pudo Crear el Articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (index == 1)
            {

                if (Ventilador.CrearVentilador(cant))
                {
                    MessageBox.Show("Articulo Creado");
                }
                else
                {
                    MessageBox.Show("No se pudo Crear el Articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bttnStock_Click(object sender, EventArgs e)
        {
            //ver stock
            StringBuilder sb = new();
            sb.AppendLine("El Stock de Productos actual es:\n");
            sb.AppendLine(Stock.Mostrar());
            MessageBox.Show(sb.ToString());
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            //salir
            FormLogin formLogin = new FormLogin();
            Hide();
            DialogResult result = formLogin.ShowDialog();
        }

        private void FormOperador_Load(object sender, EventArgs e)
        {
            string[] p = { "Mueble", "Ventilador" };
            Productos.Items.AddRange(p);
            Productos.SelectedIndex = 0;
        }
    }
}
