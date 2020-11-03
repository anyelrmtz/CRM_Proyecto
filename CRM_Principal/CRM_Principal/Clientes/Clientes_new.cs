using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using CRM_Principal.Clientes;
using System.Data.SqlClient;
using CRM_Principal.Agenda;

namespace CRM_Principal.Clientes
{
    public partial class Clientes_new : Form
    {
        public Clientes_new(AC_Niños.Datos info )
        {
            InitializeComponent();
            Claves();
            text_nombre.Text = info.nom;
            txt_telefono.Text = info.tel;
            Txt_correo.Text = info.correo;
            
            
        }
        public Clientes_new(AC_Adultos.Datos info2 )
        {
            InitializeComponent();
            Claves();
            text_nombre.Text = info2.nom;
            txt_telefono.Text = info2.tel;
            Txt_correo.Text = info2.correo;
        }
        
        //conexion
        SqlConnection conectar = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor_cliente ; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");

        string usera;
        string contra;
        string clave;
        public void Creacion_user()
        {//user
            string cadena = this.text_nombre.Text;
            usera = cadena.Substring(0,3);
            //contra
            string cadena_contra = this.txt_telefono.Text;
            contra = usera + cadena_contra.Substring(0, 3);
            //clave
            Buscarclave();
            

        }
     public void Claves()
        {
            Random obj = new Random();
            String posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int longitud = posibles.Length;
            char letra;
            char letra2;
            char letra3;
            char letra4;
            int longitudnuevacadena = 5;
            string nuevacadena = "";

            for (int i = 0; i < longitudnuevacadena; i++)
            {
                letra = posibles[obj.Next(longitud)];
                letra2 = posibles[obj.Next(longitud)];
                letra3 = posibles[obj.Next(longitud)];
                letra4 = posibles[obj.Next(longitud)];
                nuevacadena += letra.ToString();

            }
            clave = nuevacadena;

        }

        public void Buscarclave()
        {//busca usuario
            conectar.Open();
            SqlCommand cliente = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            cliente.Connection = conectar;
            cliente.CommandText = ("select clave from usuario where clave='" +clave+ "' ");
            SqlDataReader cliente_user = cliente.ExecuteReader();
            if (cliente_user.Read())
            {
                Claves();
                conectar.Close();
                Buscarclave();
            }
            else
            {
                conectar.Close();
                agregar_user();

            }
        }
        public void agregar_user()
        {
            conectar.Open();
            SqlCommand agregado_user = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            agregado_user.Connection = conectar;
            agregado_user.CommandText = ("INSERT INTO usuario(Nombre,Telefono,direccion,correo,tipo_ubi,usuario,contra,clave)VALUES(" +
                "'"+text_nombre.Text+"','"+txt_telefono.Text+"','"+Txt_direcc.Text+"','"+Txt_correo.Text+"','Clinica','"+usera+"','"+contra+"','"+clave+"') ");
            SqlDataReader cliente_user = agregado_user.ExecuteReader();
            if (cliente_user.Read())
            {
                MessageBox.Show("error");
                conectar.Close();
            }
            else
            {
                conectar.Close();
                Crear_tabla_user();

            }
        }
    
        public void Crear_tabla_user()
        {
            conectar.Open();
            SqlCommand agregado_user = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            agregado_user.Connection = conectar;
            agregado_user.CommandText = ("CREATE TABLE "+clave+"(Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,nombre_paciente varchar(50), fehca_nac varchar(50),edad varchar(8),estatus varchar(8)); ");
            SqlDataReader cliente_user = agregado_user.ExecuteReader();
            if (cliente_user.Read())
            {
                MessageBox.Show("Error");
                conectar.Close();
            }
            else
            {
                
                if (Txt_correo.Text == "")
                {
                    conectar.Close();
                    MessageBox.Show("El Cliente fue Agregado en el sistema Correctamente");
                    Limpiar();
                }
                else{
                    conectar.Close();
                    MessageBox.Show("El Cliente fue Agregado en el sistema Correctamente");
                    Correo();
                    Limpiar();
                }
               

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void Limpiar()
        {
            text_nombre.Clear();
            txt_telefono.Clear();
            Txt_correo.Clear();
            Txt_direcc.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creacion_user();
            
        }
        public void Correo()
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(Txt_correo.Text);
            msg.Subject = "JUNO DOCTOR: Paciente: "+text_nombre.Text+" ";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body= "Bienvenido a nuestra Clinica Juno Doctors los datos que nos proporciono se guardaron exitosamente \n" +
                "los siguientes datos son para que ingrese con la app de Android <br>" +
                "Usuario:" + usera + "<br>" +
                "Contraseña: " + contra + " ";
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("manuelangelrmtz19@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("manuelangelrmtz19@gmail.com", "anyel123@");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try {
                cliente.Send(msg);
            } catch
            {
                MessageBox.Show("error correo");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
