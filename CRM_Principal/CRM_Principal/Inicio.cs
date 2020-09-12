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
        public login()
        {
            InitializeComponent();
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
                MessageBox.Show("bienvenido");
                Inicio_Principal llamar = new Inicio_Principal();
                this.Hide();
                llamar.ShowDialog();
                llamar.tipo_user = leer.GetString(3);
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
    }
}
