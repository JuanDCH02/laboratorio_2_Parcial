using Biblioteca;
namespace ParcialForms_01
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void bttnIngresar_Click(object sender, EventArgs e)
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
                FormOperador formOperador = new FormOperador();
                Hide();
                formOperador.ShowDialog();
            }
            else
            {
                Employee empleado = new(this.txtClave.Text, this.txtNombre.Text, this.txtApellido.Text, EmployeeRole.Supervisor);
                FormSupervisor formSupervisor = new FormSupervisor();
                Hide();
                formSupervisor.ShowDialog();
            }
        }

        private void bttnIngresoAutomatico_Click(object sender, EventArgs e)
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
            {
                e.Cancel = false;
            }
        }
    }
}