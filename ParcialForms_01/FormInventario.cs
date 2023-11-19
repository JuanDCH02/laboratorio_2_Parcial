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
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
            dataGVInventario.Rows[0].Cells[0].Value = Inventario.CantidadInventario("tornillo");
            dataGVInventario.Rows[0].Cells[1].Value = Inventario.CantidadInventario("madera");
            dataGVInventario.Rows[0].Cells[2].Value = Inventario.CantidadInventario("tela");
            dataGVInventario.Rows[0].Cells[3].Value = Inventario.CantidadInventario("base");
            dataGVInventario.Rows[0].Cells[4].Value = Inventario.CantidadInventario("bombilla");
            dataGVInventario.Rows[0].Cells[5].Value = Inventario.CantidadInventario("aspa");
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            if (Inventario.checkearInventario())
            {
                MessageBox.Show("Queda Poca Materia Prima", "Rellene Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            FormSupervisor formSupervisor = new FormSupervisor();
            this.Hide();
            formSupervisor.Show();
            
            this.Close();
        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Inventario.AgregarInventario();
            MessageBox.Show("Inventario Incrementado", ":D",MessageBoxButtons.OK);
        }
    }
}
