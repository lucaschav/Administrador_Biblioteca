using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace Biblioteca
{
    public partial class Ajustes : Form
    {
        public Ajustes()
        {
            InitializeComponent();
        }

        public static List<string> datos_conect = new List<string>();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextWriter nuevo = new StreamWriter("DBConfig.txt");
            nuevo.Close();
            MessageBox.Show("Datos Eliminado Correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader leer = File.OpenText("DBConfig.txt");
                string aux;
                while (!leer.EndOfStream)
                {
                    aux = leer.ReadLine();
                    datos_conect.Add(aux);
                }
                leer.Close();

                txtNombreServer.Text = datos_conect[0];
                txtNombreDB.Text = datos_conect[1];
                txtUid.Text = datos_conect[2];
                txtPass.Text = datos_conect[3];
            }
            catch
            {
                MessageBox.Show("No hay Datos Para Cargar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter nuevo = new StreamWriter("DBConfig.txt");
            nuevo.Close();
            StreamWriter archivo = File.AppendText("DBConfig.txt");
            archivo.WriteLine(txtNombreServer.Text);
            archivo.WriteLine(txtNombreDB.Text);
            archivo.WriteLine(txtUid.Text);
            archivo.WriteLine(txtPass.Text);
            archivo.Close();
            MessageBox.Show("Guardado con Exito");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("Server=" + datos_conect[0] + ";" +  "Database=" + datos_conect[1] + ";" + "Uid=" + datos_conect[2] + ";" + "Password=" + datos_conect[3] + ";");
            try
            {
                conexion.Open();
                MessageBox.Show("Conectado");
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error de Conexion");
            }
        }
    }
}
