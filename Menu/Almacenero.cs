using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    /// <summary>
    /// /RAAAAAAAAAAAAAAAAA
    /// </summary>
    public partial class Almacenero : Form
    {
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
    }
}
