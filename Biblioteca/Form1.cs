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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if(txtuser.Text == "admin" && txtpass.Text == "4444")
            {
                Menu_Pricipal menu = new Menu_Pricipal();
                menu.Show();
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecta");
            }
        }
    }
}
