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
    public partial class Arqueo : Form
    {
        SqlConnection cn = new SqlConnection("server=DESKTOP-S92T72U ; database=Tienda ; integrated security = true");
        double SumaAcumulativaTotal = 0;
        int Ctd200 = 0, Ctd100 = 0, Ctd50 = 0, Ctd20 = 0, Ctd10 = 0, Ctd5 = 0, Ctd2 = 0, Ctd1 = 0;

        private void tbCtd100_TextChanged(object sender, EventArgs e)
        {
            int Cant100, r;
            Cant100 = Convert.ToInt32(tbCtd100.Text);
            r = Cant100 * 100;
            if ((Ctd100 != Cant100) | (Ctd100 != 0))
            {
                SumaAcumulativaTotal = SumaAcumulativaTotal - Ctd100;
                Ctd100 = r;
            }
            tbPar100.Text = r.ToString();
            //SumaDeMontoParcial();
            SumaAcumulativaTotal = SumaAcumulativaTotal + r;
            tbTotal.Text = SumaAcumulativaTotal.ToString();
        }

        private void tbCtd50_TextChanged(object sender, EventArgs e)
        {
            int Cant50, r;
            Cant50 = Convert.ToInt32(tbCtd50.Text);
            r = Cant50 * 50;
            if ((Ctd50 != Cant50) | (Ctd50 != 0))
            {
                SumaAcumulativaTotal = SumaAcumulativaTotal - Ctd50;
                Ctd50 = r;
            }
            tbPar50.Text = r.ToString();
            //SumaDeMontoParcial();
            SumaAcumulativaTotal = SumaAcumulativaTotal + r;
            tbTotal.Text = SumaAcumulativaTotal.ToString();
        }

        private void tbCtd20_TextChanged(object sender, EventArgs e)
        {
            int Cant20, r;
            Cant20 = Convert.ToInt32(tbCtd20.Text);
            r = Cant20 * 20;
            if ((Ctd20 != Cant20) | (Ctd20 != 0))
            {
                SumaAcumulativaTotal = SumaAcumulativaTotal - Ctd20;
                Ctd20 = r;
            }
            tbPar20.Text = r.ToString();
            //SumaDeMontoParcial();
            SumaAcumulativaTotal = SumaAcumulativaTotal + r;
            tbTotal.Text = SumaAcumulativaTotal.ToString();
        }

        private void tbCtd10_TextChanged(object sender, EventArgs e)
        {
            int Cant10, r;
            Cant10 = Convert.ToInt32(tbCtd10.Text);
            r = Cant10 * 10;
            if ((Ctd10 != Cant10) | (Ctd10 != 0))
            {
                SumaAcumulativaTotal = SumaAcumulativaTotal - Ctd10;
                Ctd10 = r;
            }
            tbPar10.Text = r.ToString();
            //SumaDeMontoParcial();
            SumaAcumulativaTotal = SumaAcumulativaTotal + r;
            tbTotal.Text = SumaAcumulativaTotal.ToString();
        }

        private void tbCtd5_TextChanged(object sender, EventArgs e)
        {
            int Cant5, r;
            Cant5 = Convert.ToInt32(tbCtd5.Text);
            r = Cant5 * 5;
            if ((Ctd5 != Cant5) | (Ctd5 != 0))
            {
                SumaAcumulativaTotal = SumaAcumulativaTotal - Ctd5;
                Ctd5 = r;
            }
            tbPar5.Text = r.ToString();
            //SumaDeMontoParcial();
            SumaAcumulativaTotal = SumaAcumulativaTotal + r;
            tbTotal.Text = SumaAcumulativaTotal.ToString();
        }

        private void tbCtd2_TextChanged(object sender, EventArgs e)
        {
            int Cant2, r;
            Cant2 = Convert.ToInt32(tbCtd2.Text);
            r = Cant2 * 2;
            if ((Ctd2 != Cant2) | (Ctd2 != 0))
            {
                SumaAcumulativaTotal = SumaAcumulativaTotal - Ctd2;
                Ctd2 = r;
            }
            tbPar2.Text = r.ToString();
            //SumaDeMontoParcial();
            SumaAcumulativaTotal = SumaAcumulativaTotal + r;
            tbTotal.Text = SumaAcumulativaTotal.ToString();
        }

        private void tbCtd1_TextChanged(object sender, EventArgs e)
        {
            int Cant1, r;
            Cant1 = Convert.ToInt32(tbCtd1.Text);
            r = Cant1 * 1;
            if ((Ctd1 != Cant1) | (Ctd1 != 0))
            {
                SumaAcumulativaTotal = SumaAcumulativaTotal - Ctd1;
                Ctd1 = r;
            }
            tbPar1.Text = r.ToString();
            //SumaDeMontoParcial();
            SumaAcumulativaTotal = SumaAcumulativaTotal + r;
            tbTotal.Text = SumaAcumulativaTotal.ToString();
        }

        private void tbCtd05_TextChanged(object sender, EventArgs e)
        {
            double Cant05, r;
            Cant05 = Convert.ToDouble(tbCtd05.Text);
            r = Cant05 * 0.5;
            if ((Ctd05 != Cant05) | (Ctd05 != 0))
            {
                SumaAcumulativaTotal = SumaAcumulativaTotal - Ctd05;
                Ctd05 = r;
            }
            tbPar05.Text = r.ToString();
            //SumaDeMontoParcial();
            SumaAcumulativaTotal = SumaAcumulativaTotal + r;
            tbTotal.Text = SumaAcumulativaTotal.ToString();
        }

        private void tbCtd02_TextChanged(object sender, EventArgs e)
        {
            double Cant02, r;
            Cant02 = Convert.ToDouble(tbCtd02.Text);
            r = Cant02 * 0.2;
            if ((Ctd02 != Cant02) | (Ctd02 != 0))
            {
                SumaAcumulativaTotal = SumaAcumulativaTotal - Ctd02;
                Ctd02 = r;
            }
            tbPar02.Text = r.ToString();
            //SumaDeMontoParcial();
            SumaAcumulativaTotal = SumaAcumulativaTotal + r;
            tbTotal.Text = SumaAcumulativaTotal.ToString();
        }

        private void tbCtd01_TextChanged(object sender, EventArgs e)
        {
            double Cant01, r;
            Cant01 = Convert.ToDouble(tbCtd01.Text);
            r = Cant01 * 0.1;
            if ((Ctd01 != Cant01) | (Ctd01 != 0))
            {
                SumaAcumulativaTotal = SumaAcumulativaTotal - Ctd01;
                Ctd01 = r;
            }

            tbPar01.Text = r.ToString();
            //SumaDeMontoParcial();
            SumaAcumulativaTotal = SumaAcumulativaTotal + r;
            tbTotal.Text = SumaAcumulativaTotal.ToString();
        }

        private void tbCtd200_TextChanged(object sender, EventArgs e)
        {
            int Cant200, r;
            Cant200 = Convert.ToInt32(tbCtd200.Text);
            r = Cant200 * 200;
            if ((Ctd200 != Cant200) | (Ctd200 != 0))
            {
                SumaAcumulativaTotal = SumaAcumulativaTotal - Ctd200;
                Ctd200 = r;
            }
            tbPar200.Text = r.ToString();
            SumaAcumulativaTotal = SumaAcumulativaTotal + r;
            tbTotal.Text = SumaAcumulativaTotal.ToString();
            //SumaDeMontoParcial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cajero inicio = new Cajero(Nombre);
            inicio.Show();
            this.Close();
        }

		private void Arqueo_Load(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
        {
            //lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dddd MMMM yyy");
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Administrador inicio = new Administrador(Nombre);
            inicio.Show();
            this.Close();
        }

        double Ctd05 = 0, Ctd02 = 0, Ctd01 = 0;
        string Nombre = "";
        public Arqueo(string pnombre, int n)
        {
            InitializeComponent();
            Nombre = pnombre;
            MostrarVentaArqueo(dgvVentasEfectuadas);
            // Mostrar Monto total de las ventas efectuadas
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = "SELECT SUM(PrecioTotal) FROM Arqueo";
            MontoTotal.Text = (cmd.ExecuteScalar()).ToString() + " S/.";
            cn.Close();
        }

        public void MostrarVentaArqueo(DataGridView dgv)
        {

            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select CodBoleta, PrecioTotal From Arqueo", cn);
                da.Fill(dt);
                dgv.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView: " + ex.ToString());
            }
        }

        public void SumaDeMontoParcial()
        {
            int Cant200, Cant100, Cant50, Cant20, Cant10, Cant5, Cant2, Cant1;
            double Cant05, Cant02, Cant01, r;
            Cant200 = int.Parse(tbPar200.Text);
            Cant100 = int.Parse(tbPar100.Text);
            Cant50 = int.Parse(tbPar50.Text);
            Cant20 = int.Parse(tbPar20.Text);
            Cant10 = int.Parse(tbPar10.Text);
            Cant5 = int.Parse(tbPar5.Text);
            Cant2 = int.Parse(tbPar2.Text);
            Cant1 = int.Parse(tbPar1.Text);
            Cant05 = double.Parse(tbPar05.Text);
            Cant02 = double.Parse(tbPar02.Text);
            Cant01 = double.Parse(tbPar01.Text);

            r = Cant200 + Cant100 + Cant50 + Cant20 + Cant10 + Cant5 + Cant2 + Cant1 + Cant05 + Cant02 + Cant01;
            tbTotal.Text = r.ToString();
        }
    }
}
