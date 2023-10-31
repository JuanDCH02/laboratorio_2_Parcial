using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace ParcialForms_01
{
    public partial class FormSupervisor : Form
    {
        public FormSupervisor()
        {
            InitializeComponent();
        }

        private void FormSupervisor_Load(object sender, EventArgs e)
        {
            if (Inventario.checkearInventario())
            {
                MessageBox.Show("Queda Poca Materia Prima", "Rellene Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string[] p = { "Mueble", "Ventilador" };
            Productos.Items.AddRange(p);
            Productos.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
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
            if (Inventario.checkearInventario())
            {
                MessageBox.Show("Queda Poca Materia Prima", "Rellene Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ver inv
            FormInventario formInventario = new FormInventario();
            Hide();
            DialogResult result = formInventario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //salir
            FormLogin formLogin = new FormLogin();
            Hide();
            DialogResult result = formLogin.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormSupervisor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Salir del Programa?", "Confirmacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = false;
            }
        }

        private void bttnStock_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new();
            sb.AppendLine("El Stock de Productos actual es:\n");
            sb.AppendLine(Stock.Mostrar());
            MessageBox.Show(sb.ToString());
        }
    }

}
