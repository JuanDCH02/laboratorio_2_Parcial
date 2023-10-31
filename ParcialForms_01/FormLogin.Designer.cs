namespace ParcialForms_01
{
    partial class FormLogin
    {
        public string nameUser;
        public string surnameUser;
        public int idUser;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            bttnIngresar = new Button();
            gbIngresoDatos = new GroupBox();
            txtClave = new TextBox();
            lblid = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            rbOperador = new RadioButton();
            rbSupervisor = new RadioButton();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            bttnIngresoAutomatico = new Button();
            gbIngresoDatos.SuspendLayout();
            SuspendLayout();
            // 
            // bttnIngresar
            // 
            bttnIngresar.BackColor = SystemColors.MenuHighlight;
            bttnIngresar.Location = new Point(117, 259);
            bttnIngresar.Name = "bttnIngresar";
            bttnIngresar.Size = new Size(99, 36);
            bttnIngresar.TabIndex = 0;
            bttnIngresar.Text = "Ingresar";
            bttnIngresar.UseVisualStyleBackColor = false;
            bttnIngresar.Click += bttnIngresar_Click;
            // 
            // gbIngresoDatos
            // 
            gbIngresoDatos.BackColor = SystemColors.GradientActiveCaption;
            gbIngresoDatos.Controls.Add(txtClave);
            gbIngresoDatos.Controls.Add(lblid);
            gbIngresoDatos.Controls.Add(lblApellido);
            gbIngresoDatos.Controls.Add(lblNombre);
            gbIngresoDatos.Controls.Add(rbOperador);
            gbIngresoDatos.Controls.Add(rbSupervisor);
            gbIngresoDatos.Controls.Add(txtApellido);
            gbIngresoDatos.Controls.Add(txtNombre);
            gbIngresoDatos.Location = new Point(58, 25);
            gbIngresoDatos.Name = "gbIngresoDatos";
            gbIngresoDatos.Size = new Size(200, 197);
            gbIngresoDatos.TabIndex = 1;
            gbIngresoDatos.TabStop = false;
            gbIngresoDatos.Text = "Ingreso Datos";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(94, 92);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 24);
            txtClave.TabIndex = 7;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(6, 97);
            lblid.Name = "lblid";
            lblid.Size = new Size(37, 15);
            lblid.TabIndex = 6;
            lblid.Text = "Clave";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(6, 65);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(52, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // rbOperador
            // 
            rbOperador.AutoSize = true;
            rbOperador.Location = new Point(94, 147);
            rbOperador.Name = "rbOperador";
            rbOperador.Size = new Size(78, 19);
            rbOperador.TabIndex = 4;
            rbOperador.TabStop = true;
            rbOperador.Text = "Operador";
            rbOperador.UseVisualStyleBackColor = true;
            // 
            // rbSupervisor
            // 
            rbSupervisor.AutoSize = true;
            rbSupervisor.Location = new Point(94, 122);
            rbSupervisor.Name = "rbSupervisor";
            rbSupervisor.Size = new Size(82, 19);
            rbSupervisor.TabIndex = 2;
            rbSupervisor.TabStop = true;
            rbSupervisor.Text = "Supervisor";
            rbSupervisor.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(94, 62);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 24);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(94, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 24);
            txtNombre.TabIndex = 0;
            // 
            // bttnIngresoAutomatico
            // 
            bttnIngresoAutomatico.BackColor = SystemColors.MenuHighlight;
            bttnIngresoAutomatico.Location = new Point(98, 301);
            bttnIngresoAutomatico.Name = "bttnIngresoAutomatico";
            bttnIngresoAutomatico.Size = new Size(132, 36);
            bttnIngresoAutomatico.TabIndex = 4;
            bttnIngresoAutomatico.Text = "Ingreso Automatico";
            bttnIngresoAutomatico.UseVisualStyleBackColor = false;
            bttnIngresoAutomatico.Click += bttnIngresoAutomatico_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(324, 384);
            Controls.Add(bttnIngresoAutomatico);
            Controls.Add(gbIngresoDatos);
            Controls.Add(bttnIngresar);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "lngrese sus Datos";
            FormClosing += FormLogin_FormClosing;
            gbIngresoDatos.ResumeLayout(false);
            gbIngresoDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bttnIngresar;
        private GroupBox gbIngresoDatos;
        private Label lblNombre;
        private RadioButton rbOperador;
        private RadioButton rbSupervisor;
        private TextBox txtApellido;
        private TextBox txtNombre;

        private Label lblApellido;
        private Button bttnIngresoAutomatico;
        private Label lblid;
        private TextBox txtClave;
    }
}