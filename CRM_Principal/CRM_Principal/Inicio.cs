﻿using System;
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
    public partial class login : Form
    {
       //variables publica para la fecha y hora
        public String entrada;
        //variables que se manda al from de Inicio_Principal
        public struct Datos
        { //variable para guardar el ID del usuario que inicia sesión
            public string id_user;
            //variable para guardar el USUARIO del usuario que inicia sesión
            public string usuario;
            //variable para guardar el tipo de usuario(admin o asistente) del usuario que inicia sesión
            public string tipo_usuario;
            //variable para guardar el nombre  del usuario que inicia sesión
            public string nombre;

        }

        public login()
        {
            InitializeComponent();
            //optiene la fecha y hora del sistema Formato 12horas 
            DateTime ahora = DateTime.Now;
            entrada = ahora.ToString("dd-MM-yyyy hh:mm:ss:tt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //conexion de la base de datos al servidor
        //MySqlConnection conectar = new MySqlConnection("server=10.23.249.209;  Uid=doctorjuno; pwd=12345; database=crm;");
        SqlConnection conectar = new SqlConnection("Data Source = 192.168.100.65; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");

        private void button1_Click(object sender, EventArgs e)
        {    
            //conexion avierta
            conectar.Open();
            //variables para abrir conexion y llamar el comando
            // MySqlCommand codigo = new MySqlCommand();
            SqlCommand codigo = new SqlCommand();
            //MySqlConnection conectanos = new MySqlConnection();
            SqlConnection conectanos = new SqlConnection();
            //se declara las variables
            codigo.Connection = conectar;
            codigo.CommandText = ("select * from usuarios where usuario = '" + txtuser.Text + "' and contra = '" + txtpass.Text + "'");
            //se executa la conexion con la consulta
            // MySqlDataReader leer = codigo.ExecuteReader();
            SqlDataReader leer = codigo.ExecuteReader();
            //manda los datos optenidos de la consulta
            if (leer.Read())
            {
                //llamamos la variables para guardar los resultados y mandarlos al from( Inicio_Principal)
                Datos info;
                info.id_user = "1";
                info.usuario = leer.GetString(1);
                info.nombre = leer.GetString(3);
                info.tipo_usuario = leer.GetString(4);
                //se cierra la conexion
                conectar.Close();
                //se vuelve abrir la conexion y manda datos ala tabla Entrada_user "historial de inicio de secion"
                conectar.Open();
                //MySqlCommand registro_usuario = new MySqlCommand();
                SqlCommand registro_usuario = new SqlCommand();
                registro_usuario.Connection = conectar;
                registro_usuario.CommandText = ("insert into entrada_user(on_of,usuario,tipo_user,entrada) values('"+info.id_user+"','" + txtuser.Text+"','"+info.tipo_usuario+"','"+entrada+"')");

                //MySqlDataReader insertado = registro_usuario.ExecuteReader();
                SqlDataReader insertado = registro_usuario.ExecuteReader();
                DialogResult resultado = MessageBox.Show("Bienvenido "+txtuser.Text+"\n Fecha y Hora de Entrada: "+entrada+"", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //llamamos el from Principal y se cierra el actual"
                Inicio_Principal llamar = new Inicio_Principal(info);
                this.Hide();
                llamar.ShowDialog();
                this.Close();

            }
            else
            {
                //mesaje de error en la contraseña o ususario"
                DialogResult resultado = MessageBox.Show("El Usuario o Contraseña incorrecta ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //cierra la conexion de base de datos
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
