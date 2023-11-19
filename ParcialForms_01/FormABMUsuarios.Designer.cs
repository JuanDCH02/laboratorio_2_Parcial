namespace ParcialForms_01
{
    partial class FormABMUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtClave = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            btnSalir = new Button();
            numericUpDown1 = new NumericUpDown();
            BtnModificar = new Button();
            rbOperador = new RadioButton();
            btnBorrar = new Button();
            rbSupervisor = new RadioButton();
            btnCrear = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(101, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 23);
            txtNombre.TabIndex = 1;

            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(101, 106);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(152, 23);
            txtApellido.TabIndex = 2;

            // 
            // txtClave
            // 
            txtClave.Location = new Point(101, 135);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(152, 23);
            txtClave.TabIndex = 3;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(23, 80);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(23, 109);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 138);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 6;
            label3.Text = "Clave";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(BtnModificar);
            groupBox1.Controls.Add(rbOperador);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(rbSupervisor);
            groupBox1.Controls.Add(btnCrear);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtClave);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 244);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 34);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 10;
            label4.Text = "ID a Modificar/Borrar";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.MenuHighlight;
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSalir.Location = new Point(326, 159);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(154, 33);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(138, 32);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(115, 23);
            numericUpDown1.TabIndex = 9;
            // 
            // BtnModificar
            // 
            BtnModificar.BackColor = SystemColors.MenuHighlight;
            BtnModificar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BtnModificar.Location = new Point(326, 120);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(154, 33);
            BtnModificar.TabIndex = 10;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = false;
            // 
            // rbOperador
            // 
            rbOperador.AutoSize = true;
            rbOperador.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbOperador.Location = new Point(137, 198);
            rbOperador.Name = "rbOperador";
            rbOperador.Size = new Size(78, 19);
            rbOperador.TabIndex = 8;
            rbOperador.TabStop = true;
            rbOperador.Text = "Operador";
            rbOperador.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = SystemColors.MenuHighlight;
            btnBorrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBorrar.Location = new Point(326, 81);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(154, 33);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // rbSupervisor
            // 
            rbSupervisor.AutoSize = true;
            rbSupervisor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbSupervisor.Location = new Point(137, 173);
            rbSupervisor.Name = "rbSupervisor";
            rbSupervisor.Size = new Size(82, 19);
            rbSupervisor.TabIndex = 7;
            rbSupervisor.TabStop = true;
            rbSupervisor.Text = "Supervisor";
            rbSupervisor.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.MenuHighlight;
            btnCrear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCrear.Location = new Point(326, 42);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(154, 33);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(500, 150);
            dataGridView1.TabIndex = 12;
            // 
            // FormABMUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(564, 459);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "FormABMUsuarios";
            Text = "FormABMUsuarios";
            Load += FormABMUsuarios_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtClave;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rbOperador;
        private RadioButton rbSupervisor;
        private Button btnCrear;
        private Button btnBorrar;
        private Button BtnModificar;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private Label label4;
    }
}