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
    public partial class Actulizar_Datos_user : Form
    {
        public string nombre_user;
        public Actulizar_Datos_user(confi_usuarios.Envio info)
        {
            InitializeComponent();
            nombre_user = info.user;
            Busqueda();
        }

        public void Busqueda()
        {
            MySqlConnection conectar = new MySqlConnection("server=10.23.249.209;  Uid=doctorjuno; pwd=12345; database=crm;");
            conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("select * from usuarios where user = '" + nombre_user + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                Nombre.Text = leer.GetString(3);
                ususario.Text = leer.GetString(1);
                contra.Text = leer.GetString(2);
                tipo_user.Text = leer.GetString(4);
            }
            conectar.Close();
        }

        private void Actulizar_Datos_user_Load(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (tipo_user.Text == "Selecione una Opcion")
            {
                MessageBox.Show("Por favor seleccione un tipo de Usuario");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("en verdad quiere Actualizar los datos ", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    MySqlConnection conectar = new MySqlConnection("server = 10.23.249.209; Uid = doctorjuno; pwd = 12345; database = crm; ");
                    conectar.Open();
                    MySqlCommand actualisar = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    actualisar.Connection = conectar;
                    actualisar.CommandText = ("UPDATE usuarios SET user= '" + ususario.Text + "', contra='"+contra.Text+"',nombre='"+Nombre.Text+"',tipo_user='"+tipo_user.Text+"' WHERE user='" + nombre_user+ "';");
                    MySqlDataReader leer = actualisar.ExecuteReader();

                    MessageBox.Show("Usuario Actualiado");
                }
            }
        }
    }
}
