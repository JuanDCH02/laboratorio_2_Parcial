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

        private void bttnCrearProduct_Click(object sender, EventArgs e)
        {
            //crear prodct
            int index = Productos.SelectedIndex;
            int cant = (int)this.numericUpDown1.Value;

            if (index == 0)
            {
                try
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
                catch (FormatException)
                {
                    MessageBox.Show("Formaro no valido para crear el Articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    Logic.RegistrarError("Error al crear el producto", ex);
                }
            }
            if (index == 1)
            {
                try
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
                catch (FormatException)
                {
                    MessageBox.Show("Formaro no valido para crear el Articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    Logic.RegistrarError("Error al crear el producto", ex);
                }                      
            }
            if (Inventario.checkearInventario())
            {
                MessageBox.Show("Queda Poca Materia Prima", "Rellene Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttnInventario_Click(object sender, EventArgs e)
        {
            //ver inv
            FormInventario formInventario = new FormInventario();
            this.Hide();
            
            formInventario.ShowDialog();
            this.Close();
        }
        private void bttnSalir_Click(object sender, EventArgs e)
        {
            //salir
            FormLogin formLogin = new FormLogin();
            this.Hide();
            
            formLogin.ShowDialog();
            this.Close();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void bttnStock_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new();
            sb.AppendLine("El Stock de Productos actual es:\n");
            sb.AppendLine(Stock.Mostrar());
            MessageBox.Show(sb.ToString());
        }
        private void bttnUsers_Click_1(object sender, EventArgs e)
        {
            //abm usuarios
            FormABMUsuarios formABMUsuarios = new FormABMUsuarios();
            this.Hide();
            formABMUsuarios.Show();
            this.Close();
            //StringBuilder sb = new();
            //sb.AppendLine("Los empleados actuales son:\n");
            //sb.AppendLine(Logic.MostrarEmpleados());
            //MessageBox.Show(sb.ToString());
        }
    }
}
