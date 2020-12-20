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
using System.Data.SqlClient;



namespace CRM_Principal.Clientes
{
    public partial class New_clientes : Form
    {
        string nom;
        String ubicacion;
        public New_clientes(Principal.Envio info)
        {
            InitializeComponent();
            Claves();
            text_nombre.Text = info.nom;
            nom = info.nom;
            ubicacion = info.ubicacion;
       
        }

        SqlConnection conectar = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor_cliente; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
         public void Buscar() {
            {//guardar user en el admin
                conectar.Open();
                SqlCommand cliente_pasiente = new SqlCommand();
                SqlConnection conectanos = new SqlConnection();
                cliente_pasiente.Connection = conectar;
                cliente_pasiente.CommandText = ("Select *from usuario WHERE Nombre='"+text_nombre.Text+"';");
                SqlDataReader cliente_user = cliente_pasiente.ExecuteReader();
                if (cliente_user.Read())
                {
                    DialogResult resultado = MessageBox.Show("El Cliente " + text_nombre.Text + " Ya existe en el sistema ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conectar.Close();
                }
                else
                {
                    conectar.Close();
                    Creacion_user();
                }
        }
            

        }

        string usera;
        string contra;
        string clave;
        public void Creacion_user()
        {//user
            string cadena = this.text_nombre.Text;
            usera = cadena.Substring(0, 3);
            //contra
            string cadena_contra = this.txt_telefono.Text;
            contra = usera + cadena_contra.Substring(0, 3);
            //clave
            Buscarclave();


        }

        //funcion de generar clave unica para el usuario
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
            cliente.CommandText = ("select clave from usuario where clave='" + clave + "' ");
            SqlDataReader cliente_user = cliente.ExecuteReader();
            if (cliente_user.Read())
            {
                conectar.Close();
                Claves();
               
                Buscarclave();
            }
            else
            {
                conectar.Close();
                agregar_user();

            }
        }

        //funcion de guardado del ususario
        public void agregar_user()
        {
            conectar.Open();
            SqlCommand agregado_user = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            agregado_user.Connection = conectar;
            agregado_user.CommandText = ("INSERT INTO usuario(Nombre,Telefono,direccion,correo,tipo_ubi,usuario,contra,clave)VALUES(" +
                "'" + text_nombre.Text + "','" + txt_telefono.Text + "','" + Txt_direcc.Text + "','" + Txt_correo.Text + "','"+ubicacion+"','" + usera + "','" + contra + "','" + clave + "') ");
            SqlDataReader cliente_user = agregado_user.ExecuteReader();
            if (cliente_user.Read())
            {
                MessageBox.Show("error");
                conectar.Close();
            }
            else
            {
               
             
                conectar.Close();
                Borar();
              


            }
        }

        //crea propia tabla del ususario
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

                   
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("El Cliente " + text_nombre.Text + " Se registro exitosamente ", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conectar.Close();
                    Correo();
                }
                
               


            }
        }

        //funcion borrar datos del usuario
        public void Borar()
        {
            SqlConnection conectar2 = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
            conectar2.Open();
            SqlCommand agregado_user = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            agregado_user.Connection = conectar2;
            agregado_user.CommandText = ("DELETE FROM clientes_sin_status WHERE Nombre='"+nom+"'");
            SqlDataReader cliente_user = agregado_user.ExecuteReader();
            if (cliente_user.Read())
            {
                conectar2.Close();
                MessageBox.Show("Error");
            }
            else
            {
                conectar2.Close();
                Crear_tabla_user();
                
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        //funcion de enviar correo electronico 
        public void Correo()
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(Txt_correo.Text);
            msg.Subject = "JUNO DOCTOR: Paciente: " + text_nombre.Text + " ";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = "Bienvenido a nuestra Clinica Juno Doctors los datos que nos proporciono se guardaron exitosamente \n" +
                "los siguientes datos son para que ingrese con la app de Android <br>" +
                "Usuario:" + usera + "<br>" +
                "Contraseña: " + contra + "<br>"
                + "<div><p>Descarga la App Juno Doctors: <a href='http://177.228.214.8/junodoctor/Descarga.php'>Descargar</a></p> </div>" + "";
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("manuelangelrmtz19@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("manuelangelrmtz19@gmail.com", "anyel2602@");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(msg);
            }
            catch
            {
                MessageBox.Show("Error correo");
            }

        }
    }
}

