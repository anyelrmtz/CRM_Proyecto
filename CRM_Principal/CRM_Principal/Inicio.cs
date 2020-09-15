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
       
        public String entrada;
        public struct Datos
        {
            public string id_user;
            public string usuario;
            public string tipo_usuario;
            public string nombre;

        }

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
            MySqlConnection conectar = new MySqlConnection("server=10.23.249.209;  Uid=doctorjuno; pwd=12345; database=crm;");
            conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("select * from usuarios where user = '" + txtuser.Text + "' and contra = '" + txtpass.Text + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                Datos info;
                info.id_user = "1";
                info.usuario = leer.GetString(1);
                info.nombre = leer.GetString(3);
                info.tipo_usuario = leer.GetString(4);
               
                conectar.Close();
                conectar.Open();
                MySqlCommand registro_usuario = new MySqlCommand();
                registro_usuario.Connection = conectar;
                registro_usuario.CommandText = ("insert into entrada_user(on_of,user,tipo_user,entrada) values('"+info.id_user+"','" + txtuser.Text+"','"+info.tipo_usuario+"','"+entrada+"')");
                MySqlDataReader insertado = registro_usuario.ExecuteReader();
                MessageBox.Show("bienvenido");
                Inicio_Principal llamar = new Inicio_Principal(info);
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
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
