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
    public partial class FormABMUsuarios : Form
    {
        public FormABMUsuarios()
        {
            InitializeComponent();
        }

        private void FormABMUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Employee.Employees;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            Hide();
            formLogin.Show();
            this.Close();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Employee p;
            int ID = (int)this.numericUpDown1.Value;
            p = Employee.BuscarPorID(ID);
            Employee.Employees.Remove(p);
            if (DAO.EliminarEmpleadoSql(p) == 1)
            {
                MessageBox.Show("El Empleado ha sido eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(DAO.EliminarEmpleadoSql(p) == 0)
            {
                MessageBox.Show("El Empleado es nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {MessageBox.Show("Error en la baja del empleado, informe realizado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }
    }
}
