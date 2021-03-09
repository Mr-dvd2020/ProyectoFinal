using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Menu
{
    /// <summary>
    /// /RAAAAAAAAAAAAAAAAA
    /// </summary>
    /// si se pudo
    /// aea
    public partial class Almacenero : Form
    {
        SqlConnection cn = new SqlConnection("server=DESKTOP-S92T72U ; database=Tienda ; integrated security = true");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public Almacenero(string nombre)
        {
            InitializeComponent();
            lblmensajeAlmacenero.Text = nombre;
        }

        private void btcerrarAlmacenero_Click(object sender, EventArgs e)
        {
            Login inicio = new Login();
            inicio.Show();
            this.Close();
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MostrarProductos(dataGridView1);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Producto SET Cantida=@Cantida, PrecioUnitario=@PrecioUnitario WHERE CodigoProducto=@CodigoProducto";
            cn.Open();
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@CodigoProducto", txtId.Text);
            cmd.Parameters.AddWithValue("@PrecioUnitario", textBoxPrecioUnitario.Text);
            cmd.Parameters.AddWithValue("@Cantida", textBoxCantidad.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Se actualizo la informacion");
            txtId.Clear();
            textBoxPrecioUnitario.Clear();
            textBoxCantidad.Clear();
            txtId.Text = "";
            txtNombre.Text = "";
            txtUnidad.Text = "";
            textBoxCantidad.Text = "";
            textBoxPrecioUnitario.Text = "";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            cn.Open();
            if (ProductoRegistrado(txtId.Text) == 0)
            {
                MessageBox.Show(agregar(txtId.Text, txtNombre.Text, txtUnidad.Text, textBoxCantidad.Text, textBoxPrecioUnitario.Text));
                txtId.Text = "";
                txtNombre.Text = "";
                txtUnidad.Text = "";
                textBoxCantidad.Text = "";
                textBoxPrecioUnitario.Text= ""; 
            }
            else
            {
                cn.Close();
                MessageBox.Show("Imposible de regitrar, Un Producto con este codigo ya existe");
                txtId.Text = "";
                txtNombre.Text = "";
                txtUnidad.Text = "";
                textBoxCantidad.Text = "";
                textBoxPrecioUnitario.Text = "";
            }
            cn.Close();
        }

        public string agregar(string CodigoProducto, string Descripcion, string Unidad, string Cantidad, string PrecioUnitario)
        {
            string salida = "se creo el Producto correctamente";
            try
            {
                cmd = new SqlCommand("insert into Producto(CodigoProducto,Descripcion,Unidad,Cantida,PrecioUnitario) values('" + CodigoProducto + "','" + Descripcion + "','" + Unidad + "'," + Cantidad + ","+ PrecioUnitario + ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                salida = "No se pudo crear: " + E.ToString();
            }
            return salida;
        }

        public int ProductoRegistrado(string CodigoProducto)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * From Producto where CodigoProducto='" + CodigoProducto + "'", cn);
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

        private void txtId_KeyUp(object sender, KeyEventArgs e)
        {
            cn.Open();

            cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Producto where CodigoProducto like ('" + txtId.Text + "%')";
            cmd.ExecuteNonQuery();

            dt = new DataTable();
            da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtUnidad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxCantidad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxPrecioUnitario.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch { }
        }
    }
}
