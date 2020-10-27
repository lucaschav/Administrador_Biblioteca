using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Menu_Pricipal : Form
    {
        public Menu_Pricipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservacion reserv = new Reservacion();
            reserv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Socio soc = new Socio();
            soc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Libros lib = new Libros();
            lib.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ajustes ajus = new Ajustes();
            ajus.Show();
        }
    }
}
