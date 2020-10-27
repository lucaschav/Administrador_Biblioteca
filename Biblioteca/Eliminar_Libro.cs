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
    public partial class Eliminar_Libro : Form
    {
        public Eliminar_Libro()
        {
            InitializeComponent();
        }

        MySqlConnection conexion = new MySqlConnection("Server=" + Ajustes.datos_conect[0] + ";" + "Database=" + Ajustes.datos_conect[1] + ";" + "Uid=" + Ajustes.datos_conect[2] + ";" + "Password=" + Ajustes.datos_conect[3] + ";");

        private void Eliminar_Libro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select * from libro", conexion);
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            adapt.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapt.Fill(tabla);
            datalibro.DataSource = tabla;
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "delete from libro where id=" + txtIdlibro.Text;
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Libro eliminado");
        }
    }
}
