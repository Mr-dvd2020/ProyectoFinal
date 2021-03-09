using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Menu
{
    public partial class boleta : Form
    {
        SqlConnection cn = new SqlConnection("server=DESKTOP-S92T72U ; database=Tienda ; integrated security = true");
        string pNombre = "";
        public boleta(string Nombre)
        {
            InitializeComponent();
            pNombre =Nombre ;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            SqlCommand comando;
            if (textBox1.Text.Length == 0)
            {
                comando = new SqlCommand("select CodigoProducto,NroProducto,MontoUnitario,MontoTotal from Venta where CodigoBoleta=(select max(CodigoBoleta) from Venta)", cn);
            }
            else
            {
                comando = new SqlCommand("select CodigoProducto,NroProducto,MontoUnitario,MontoTotal from Venta where CodigoBoleta=@Boleta", cn);
                comando.Parameters.AddWithValue("@Boleta", textBox1.Text);
            }
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Vista_Boleta.DataSource = tabla;
        }

        private void Botón_Imprimir_Click(object sender, EventArgs e)
        {
            Venta inicio = new Venta(pNombre,0);
            inicio.Show();
            this.Close();
        }

		private void boleta_Load(object sender, EventArgs e)
		{

		}
	}
}
