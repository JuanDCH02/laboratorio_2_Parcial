namespace ParcialForms_01
{
    partial class FormOperador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperador));
            Productos = new ListBox();
            numericUpDown1 = new NumericUpDown();
            bttnCrearProduct = new Button();
            bttnSalir = new Button();
            bttnStock = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Productos
            // 
            Productos.BackColor = SystemColors.ControlLight;
            Productos.FormattingEnabled = true;
            Productos.ItemHeight = 15;
            Productos.Location = new Point(66, 22);
            Productos.Name = "Productos";
            Productos.Size = new Size(326, 94);
            Productos.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.ControlLight;
            numericUpDown1.Location = new Point(142, 186);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(154, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // bttnCrearProduct
            // 
            bttnCrearProduct.BackColor = SystemColors.MenuHighlight;
            bttnCrearProduct.Location = new Point(142, 274);
            bttnCrearProduct.Name = "bttnCrearProduct";
            bttnCrearProduct.Size = new Size(154, 33);
            bttnCrearProduct.TabIndex = 2;
            bttnCrearProduct.Text = "Crear Producto";
            bttnCrearProduct.UseVisualStyleBackColor = false;
            bttnCrearProduct.Click += bttnCrearProduct_Click;
            // 
            // bttnSalir
            // 
            bttnSalir.BackColor = SystemColors.MenuHighlight;
            bttnSalir.Location = new Point(142, 352);
            bttnSalir.Name = "bttnSalir";
            bttnSalir.Size = new Size(154, 33);
            bttnSalir.TabIndex = 3;
            bttnSalir.Text = "Salir";
            bttnSalir.UseVisualStyleBackColor = false;
            bttnSalir.Click += bttnSalir_Click;
            // 
            // bttnStock
            // 
            bttnStock.BackColor = SystemColors.MenuHighlight;
            bttnStock.Location = new Point(142, 313);
            bttnStock.Name = "bttnStock";
            bttnStock.Size = new Size(154, 33);
            bttnStock.TabIndex = 4;
            bttnStock.Text = "Ver Stock";
            bttnStock.UseVisualStyleBackColor = false;
            bttnStock.Click += bttnStock_Click;
            // 
            // FormOperador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(448, 436);
            Controls.Add(bttnStock);
            Controls.Add(bttnSalir);
            Controls.Add(bttnCrearProduct);
            Controls.Add(numericUpDown1);
            Controls.Add(Productos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormOperador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOperador";
            Load += FormOperador_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox Productos;
        private NumericUpDown numericUpDown1;
        private Button bttnCrearProduct;
        private Button bttnSalir;
        private Button bttnStock;
    }
}