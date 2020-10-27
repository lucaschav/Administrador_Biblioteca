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
    public partial class Socio : Form
    {
        public Socio()
        {
            InitializeComponent();
        }

        MySqlConnection conexion = new MySqlConnection("Server=" + Ajustes.datos_conect[0] + ";" + "Database=" + Ajustes.datos_conect[1] + ";" + "Uid=" + Ajustes.datos_conect[2] + ";" + "Password=" + Ajustes.datos_conect[3] + ";");

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "insert into socio(nombre,apellido,dni,telefono,direccion) values ('" + txtNombre.Text + "','" + txtApelli.Text + "','" + txtDni.Text + "','" + txtTelef.Text + "','" + txtDirec.Text + "');";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Socio registrado con exito");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("select * from socio", conexion);
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            adapt.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapt.Fill(tabla);
            dataSocio.DataSource = tabla;
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string query = "select * from socio where " + comboBox1.Text + " like '%" + txtBuscar.Text + "%'";
            MySqlDataAdapter adapt = new MySqlDataAdapter(query, conexion);
            DataSet tabla = new DataSet();
            adapt.Fill(tabla, "socio");
            dataSocio.DataSource = tabla;
            dataSocio.DataMember = "socio";
            conexion.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
