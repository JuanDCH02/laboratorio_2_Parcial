namespace ParcialForms_01
{
    partial class FormInventario
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            employeeBindingSource = new BindingSource(components);
            dataGVInventario = new DataGridView();
            Tornillos = new DataGridViewTextBoxColumn();
            Madera = new DataGridViewTextBoxColumn();
            Tela = new DataGridViewTextBoxColumn();
            Bases = new DataGridViewTextBoxColumn();
            Bombillas = new DataGridViewTextBoxColumn();
            Aspas = new DataGridViewTextBoxColumn();
            bttnAgregar = new Button();
            bttnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGVInventario).BeginInit();
            SuspendLayout();
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Biblioteca.Employee);
            // 
            // dataGVInventario
            // 
            dataGVInventario.AllowUserToDeleteRows = false;
            dataGVInventario.AllowUserToResizeColumns = false;
            dataGVInventario.AllowUserToResizeRows = false;
            dataGVInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVInventario.Columns.AddRange(new DataGridViewColumn[] { Tornillos, Madera, Tela, Bases, Bombillas, Aspas });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Sitka Small", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGVInventario.DefaultCellStyle = dataGridViewCellStyle1;
            dataGVInventario.GridColor = SystemColors.ActiveBorder;
            dataGVInventario.Location = new Point(12, 12);
            dataGVInventario.Name = "dataGVInventario";
            dataGVInventario.RowTemplate.Height = 25;
            dataGVInventario.Size = new Size(642, 64);
            dataGVInventario.TabIndex = 0;
            // 
            // Tornillos
            // 
            Tornillos.HeaderText = "Tornillos";
            Tornillos.Name = "Tornillos";
            // 
            // Madera
            // 
            Madera.HeaderText = "Madera";
            Madera.Name = "Madera";
            // 
            // Tela
            // 
            Tela.HeaderText = "Tela";
            Tela.Name = "Tela";
            // 
            // Bases
            // 
            Bases.HeaderText = "Bases";
            Bases.Name = "Bases";
            // 
            // Bombillas
            // 
            Bombillas.HeaderText = "Bombillas";
            Bombillas.Name = "Bombillas";
            // 
            // Aspas
            // 
            Aspas.HeaderText = "Aspas";
            Aspas.Name = "Aspas";
            // 
            // bttnAgregar
            // 
            bttnAgregar.BackColor = SystemColors.MenuHighlight;
            bttnAgregar.Location = new Point(12, 91);
            bttnAgregar.Name = "bttnAgregar";
            bttnAgregar.Size = new Size(154, 33);
            bttnAgregar.TabIndex = 1;
            bttnAgregar.Text = "Rellenar Inventario";
            bttnAgregar.UseVisualStyleBackColor = false;
            bttnAgregar.Click += bttnAgregar_Click;
            // 
            // bttnSalir
            // 
            bttnSalir.BackColor = SystemColors.MenuHighlight;
            bttnSalir.Location = new Point(500, 91);
            bttnSalir.Name = "bttnSalir";
            bttnSalir.Size = new Size(154, 33);
            bttnSalir.TabIndex = 2;
            bttnSalir.Text = "Salir";
            bttnSalir.UseVisualStyleBackColor = false;
            bttnSalir.Click += bttnSalir_Click;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(662, 136);
            Controls.Add(bttnSalir);
            Controls.Add(bttnAgregar);
            Controls.Add(dataGVInventario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInventario";
            Load += FormInventario_Load;
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGVInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource employeeBindingSource;
        private DataGridView dataGVInventario;
        private DataGridViewTextBoxColumn Tornillos;
        private DataGridViewTextBoxColumn Madera;
        private DataGridViewTextBoxColumn Tela;
        private DataGridViewTextBoxColumn Bases;
        private DataGridViewTextBoxColumn Bombillas;
        private DataGridViewTextBoxColumn Aspas;
        private Button bttnAgregar;
        private Button bttnSalir;
    }
}