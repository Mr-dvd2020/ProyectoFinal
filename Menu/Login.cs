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
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection("server=DESKTOP-S92T72U ; database=Tienda ; integrated security = true");
        public Login()
        {
            InitializeComponent();
        }

        public void logear(string correo, string contraseña)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombres, Tipo_usuario FROM Usuario WHERE Correo = @correo AND Contrasena = @pas", cn);
                cmd.Parameters.AddWithValue("correo", correo);
                cmd.Parameters.AddWithValue("pas", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Administrador")
                    {
                        new Administrador(dt.Rows[0][0].ToString()).Show();
                    }
                    else if(dt.Rows[0][1].ToString() == "Cajero")
                    {
                        new Cajero(dt.Rows[0][0].ToString()).Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Almacenero")
                    {
                        new Almacenero(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void Botón_Login_Click(object sender, EventArgs e)
        {
            logear(this.Correo.Text, this.Password.Text);
        }

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}
