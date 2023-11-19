using Biblioteca;
namespace ParcialForms_01
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BttnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Employee p = DAO.validarSiExiste(this.txtNombre.Text, this.txtApellido.Text, this.txtClave.Text);
                //Employee.Employees.Add(p);
                if (Logic.ValidarString(this.txtNombre.Text) && Logic.ValidarString(this.txtApellido.Text))
                {
                    string genero = string.Empty;
                    foreach (Control i in gbIngresoDatos.Controls)
                    {
                        if (i is RadioButton && ((RadioButton)i).Checked)
                        {
                            genero = ((RadioButton)i).Text;
                        }
                    }
                    if (genero == "Operador")
                    {

                        Employee empleado = new(this.txtClave.Text, this.txtNombre.Text, this.txtApellido.Text, EmployeeRole.Operador);
                        if (Employee.ValidarAltaEmpleado(empleado))
                        {
                            MessageBox.Show("No se pueden cargar dos veces los mismos datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Employee.Employees.Add(empleado);
                            DAO.CargarEmpleadoSql(empleado);
                            FormOperador formOperador = new FormOperador();
                            this.Hide();
                            formOperador.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        Employee empleado = new(this.txtClave.Text, this.txtNombre.Text, this.txtApellido.Text, EmployeeRole.Supervisor);
                        if (Employee.ValidarAltaEmpleado(empleado))
                        {
                            MessageBox.Show("No se pueden cargar dos veces los mismos datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Employee.Employees.Add(empleado);
                            DAO.CargarEmpleadoSql(empleado);
                            FormSupervisor formSupervisor = new FormSupervisor();
                            this.Hide();
                            formSupervisor.ShowDialog();
                            this.Close();
                        }
                    }
                }
                else
                { MessageBox.Show("Porfavor solo cargar letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            { Logic.RegistrarError("Error al validar los datos de ingreso formLogin", ex); }
        }
        private void BttnIngresoAutomatico_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "Juan";
            txtApellido.Text = "Clemente";
            txtClave.Text = "clave1";
            rbSupervisor.Checked = true;
        }
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Salir del Programa?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            { e.Cancel = true; }
        }
    }
}