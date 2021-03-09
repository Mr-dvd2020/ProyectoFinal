
namespace Menu
{
    partial class Almacenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Almacenero));
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btcerrarAlmacenero = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAlmacenero = new System.Windows.Forms.Label();
            this.lblmensajeAlmacenero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(317, 343);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(513, 38);
            this.textBoxCantidad.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(45, 351);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cantidad";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(901, 277);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(200, 55);
            this.BtnModificar.TabIndex = 36;
            this.BtnModificar.Text = "Actualizar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(901, 203);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(200, 55);
            this.BtnEliminar.TabIndex = 35;
            this.BtnEliminar.Text = "Listar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(901, 136);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(200, 55);
            this.BtnAgregar.TabIndex = 34;
            this.BtnAgregar.Text = "Añadir";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(317, 277);
            this.txtUnidad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(513, 38);
            this.txtUnidad.TabIndex = 33;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(317, 207);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(513, 38);
            this.txtNombre.TabIndex = 32;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(317, 141);
            this.txtId.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(513, 38);
            this.txtId.TabIndex = 31;
            this.txtId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(45, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(45, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Unidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(45, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Código:";
            // 
            // textBoxPrecioUnitario
            // 
            this.textBoxPrecioUnitario.Location = new System.Drawing.Point(317, 410);
            this.textBoxPrecioUnitario.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxPrecioUnitario.Name = "textBoxPrecioUnitario";
            this.textBoxPrecioUnitario.Size = new System.Drawing.Size(513, 38);
            this.textBoxPrecioUnitario.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(45, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 32);
            this.label5.TabIndex = 39;
            this.label5.Text = "Precio";
            // 
            // btcerrarAlmacenero
            // 
            this.btcerrarAlmacenero.Location = new System.Drawing.Point(400, 856);
            this.btcerrarAlmacenero.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btcerrarAlmacenero.Name = "btcerrarAlmacenero";
            this.btcerrarAlmacenero.Size = new System.Drawing.Size(352, 57);
            this.btcerrarAlmacenero.TabIndex = 41;
            this.btcerrarAlmacenero.Text = "Cerrar Sesion";
            this.btcerrarAlmacenero.UseVisualStyleBackColor = true;
            this.btcerrarAlmacenero.Click += new System.EventHandler(this.btcerrarAlmacenero_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 472);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 370);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblAlmacenero
            // 
            this.lblAlmacenero.AutoSize = true;
            this.lblAlmacenero.BackColor = System.Drawing.Color.Transparent;
            this.lblAlmacenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenero.Location = new System.Drawing.Point(40, 31);
            this.lblAlmacenero.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAlmacenero.Name = "lblAlmacenero";
            this.lblAlmacenero.Size = new System.Drawing.Size(317, 61);
            this.lblAlmacenero.TabIndex = 44;
            this.lblAlmacenero.Text = "Almacenero";
            // 
            // lblmensajeAlmacenero
            // 
            this.lblmensajeAlmacenero.AutoSize = true;
            this.lblmensajeAlmacenero.Location = new System.Drawing.Point(229, 52);
            this.lblmensajeAlmacenero.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblmensajeAlmacenero.Name = "lblmensajeAlmacenero";
            this.lblmensajeAlmacenero.Size = new System.Drawing.Size(0, 32);
            this.lblmensajeAlmacenero.TabIndex = 43;
            // 
            // Almacenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1155, 930);
            this.Controls.Add(this.lblAlmacenero);
            this.Controls.Add(this.lblmensajeAlmacenero);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btcerrarAlmacenero);
            this.Controls.Add(this.textBoxPrecioUnitario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Almacenero";
            this.Text = "Almacenero";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrecioUnitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btcerrarAlmacenero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAlmacenero;
        private System.Windows.Forms.Label lblmensajeAlmacenero;
    }
}