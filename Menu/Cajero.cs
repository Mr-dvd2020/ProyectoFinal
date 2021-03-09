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
    public partial class Cajero : Form
    {

        SqlConnection cn = new SqlConnection("server=DESKTOP-S92T72U ; database=Tienda ; integrated security = true");
        string pNombre = "";
        public Cajero(string nombre)
        {
            InitializeComponent();
            lblmensajeCajero.Text = nombre;
            pNombre = nombre;
        }

        private void btcerrarCajero_Click(object sender, EventArgs e)
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

        private void btnIniciarVenta_Click(object sender, EventArgs e)
        {
            Venta inicio = new Venta(pNombre,0);
            inicio.Show();
            this.Close();
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            Arqueo AC = new Arqueo(pNombre, 0);
            AC.Show();
        }

		private void Cajero_Load(object sender, EventArgs e)
		{

		}
	}
}
