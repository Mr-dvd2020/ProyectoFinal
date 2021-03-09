
namespace Menu
{
    partial class boleta
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
			this.Guardar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Código_Producto = new System.Windows.Forms.TextBox();
			this.Nombre_Producto = new System.Windows.Forms.TextBox();
			this.Botón_Imprimir = new System.Windows.Forms.Button();
			this.Vista_Boleta = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.Vista_Boleta)).BeginInit();
			this.SuspendLayout();
			// 
			// Guardar
			// 
			this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Guardar.Location = new System.Drawing.Point(335, 42);
			this.Guardar.Name = "Guardar";
			this.Guardar.Size = new System.Drawing.Size(75, 23);
			this.Guardar.TabIndex = 23;
			this.Guardar.Text = "Mostrar";
			this.Guardar.UseVisualStyleBackColor = false;
			this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 16);
			this.label3.TabIndex = 22;
			this.label3.Text = "Código de boleta:   ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 16);
			this.label2.TabIndex = 21;
			this.label2.Text = "Nombre del Cliente:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
			this.dateTimePicker1.Location = new System.Drawing.Point(264, 17);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
			this.dateTimePicker1.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 16);
			this.label1.TabIndex = 19;
			this.label1.Text = "Nombre del Cajero:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(161, 17);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(60, 20);
			this.textBox1.TabIndex = 18;
			// 
			// Código_Producto
			// 
			this.Código_Producto.Location = new System.Drawing.Point(161, 69);
			this.Código_Producto.Name = "Código_Producto";
			this.Código_Producto.Size = new System.Drawing.Size(163, 20);
			this.Código_Producto.TabIndex = 17;
			// 
			// Nombre_Producto
			// 
			this.Nombre_Producto.Location = new System.Drawing.Point(161, 43);
			this.Nombre_Producto.Name = "Nombre_Producto";
			this.Nombre_Producto.Size = new System.Drawing.Size(163, 20);
			this.Nombre_Producto.TabIndex = 16;
			// 
			// Botón_Imprimir
			// 
			this.Botón_Imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Botón_Imprimir.Location = new System.Drawing.Point(335, 67);
			this.Botón_Imprimir.Name = "Botón_Imprimir";
			this.Botón_Imprimir.Size = new System.Drawing.Size(75, 23);
			this.Botón_Imprimir.TabIndex = 15;
			this.Botón_Imprimir.Text = "Imprimir";
			this.Botón_Imprimir.UseVisualStyleBackColor = false;
			this.Botón_Imprimir.Click += new System.EventHandler(this.Botón_Imprimir_Click);
			// 
			// Vista_Boleta
			// 
			this.Vista_Boleta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(141)))));
			this.Vista_Boleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Vista_Boleta.Location = new System.Drawing.Point(12, 106);
			this.Vista_Boleta.Name = "Vista_Boleta";
			this.Vista_Boleta.Size = new System.Drawing.Size(398, 132);
			this.Vista_Boleta.TabIndex = 14;
			// 
			// boleta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Menu.Properties.Resources.Fondo6;
			this.ClientSize = new System.Drawing.Size(422, 247);
			this.Controls.Add(this.Guardar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Código_Producto);
			this.Controls.Add(this.Nombre_Producto);
			this.Controls.Add(this.Botón_Imprimir);
			this.Controls.Add(this.Vista_Boleta);
			this.Name = "boleta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "boleta";
			this.Load += new System.EventHandler(this.boleta_Load);
			((System.ComponentModel.ISupportInitialize)(this.Vista_Boleta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Código_Producto;
        private System.Windows.Forms.TextBox Nombre_Producto;
        private System.Windows.Forms.Button Botón_Imprimir;
        private System.Windows.Forms.DataGridView Vista_Boleta;
    }
}