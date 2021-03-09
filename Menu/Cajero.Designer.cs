
namespace Menu
{
    partial class Cajero
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cajero));
			this.btnCerrarCajero = new System.Windows.Forms.Button();
			this.btnIniciarVenta = new System.Windows.Forms.Button();
			this.lblmensajeCajero = new System.Windows.Forms.Label();
			this.lblCajero = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCerrarCaja = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCerrarCajero
			// 
			this.btnCerrarCajero.Location = new System.Drawing.Point(15, 149);
			this.btnCerrarCajero.Name = "btnCerrarCajero";
			this.btnCerrarCajero.Size = new System.Drawing.Size(132, 24);
			this.btnCerrarCajero.TabIndex = 27;
			this.btnCerrarCajero.Text = "Cerrar Sesion";
			this.btnCerrarCajero.UseVisualStyleBackColor = true;
			this.btnCerrarCajero.Click += new System.EventHandler(this.btcerrarCajero_Click);
			// 
			// btnIniciarVenta
			// 
			this.btnIniciarVenta.Location = new System.Drawing.Point(15, 42);
			this.btnIniciarVenta.Name = "btnIniciarVenta";
			this.btnIniciarVenta.Size = new System.Drawing.Size(132, 24);
			this.btnIniciarVenta.TabIndex = 21;
			this.btnIniciarVenta.Text = "Iniciar Venta";
			this.btnIniciarVenta.UseVisualStyleBackColor = true;
			this.btnIniciarVenta.Click += new System.EventHandler(this.btnIniciarVenta_Click);
			// 
			// lblmensajeCajero
			// 
			this.lblmensajeCajero.AutoSize = true;
			this.lblmensajeCajero.BackColor = System.Drawing.Color.Transparent;
			this.lblmensajeCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmensajeCajero.Location = new System.Drawing.Point(93, 23);
			this.lblmensajeCajero.Name = "lblmensajeCajero";
			this.lblmensajeCajero.Size = new System.Drawing.Size(0, 13);
			this.lblmensajeCajero.TabIndex = 29;
			// 
			// lblCajero
			// 
			this.lblCajero.AutoSize = true;
			this.lblCajero.BackColor = System.Drawing.Color.Transparent;
			this.lblCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCajero.Location = new System.Drawing.Point(12, 18);
			this.lblCajero.Name = "lblCajero";
			this.lblCajero.Size = new System.Drawing.Size(61, 20);
			this.lblCajero.TabIndex = 30;
			this.lblCajero.Text = "Cajero";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 13);
			this.label3.TabIndex = 33;
			this.label3.Text = "Datos de Arqueo";
			// 
			// btnCerrarCaja
			// 
			this.btnCerrarCaja.Location = new System.Drawing.Point(15, 105);
			this.btnCerrarCaja.Name = "btnCerrarCaja";
			this.btnCerrarCaja.Size = new System.Drawing.Size(132, 24);
			this.btnCerrarCaja.TabIndex = 46;
			this.btnCerrarCaja.Text = "Cierre de Caja";
			this.btnCerrarCaja.UseVisualStyleBackColor = true;
			this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(153, 18);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(190, 190);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 47;
			this.pictureBox1.TabStop = false;
			// 
			// Cajero
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::Menu.Properties.Resources.Fondo3;
			this.ClientSize = new System.Drawing.Size(371, 245);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnCerrarCaja);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblCajero);
			this.Controls.Add(this.lblmensajeCajero);
			this.Controls.Add(this.btnCerrarCajero);
			this.Controls.Add(this.btnIniciarVenta);
			this.Name = "Cajero";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cajero";
			this.Load += new System.EventHandler(this.Cajero_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrarCajero;
        private System.Windows.Forms.Button btnIniciarVenta;
        private System.Windows.Forms.Label lblmensajeCajero;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}