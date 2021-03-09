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
    public partial class Venta : Form
    {
        SqlConnection cn = new SqlConnection("server=DESKTOP-S92T72U ; database=Tienda ; integrated security = true");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DateTime hora = DateTime.Now;
        string Nombre = "";
        public Venta(string pnombre, int n)
        {
            InitializeComponent();
            txtHora.Text = hora.ToShortTimeString();
            Nombre = pnombre;
            MostrarProductos(dgvProductos);
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

        public void MostrarVentas(DataGridView dgv)
        {
            if (txtCodBoleta.Text.Length == 0)
            {
                cmd = new SqlCommand("Select CodigoProducto,NombreProducto,NroProducto,MontoUnitario,MontoTotal From Venta  where CodigoBoleta=(select max(CodigoBoleta) from Venta)", cn);
            }
            else
            {
                cmd = new SqlCommand("Select CodigoProducto,NombreProducto,NroProducto,MontoUnitario,MontoTotal From Venta WHERE CodigoBoleta=@CodBoleta", cn);
                cmd.Parameters.AddWithValue("@CodBoleta", txtCodBoleta.Text);
            }
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = cmd;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvVentas.DataSource = tabla;
        }

        /*public string agregarVenta(string codboleta, string codproducto, string nombre, string numero, string montou, string montot, string tiempo)
        {
            string salida = "se agrego la venta";
            try
            {
                cmd = new SqlCommand("insert into Venta(CodigoBoleta,CodigoProducto,NombreProducto,NroProducto,MontoUnitario,MontoTotal,Hora) values('" + codboleta + "','" + codproducto + "','" + nombre + "','" + numero + "','" + montou + "','" + montot + "','" + tiempo + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                salida = "No se pudo crear: " + E.ToString();
            }
            return salida;
        }*/

        /*public int ventaRegistrada(string CodigoProducto, string CodigoBoleta)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * From Venta where CodigoProducto and CodigoBoleta='" + CodigoProducto + "','" + CodigoBoleta + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("producto ya vendido: " + Ex.ToString());
            }
            return contador;
        }
        */
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            //cn.Open();
            string query = "INSERT INTO Venta(CodigoBoleta, CodigoProducto, NombreProducto, NroProducto, MontoUnitario, MontoTotal, Hora) VALUES (@codigoboleta, @codigoproducto, @nombreproducto, @nroproducto ,@montounitario, @montototal, @hora)";
            cn.Open();
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@codigoboleta", txtCodBoleta.Text);
            cmd.Parameters.AddWithValue("@codigoproducto", txtCodProducto.Text);
            cmd.Parameters.AddWithValue("@nombreproducto", txtNombreProducto.Text);
            cmd.Parameters.AddWithValue("@nroproducto", Convert.ToInt32( txtNroProducto.Text));
            cmd.Parameters.AddWithValue("@montounitario", txtPrecioUnitario.Text);
            cmd.Parameters.AddWithValue("@montototal", Convert.ToDecimal(txtPrecioTotal.Text));
            cmd.Parameters.AddWithValue("@hora", txtHora.Text);
            cmd.ExecuteNonQuery();
            MostrarVentas(dgvVentas);

            string query1 = "UPDATE Producto SET Cantida=@cantidad WHERE CodigoProducto=@codproducto";
            cmd = new SqlCommand(query1, cn);
            cmd.Parameters.AddWithValue("@codproducto", txtCodProducto.Text);
            cmd.Parameters.AddWithValue("@cantidad",int.Parse(txtStock.Text)-int.Parse(txtNroProducto.Text));
            cmd.ExecuteNonQuery();


            cmd.CommandText = "SELECT SUM(MontoTotal) FROM Venta Where (CodigoBoleta='" + this.txtCodBoleta.Text + "')";
            txtTotal.Text = (cmd.ExecuteScalar()).ToString();

            txtCodProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioTotal.Text = "";
            txtPrecioUnitario.Text = "";
            txtNroProducto.Text = "";
            cn.Close();


            /*
            //el seguro
            cmd = new SqlCommand("INSERT INTO Venta(CodigoBoleta, CodigoProducto, NombreProducto, NroProducto, MontoUnitario, MontoTotal, Hora)" +
                    " VALUES ('" + this.txtCodBoleta.Text + "','" + this.txtCodProducto.Text + "','" + this.txtNombreProducto.Text + "','" + this.txtNroProducto.Text + "','" + this.txtPrecioUnitario.Text + "','" + this.txtPrecioTotal.Text + "','" + this.txtHora.Text + "')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("venta registrada");
            txtCodProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioTotal.Text = "";
            txtPrecioUnitario.Text = "";
            txtPrecioTotal.Text = "";
            txtNroProducto.Text = "";*/

            /* 
             if (ventaRegistrada(txtCodProducto.Text, txtCodBoleta.Text) == 0)
             {
                 cmd = new SqlCommand("INSERT INTO Venta(CodigoBoleta, CodigoProducto, NombreProducto, NroProducto, MontoUnitario, MontoTotal, Hora)" +
                     " VALUES ('" + this.txtCodBoleta.Text + "','" + this.txtCodProducto.Text + "','" + this.txtNombreProducto.Text + "','" + this.txtNroProducto.Text + "','" + this.txtPrecioUnitario.Text + "','" + this.txtPrecioTotal.Text + "','" + this.txtHora.Text + "')", cn);
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("venta registrada");
                 txtCodProducto.Text = "";
                 txtNombreProducto.Text = "";
                 txtPrecioTotal.Text = "";
                 txtPrecioUnitario.Text = "";
                 txtPrecioTotal.Text = "";
                 txtNroProducto.Text = "";


                 


             }
             else
             {
                 cn.Close();
                 MessageBox.Show("ya se realizo la venta");
             }
            */

            
            
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Producto WHERE CodigoProducto=@codigo", cn);
            cmd.Parameters.AddWithValue("@codigo", txtCodProducto.Text);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                float valor1 = float.Parse(txtPrecioUnitario.Text);
                int valor2 = int.Parse(txtNroProducto.Text);
                float MT = valor1 * valor2;
                txtPrecioTotal.Text = MT.ToString();

            }
            cn.Close();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            hora = DateTime.Now;
            txtHora.Text = hora.ToShortTimeString();
            txtCodBoleta.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cajero inicio = new Cajero(Nombre);
            inicio.Show();
            this.Close();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodProducto.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                txtNombreProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                txtPrecioUnitario.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
                txtStock.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            }
            catch { }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            cn.Open();

            cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Producto where CodigoProducto like ('" + txtBuscar.Text + "%') or Descripcion like ('" + txtBuscar.Text + "%')";
            cmd.ExecuteNonQuery();

            dt = new DataTable();
            da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dgvProductos.DataSource = dt;

            cn.Close();
        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Arqueo(CodBoleta, PrecioTotal) VALUES (@codigoboleta, @montototal)";
            cn.Open();
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@codigoboleta", txtCodBoleta.Text);
            cmd.Parameters.AddWithValue("@montototal", Convert.ToDecimal(txtTotal.Text));
            cmd.ExecuteNonQuery();
            cn.Close();

            boleta inicio = new boleta(Nombre);
            inicio.Show();
            this.Close();
        }

        private void btnTablaArqueo_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Arqueo(CodBoleta, PrecioTotal) VALUES (@codigoboleta, @montototal)";
            cn.Open();
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@codigoboleta", txtCodBoleta.Text);
            cmd.Parameters.AddWithValue("@montototal",Convert.ToDecimal(txtTotal.Text));
            cmd.ExecuteNonQuery();
            cn.Close();
        }

		private void Venta_Load(object sender, EventArgs e)
		{

		}
	}
   
}
