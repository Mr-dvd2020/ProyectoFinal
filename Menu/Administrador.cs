using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Menu
{
    public partial class Administrador : Form
    {
        SqlConnection cn = new SqlConnection("server=DESKTOP-S92T72U ; database=Tienda ; integrated security = true");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        string pNombre = "";
        public Administrador(string nombre)
        {
            InitializeComponent();
            lblmensajeAdministrador.Text = nombre;
            rbMostrar.Checked = true;
            pNombre = nombre;
        }

        private void btcerrarAdministrador_Click(object sender, EventArgs e)
        {
            Login inicio = new Login();
            inicio.Show();
            this.Close();
        }

        public void MostrarUsuarios(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Usuario", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        public void MostrarProductos(DataGridView dgv)
        {

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Producto", cn);
                da.Fill(dt);
                dgv.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Usuario SET Contrasena=@contrasena, Nombres=@nombre, Tipo_Usuario=@usuario WHERE Correo=@correo";
            cn.Open();
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@usuario", cbCargo.Text);
            cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Se actualizo la informacion");
            txtContrasena.Clear();
            txtCorreo.Clear();
            txtNombre.Clear();
            cbCargo.SelectedIndex = 0;

        }

        private void rbActualizar_CheckedChanged(object sender, EventArgs e)
        {
            txtCorreo.Enabled = true;
            txtContrasena.Enabled = true;
            txtNombre.Enabled = true;
            cbCargo.Enabled = true;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = false;
            BtnMostrar.Enabled = false;
            BtnMostrarArqueo.Enabled = false;
            BtnCrear.Enabled = false;
            btcerrarAdministrador.Enabled = true;
        }

        private void rbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtCorreo.Enabled = false;
            txtContrasena.Enabled = false;
            txtNombre.Enabled = false;
            cbCargo.Enabled = false;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnMostrar.Enabled = true;
            BtnMostrarArqueo.Enabled = false;
            BtnCrear.Enabled = false;
            btcerrarAdministrador.Enabled = true;
        }

        private void sbCrear_CheckedChanged(object sender, EventArgs e)
        {
            txtCorreo.Enabled = true;
            txtContrasena.Enabled = true;
            txtNombre.Enabled = true;
            cbCargo.Enabled = true;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnMostrar.Enabled = false;
            BtnMostrarArqueo.Enabled = false;
            BtnCrear.Enabled = true;
            btcerrarAdministrador.Enabled = true;
        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtCorreo.Enabled = true;
            txtContrasena.Enabled = false;
            txtNombre.Enabled = false;
            cbCargo.Enabled = false;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = true;
            BtnMostrar.Enabled = false;
            BtnMostrarArqueo.Enabled = false;
            BtnCrear.Enabled = false;
            btcerrarAdministrador.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Usuario WHERE Correo=@Correo";
            cn.Open();
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
            if (cmd.ExecuteNonQuery() == 1)
            {
                cn.Close();
                MessageBox.Show("se elimino exitosamente");
                txtCorreo.Text = "";
            }
            else
            {
                cn.Close();
                MessageBox.Show("El correo ingresado no existe");
                txtCorreo.Text = "";
            }
        }

       
        public string agregar(string Correo, string pasword, string nombres, string cargo)
        {
            string salida = "se creo el usuario correctamente";
            try
            {
                cmd = new SqlCommand("insert into Usuario(Correo,Contrasena,Nombres,Tipo_Usuario) values('" + Correo + "','" + pasword + "','" + nombres + "','" + cargo + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                salida = "No se pudo crear: " + E.ToString();
            }
            return salida;
        }

        public int PersonaRegistrada(string Correo)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * From Usuario where Correo='" + Correo + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + Ex.ToString());
            }
            return contador;
        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            cn.Open();

            if (PersonaRegistrada(txtCorreo.Text) == 0)
            {
                MessageBox.Show(agregar(txtCorreo.Text, txtContrasena.Text, txtNombre.Text, cbCargo.Text));
                txtCorreo.Text = "";
                txtContrasena.Text = "";
                txtNombre.Text = "";
                cbCargo.Text = "";
            }
            else
            {
                cn.Close();
                MessageBox.Show("Imposible de regitrar, Un usuario con este correo ya existe");
            }
            cn.Close();

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            MostrarUsuarios(dgvUsuarios);
            MostrarProductos(dgvProductos);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtCorreo.Enabled = false;
            txtContrasena.Enabled = false;
            txtNombre.Enabled = false;
            cbCargo.Enabled = false;
            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnMostrar.Enabled = false;
            BtnMostrarArqueo.Enabled = true;
            BtnCrear.Enabled = false;
            btcerrarAdministrador.Enabled = true;
        }

        private void BtnMostrarArqueo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Arqueo AC = new Arqueo(pNombre, 0);
            AC.Show();
        }

		private void Administrador_Load(object sender, EventArgs e)
		{

		}
	}
    
}
