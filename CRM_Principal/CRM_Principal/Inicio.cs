using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRM_Principal
{
    public partial class login : Form
    {
        public String tipo_user;
        public String entrada;
        public String nombre;

        public login()
        {
            InitializeComponent();
            DateTime ahora = DateTime.Now;
            entrada = ahora.ToString("dd-MM-yyyy hh:mm:ss:tt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=sql3.freemysqlhosting.net; database=sql3364286;Uid=sql3364286;pwd=j1AwNptgUn;");
            conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("select * from usuarios where user = '" + txtuser.Text + "' and contra = '" + txtpass.Text + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                tipo_user = leer.GetString(4);
               nombre = leer.GetString(3);
                conectar.Close();
                conectar.Open();
                MySqlCommand registro_usuario = new MySqlCommand();
                registro_usuario.Connection = conectar;
                registro_usuario.CommandText = ("insert into entrada_user(user,tipo_user,entrada) values('"+txtuser.Text+"','"+tipo_user+"','"+entrada+"')");
                MySqlDataReader insertado = registro_usuario.ExecuteReader();
                MessageBox.Show("bienvenido");
                Inicio_Principal llamar = new Inicio_Principal();
                llamar.tipo_user = tipo_user;
                llamar.nombre_user = nombre;
                this.Hide();
                llamar.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("contraseña o usuario no existe");
            }
            conectar.Close();
        }

        private void Registro_Click(object sender, EventArgs e)
        {
            Registrar_Usuarios nuevo = new Registrar_Usuarios();
            this.Hide();
            nuevo.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
