using MySql.Data.MySqlClient;
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
    public partial class Libros : Form
    {
        public Libros()
        {
            InitializeComponent();
        }

        MySqlConnection conexion = new MySqlConnection("Server=" + Ajustes.datos_conect[0] + ";" + "Database=" + Ajustes.datos_conect[1] + ";" + "Uid=" + Ajustes.datos_conect[2] + ";" + "Password=" + Ajustes.datos_conect[3] + ";");


        private void button1_Click(object sender, EventArgs e)
        {
            Eliminar_Libro elim = new Eliminar_Libro();
            elim.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "insert into libro(nombre,autor,ejemplares,idioma) values ('" + txtNombre.Text + "','" + txtAutor.Text + "','" + txtEjemplares.Text + "','" + txtIdioma.Text + "');";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Libro registrado con exito");
        }
    }
}
