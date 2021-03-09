
namespace Menu
{
    partial class Administrador
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
			this.BtnActualizar = new System.Windows.Forms.Button();
			this.BtnMostrar = new System.Windows.Forms.Button();
			this.BtnCrear = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			this.BtnMostrarArqueo = new System.Windows.Forms.Button();
			this.btcerrarAdministrador = new System.Windows.Forms.Button();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.lblAdministrador = new System.Windows.Forms.Label();
			this.lblmensajeAdministrador = new System.Windows.Forms.Label();
			this.sbCrear = new System.Windows.Forms.RadioButton();
			this.rbMostrar = new System.Windows.Forms.RadioButton();
			this.rbActualizar = new System.Windows.Forms.RadioButton();
			this.rbEliminar = new System.Windows.Forms.RadioButton();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cbCargo = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnActualizar
			// 
			this.BtnActualizar.Location = new System.Drawing.Point(297, 137);
			this.BtnActualizar.Name = "BtnActualizar";
			this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
			this.BtnActualizar.TabIndex = 23;
			this.BtnActualizar.Text = "Actualizar";
			this.BtnActualizar.UseVisualStyleBackColor = true;
			this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
			// 
			// BtnMostrar
			// 
			this.BtnMostrar.Location = new System.Drawing.Point(297, 106);
			this.BtnMostrar.Name = "BtnMostrar";
			this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
			this.BtnMostrar.TabIndex = 22;
			this.BtnMostrar.Text = "Mostrar";
			this.BtnMostrar.UseVisualStyleBackColor = true;
			this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
			// 
			// BtnCrear
			// 
			this.BtnCrear.Location = new System.Drawing.Point(297, 77);
			this.BtnCrear.Name = "BtnCrear";
			this.BtnCrear.Size = new System.Drawing.Size(75, 23);
			this.BtnCrear.TabIndex = 21;
			this.BtnCrear.Text = "Crear";
			this.BtnCrear.UseVisualStyleBackColor = true;
			this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(78, 140);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(195, 20);
			this.txtNombre.TabIndex = 20;
			// 
			// txtContrasena
			// 
			this.txtContrasena.Location = new System.Drawing.Point(78, 111);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.Size = new System.Drawing.Size(195, 20);
			this.txtContrasena.TabIndex = 19;
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(78, 79);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(195, 20);
			this.txtCorreo.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(12, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Contraseña:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(12, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Nombre:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(12, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Correo:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(12, 166);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "Cargo:";
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.Location = new System.Drawing.Point(297, 166);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
			this.BtnEliminar.TabIndex = 27;
			this.BtnEliminar.Text = "Eliminar";
			this.BtnEliminar.UseVisualStyleBackColor = true;
			this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.AllowUserToAddRows = false;
			this.dgvUsuarios.AllowUserToDeleteRows = false;
			this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(168)))), ((int)(((byte)(210)))));
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.dgvUsuarios.Location = new System.Drawing.Point(420, 22);
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.ReadOnly = true;
			this.dgvUsuarios.Size = new System.Drawing.Size(470, 125);
			this.dgvUsuarios.TabIndex = 28;
			// 
			// BtnMostrarArqueo
			// 
			this.BtnMostrarArqueo.Location = new System.Drawing.Point(38, 228);
			this.BtnMostrarArqueo.Name = "BtnMostrarArqueo";
			this.BtnMostrarArqueo.Size = new System.Drawing.Size(97, 23);
			this.BtnMostrarArqueo.TabIndex = 35;
			this.BtnMostrarArqueo.Text = "Arqueo";
			this.BtnMostrarArqueo.UseVisualStyleBackColor = true;
			this.BtnMostrarArqueo.Click += new System.EventHandler(this.BtnMostrarArqueo_Click);
			// 
			// btcerrarAdministrador
			// 
			this.btcerrarAdministrador.Location = new System.Drawing.Point(154, 338);
			this.btcerrarAdministrador.Name = "btcerrarAdministrador";
			this.btcerrarAdministrador.Size = new System.Drawing.Size(132, 24);
			this.btcerrarAdministrador.TabIndex = 37;
			this.btcerrarAdministrador.Text = "Cerrar Sesion";
			this.btcerrarAdministrador.UseVisualStyleBackColor = true;
			this.btcerrarAdministrador.Click += new System.EventHandler(this.btcerrarAdministrador_Click);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.BackColor = System.Drawing.Color.Transparent;
			this.radioButton2.Location = new System.Drawing.Point(38, 205);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(98, 17);
			this.radioButton2.TabIndex = 39;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Arqueo de Caja";
			this.radioButton2.UseVisualStyleBackColor = false;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// lblAdministrador
			// 
			this.lblAdministrador.AutoSize = true;
			this.lblAdministrador.BackColor = System.Drawing.Color.Transparent;
			this.lblAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAdministrador.Location = new System.Drawing.Point(10, 13);
			this.lblAdministrador.Name = "lblAdministrador";
			this.lblAdministrador.Size = new System.Drawing.Size(157, 25);
			this.lblAdministrador.TabIndex = 41;
			this.lblAdministrador.Text = "Administrador";
			// 
			// lblmensajeAdministrador
			// 
			this.lblmensajeAdministrador.AutoSize = true;
			this.lblmensajeAdministrador.BackColor = System.Drawing.Color.Transparent;
			this.lblmensajeAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblmensajeAdministrador.Location = new System.Drawing.Point(173, 22);
			this.lblmensajeAdministrador.Name = "lblmensajeAdministrador";
			this.lblmensajeAdministrador.Size = new System.Drawing.Size(0, 13);
			this.lblmensajeAdministrador.TabIndex = 40;
			// 
			// sbCrear
			// 
			this.sbCrear.AutoSize = true;
			this.sbCrear.BackColor = System.Drawing.Color.Transparent;
			this.sbCrear.Location = new System.Drawing.Point(120, 51);
			this.sbCrear.Name = "sbCrear";
			this.sbCrear.Size = new System.Drawing.Size(50, 17);
			this.sbCrear.TabIndex = 42;
			this.sbCrear.TabStop = true;
			this.sbCrear.Text = "Crear";
			this.sbCrear.UseVisualStyleBackColor = false;
			this.sbCrear.CheckedChanged += new System.EventHandler(this.sbCrear_CheckedChanged);
			// 
			// rbMostrar
			// 
			this.rbMostrar.AutoSize = true;
			this.rbMostrar.BackColor = System.Drawing.Color.Transparent;
			this.rbMostrar.Location = new System.Drawing.Point(38, 51);
			this.rbMostrar.Name = "rbMostrar";
			this.rbMostrar.Size = new System.Drawing.Size(60, 17);
			this.rbMostrar.TabIndex = 43;
			this.rbMostrar.TabStop = true;
			this.rbMostrar.Text = "Mostrar";
			this.rbMostrar.UseVisualStyleBackColor = false;
			this.rbMostrar.CheckedChanged += new System.EventHandler(this.rbMostrar_CheckedChanged);
			// 
			// rbActualizar
			// 
			this.rbActualizar.AutoSize = true;
			this.rbActualizar.BackColor = System.Drawing.Color.Transparent;
			this.rbActualizar.Location = new System.Drawing.Point(198, 51);
			this.rbActualizar.Name = "rbActualizar";
			this.rbActualizar.Size = new System.Drawing.Size(71, 17);
			this.rbActualizar.TabIndex = 44;
			this.rbActualizar.TabStop = true;
			this.rbActualizar.Text = "Actualizar";
			this.rbActualizar.UseVisualStyleBackColor = false;
			this.rbActualizar.CheckedChanged += new System.EventHandler(this.rbActualizar_CheckedChanged);
			// 
			// rbEliminar
			// 
			this.rbEliminar.AutoSize = true;
			this.rbEliminar.BackColor = System.Drawing.Color.Transparent;
			this.rbEliminar.Location = new System.Drawing.Point(288, 51);
			this.rbEliminar.Name = "rbEliminar";
			this.rbEliminar.Size = new System.Drawing.Size(61, 17);
			this.rbEliminar.TabIndex = 45;
			this.rbEliminar.TabStop = true;
			this.rbEliminar.Text = "Eliminar";
			this.rbEliminar.UseVisualStyleBackColor = false;
			this.rbEliminar.CheckedChanged += new System.EventHandler(this.rbEliminar_CheckedChanged);
			// 
			// dgvProductos
			// 
			this.dgvProductos.AllowUserToAddRows = false;
			this.dgvProductos.AllowUserToDeleteRows = false;
			this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(168)))), ((int)(((byte)(210)))));
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.GridColor = System.Drawing.Color.Cyan;
			this.dgvProductos.Location = new System.Drawing.Point(420, 166);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			this.dgvProductos.Size = new System.Drawing.Size(470, 200);
			this.dgvProductos.TabIndex = 46;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(417, 6);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 13);
			this.label7.TabIndex = 47;
			this.label7.Text = "Tabla de Usuarios:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(417, 150);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(103, 13);
			this.label9.TabIndex = 49;
			this.label9.Text = "Tabla de Productos:";
			// 
			// cbCargo
			// 
			this.cbCargo.FormattingEnabled = true;
			this.cbCargo.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
			this.cbCargo.Location = new System.Drawing.Point(78, 168);
			this.cbCargo.Name = "cbCargo";
			this.cbCargo.Size = new System.Drawing.Size(195, 21);
			this.cbCargo.TabIndex = 50;
			// 
			// Administrador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::Menu.Properties.Resources.Fondo4;
			this.ClientSize = new System.Drawing.Size(903, 374);
			this.Controls.Add(this.cbCargo);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.rbEliminar);
			this.Controls.Add(this.rbActualizar);
			this.Controls.Add(this.rbMostrar);
			this.Controls.Add(this.sbCrear);
			this.Controls.Add(this.lblAdministrador);
			this.Controls.Add(this.lblmensajeAdministrador);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.btcerrarAdministrador);
			this.Controls.Add(this.BtnMostrarArqueo);
			this.Controls.Add(this.dgvUsuarios);
			this.Controls.Add(this.BtnEliminar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.BtnActualizar);
			this.Controls.Add(this.BtnMostrar);
			this.Controls.Add(this.BtnCrear);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Administrador";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Administrador";
			this.Load += new System.EventHandler(this.Administrador_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button BtnMostrarArqueo;
        private System.Windows.Forms.Button btcerrarAdministrador;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Label lblmensajeAdministrador;
        private System.Windows.Forms.RadioButton sbCrear;
        private System.Windows.Forms.RadioButton rbMostrar;
        private System.Windows.Forms.RadioButton rbActualizar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCargo;
    }
}