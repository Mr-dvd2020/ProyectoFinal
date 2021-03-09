
namespace Menu
{
    partial class Venta
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
			this.txtCodBoleta = new System.Windows.Forms.TextBox();
			this.txtCodProducto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNroProducto = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvVentas = new System.Windows.Forms.DataGridView();
			this.btnRegistrarVenta = new System.Windows.Forms.Button();
			this.btnNuevaVenta = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtHora = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.btnGenerarVenta = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.txtNombreProducto = new System.Windows.Forms.TextBox();
			this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
			this.txtPrecioTotal = new System.Windows.Forms.TextBox();
			this.btnCompletar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// txtCodBoleta
			// 
			this.txtCodBoleta.Location = new System.Drawing.Point(12, 34);
			this.txtCodBoleta.Name = "txtCodBoleta";
			this.txtCodBoleta.Size = new System.Drawing.Size(100, 20);
			this.txtCodBoleta.TabIndex = 35;
			// 
			// txtCodProducto
			// 
			this.txtCodProducto.Location = new System.Drawing.Point(134, 34);
			this.txtCodProducto.Name = "txtCodProducto";
			this.txtCodProducto.Size = new System.Drawing.Size(100, 20);
			this.txtCodProducto.TabIndex = 36;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(13, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 39;
			this.label1.Text = "CodBoLeta";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(135, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 40;
			this.label3.Text = "CodProducto";
			// 
			// txtNroProducto
			// 
			this.txtNroProducto.Location = new System.Drawing.Point(258, 77);
			this.txtNroProducto.Name = "txtNroProducto";
			this.txtNroProducto.Size = new System.Drawing.Size(100, 20);
			this.txtNroProducto.TabIndex = 43;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(259, 61);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 13);
			this.label6.TabIndex = 44;
			this.label6.Text = "Número de Productos";
			// 
			// dgvVentas
			// 
			this.dgvVentas.AllowUserToAddRows = false;
			this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(171)))), ((int)(((byte)(189)))));
			this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVentas.Location = new System.Drawing.Point(12, 102);
			this.dgvVentas.Name = "dgvVentas";
			this.dgvVentas.Size = new System.Drawing.Size(474, 244);
			this.dgvVentas.TabIndex = 45;
			// 
			// btnRegistrarVenta
			// 
			this.btnRegistrarVenta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrarVenta.Location = new System.Drawing.Point(491, 207);
			this.btnRegistrarVenta.Name = "btnRegistrarVenta";
			this.btnRegistrarVenta.Size = new System.Drawing.Size(84, 33);
			this.btnRegistrarVenta.TabIndex = 47;
			this.btnRegistrarVenta.Text = "Vender";
			this.btnRegistrarVenta.UseVisualStyleBackColor = true;
			this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
			// 
			// btnNuevaVenta
			// 
			this.btnNuevaVenta.Location = new System.Drawing.Point(12, 361);
			this.btnNuevaVenta.Name = "btnNuevaVenta";
			this.btnNuevaVenta.Size = new System.Drawing.Size(110, 23);
			this.btnNuevaVenta.TabIndex = 48;
			this.btnNuevaVenta.Text = "Nueva Venta";
			this.btnNuevaVenta.UseVisualStyleBackColor = true;
			this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(952, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 50;
			this.label2.Text = "Hora de venta";
			// 
			// txtHora
			// 
			this.txtHora.Location = new System.Drawing.Point(951, 34);
			this.txtHora.Name = "txtHora";
			this.txtHora.Size = new System.Drawing.Size(100, 20);
			this.txtHora.TabIndex = 49;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(581, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(227, 24);
			this.label4.TabIndex = 52;
			this.label4.Text = "Productos de la Tienda";
			// 
			// dgvProductos
			// 
			this.dgvProductos.AllowUserToAddRows = false;
			this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(171)))), ((int)(((byte)(189)))));
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Location = new System.Drawing.Point(580, 102);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.Size = new System.Drawing.Size(472, 244);
			this.dgvProductos.TabIndex = 51;
			this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
			// 
			// btnGenerarVenta
			// 
			this.btnGenerarVenta.Location = new System.Drawing.Point(128, 361);
			this.btnGenerarVenta.Name = "btnGenerarVenta";
			this.btnGenerarVenta.Size = new System.Drawing.Size(104, 23);
			this.btnGenerarVenta.TabIndex = 54;
			this.btnGenerarVenta.Text = "Generar Boleta";
			this.btnGenerarVenta.UseVisualStyleBackColor = true;
			this.btnGenerarVenta.Click += new System.EventHandler(this.btnGenerarVenta_Click);
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(819, 77);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(175, 20);
			this.txtBuscar.TabIndex = 55;
			this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
			// 
			// txtNombreProducto
			// 
			this.txtNombreProducto.Location = new System.Drawing.Point(12, 77);
			this.txtNombreProducto.Name = "txtNombreProducto";
			this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
			this.txtNombreProducto.TabIndex = 57;
			// 
			// txtPrecioUnitario
			// 
			this.txtPrecioUnitario.Location = new System.Drawing.Point(134, 77);
			this.txtPrecioUnitario.Name = "txtPrecioUnitario";
			this.txtPrecioUnitario.Size = new System.Drawing.Size(100, 20);
			this.txtPrecioUnitario.TabIndex = 58;
			// 
			// txtPrecioTotal
			// 
			this.txtPrecioTotal.Location = new System.Drawing.Point(386, 77);
			this.txtPrecioTotal.Name = "txtPrecioTotal";
			this.txtPrecioTotal.Size = new System.Drawing.Size(100, 20);
			this.txtPrecioTotal.TabIndex = 59;
			// 
			// btnCompletar
			// 
			this.btnCompletar.Location = new System.Drawing.Point(411, 32);
			this.btnCompletar.Name = "btnCompletar";
			this.btnCompletar.Size = new System.Drawing.Size(75, 23);
			this.btnCompletar.TabIndex = 60;
			this.btnCompletar.Text = "Precio Total";
			this.btnCompletar.UseVisualStyleBackColor = true;
			this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(942, 361);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 23);
			this.button1.TabIndex = 61;
			this.button1.Text = "Salir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(999, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 62;
			this.label5.Text = "Buscador";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(386, 363);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 63;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(292, 366);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 13);
			this.label7.TabIndex = 64;
			this.label7.Text = "Monto Total (S/.)";
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(623, 364);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(100, 20);
			this.txtStock.TabIndex = 65;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(582, 367);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 66;
			this.label8.Text = "Stock";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(12, 61);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(44, 13);
			this.label9.TabIndex = 67;
			this.label9.Text = "Nombre";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(135, 61);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(76, 13);
			this.label10.TabIndex = 68;
			this.label10.Text = "Precio Unitario";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(387, 61);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(64, 13);
			this.label11.TabIndex = 69;
			this.label11.Text = "Precio Total";
			// 
			// Venta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::Menu.Properties.Resources.Fondo2;
			this.ClientSize = new System.Drawing.Size(1066, 392);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnCompletar);
			this.Controls.Add(this.txtPrecioTotal);
			this.Controls.Add(this.txtPrecioUnitario);
			this.Controls.Add(this.txtNombreProducto);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.btnGenerarVenta);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtHora);
			this.Controls.Add(this.btnNuevaVenta);
			this.Controls.Add(this.btnRegistrarVenta);
			this.Controls.Add(this.dgvVentas);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtNroProducto);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCodProducto);
			this.Controls.Add(this.txtCodBoleta);
			this.Name = "Venta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Venta";
			this.Load += new System.EventHandler(this.Venta_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodBoleta;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnGenerarVenta;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}