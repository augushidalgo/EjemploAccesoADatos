namespace CapaPresentacion
{
    partial class Form1
    {
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
            dgvProductos = new DataGridView();
            label1 = new Label();
            txtnombre = new TextBox();
            label2 = new Label();
            txtdescripcion = new TextBox();
            label3 = new Label();
            txtmarca = new TextBox();
            label4 = new Label();
            txtprecio = new TextBox();
            label5 = new Label();
            txtstock = new TextBox();
            btnguardar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(723, 414);
            dgvProductos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(756, 38);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(845, 31);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(235, 27);
            txtnombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(749, 85);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "Descripción:";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(845, 78);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(235, 27);
            txtdescripcion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(756, 133);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Marca:";
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(845, 125);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(235, 27);
            txtmarca.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(756, 179);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 7;
            label4.Text = "Precio:";
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(845, 172);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(235, 27);
            txtprecio.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(761, 233);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 9;
            label5.Text = "Stock:";
            // 
            // txtstock
            // 
            txtstock.Location = new Point(845, 226);
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(235, 27);
            txtstock.TabIndex = 10;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(845, 282);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(94, 29);
            btnguardar.TabIndex = 11;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(845, 317);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnguardar);
            Controls.Add(txtstock);
            Controls.Add(label5);
            Controls.Add(txtprecio);
            Controls.Add(label4);
            Controls.Add(txtmarca);
            Controls.Add(label3);
            Controls.Add(txtdescripcion);
            Controls.Add(label2);
            Controls.Add(txtnombre);
            Controls.Add(label1);
            Controls.Add(dgvProductos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label label1;
        private TextBox txtnombre;
        private Label label2;
        private TextBox txtdescripcion;
        private Label label3;
        private TextBox txtmarca;
        private Label label4;
        private TextBox txtprecio;
        private Label label5;
        private TextBox txtstock;
        private Button btnguardar;
        private Button btnEliminar;
    }
}
