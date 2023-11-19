namespace ParcialForms_01
{
    partial class FormSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupervisor));
            bttnCrearProduct = new Button();
            bttnInventario = new Button();
            bttnSalir = new Button();
            numericUpDown1 = new NumericUpDown();
            Productos = new ListBox();
            label1 = new Label();
            bttnStock = new Button();
            bttnUsers = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // bttnCrearProduct
            // 
            bttnCrearProduct.BackColor = SystemColors.MenuHighlight;
            bttnCrearProduct.Location = new Point(142, 274);
            bttnCrearProduct.Name = "bttnCrearProduct";
            bttnCrearProduct.Size = new Size(154, 33);
            bttnCrearProduct.TabIndex = 0;
            bttnCrearProduct.Text = "Crear Productos";
            bttnCrearProduct.UseVisualStyleBackColor = false;
            bttnCrearProduct.Click += bttnCrearProduct_Click;
            // 
            // bttnInventario
            // 
            bttnInventario.BackColor = SystemColors.MenuHighlight;
            bttnInventario.ForeColor = SystemColors.ControlText;
            bttnInventario.Location = new Point(142, 313);
            bttnInventario.Name = "bttnInventario";
            bttnInventario.Size = new Size(154, 33);
            bttnInventario.TabIndex = 1;
            bttnInventario.Text = "Ver Inventario";
            bttnInventario.UseVisualStyleBackColor = false;
            bttnInventario.Click += bttnInventario_Click;
            // 
            // bttnSalir
            // 
            bttnSalir.BackColor = SystemColors.MenuHighlight;
            bttnSalir.Location = new Point(142, 391);
            bttnSalir.Name = "bttnSalir";
            bttnSalir.Size = new Size(154, 33);
            bttnSalir.TabIndex = 2;
            bttnSalir.Text = "Salir";
            bttnSalir.UseVisualStyleBackColor = false;
            bttnSalir.Click += bttnSalir_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.ControlLight;
            numericUpDown1.Location = new Point(142, 192);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(154, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // Productos
            // 
            Productos.BackColor = SystemColors.ControlLight;
            Productos.FormattingEnabled = true;
            Productos.ItemHeight = 15;
            Productos.Location = new Point(66, 22);
            Productos.Name = "Productos";
            Productos.Size = new Size(326, 94);
            Productos.TabIndex = 4;
            Productos.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // bttnStock
            // 
            bttnStock.BackColor = SystemColors.MenuHighlight;
            bttnStock.Location = new Point(142, 352);
            bttnStock.Name = "bttnStock";
            bttnStock.Size = new Size(154, 33);
            bttnStock.TabIndex = 8;
            bttnStock.Text = "Ver Stock";
            bttnStock.UseVisualStyleBackColor = false;
            bttnStock.Click += bttnStock_Click;
            // 
            // bttnUsers
            // 
            bttnUsers.BackColor = SystemColors.MenuHighlight;
            bttnUsers.Location = new Point(142, 235);
            bttnUsers.Name = "bttnUsers";
            bttnUsers.Size = new Size(154, 33);
            bttnUsers.TabIndex = 9;
            bttnUsers.Text = "Ver Usuarios";
            bttnUsers.UseVisualStyleBackColor = false;
            bttnUsers.Click += bttnUsers_Click_1;
            // 
            // FormSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(448, 436);
            Controls.Add(bttnUsers);
            Controls.Add(bttnStock);
            Controls.Add(label1);
            Controls.Add(Productos);
            Controls.Add(numericUpDown1);
            Controls.Add(bttnSalir);
            Controls.Add(bttnInventario);
            Controls.Add(bttnCrearProduct);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSupervisor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sala de Produccion";
            Load += FormSupervisor_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button bttnCrearProduct;
        private Button bttnInventario;
        private Button bttnSalir;
        private NumericUpDown numericUpDown1;
        private ListBox Productos;
        private Label label1;
        private Button bttnStock;
        private Button bttnUsers;
    }
}