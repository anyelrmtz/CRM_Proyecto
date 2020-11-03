using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data.Sql;

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
        SqlConnection conectar = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
        public void Busqueda()
        {
            //MySqlConnection conectar = new MySqlConnection("server=10.23.249.209;  Uid=doctorjuno; pwd=12345; database=crm;");
            conectar.Open();

            SqlCommand codigo = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("select * from usuarios where usuario = '" + nombre_user + "'");
            SqlDataReader leer = codigo.ExecuteReader();
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
            if (tipo_user.Text == "Seleccione una Opcion")
            {
                MessageBox.Show("Por favor seleccione un tipo de Usuario");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("En verdad quiere Actualizar los datos ", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    
                    conectar.Open();
                    SqlCommand actualisar = new SqlCommand();
                    SqlConnection conectanos = new SqlConnection();
                    actualisar.Connection = conectar;
                    actualisar.CommandText = ("UPDATE usuarios SET usuario= '" + ususario.Text + "', contra='"+contra.Text+"',nombre='"+Nombre.Text+"',tipo_user='"+tipo_user.Text+"' WHERE user='" + nombre_user+ "';");
                    SqlDataReader leer = actualisar.ExecuteReader();

                    MessageBox.Show("Usuario Actualiado");
                }
            }
        }
    }
}
