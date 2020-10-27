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
    public partial class Reservacion : Form
    {
        public Reservacion()
        {
            InitializeComponent();
        }

        MySqlConnection conexion = new MySqlConnection("Server=" + Ajustes.datos_conect[0] + ";" + "Database=" + Ajustes.datos_conect[1] + ";" + "Uid=" + Ajustes.datos_conect[2] + ";" + "Password=" + Ajustes.datos_conect[3] + ";");


        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "select * from libro where nombre like '%" + txtBuscar.Text + "%'";
            MySqlDataAdapter adapt = new MySqlDataAdapter(query, conexion);
            DataSet tabla = new DataSet();
            adapt.Fill(tabla, "libro");
            dataReserva.DataSource = tabla;
            dataReserva.DataMember = "libro";
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select * from libro", conexion);
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            adapt.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapt.Fill(tabla);
            dataReserva.DataSource = tabla;
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "insert into reservacion(idLibro,idSocio,fechaSalida,fechaDev) values ('" + txtIdLibro.Text + "','" + txtIdSocio.Text + "','" + txtRetiro.Text + "','" + txtDevolucion.Text + "');";
            string query1 = "update libro set ejemplares = ejemplares-1 where id=" + txtIdLibro.Text;
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlCommand comando1 = new MySqlCommand(query1,conexion);
            comando.ExecuteNonQuery();
            comando1.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Libro reservado con exito");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select * from reservacion", conexion);
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            adapt.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapt.Fill(tabla);
            dataReserva.DataSource = tabla;
            conexion.Close();
        }
    }
}
