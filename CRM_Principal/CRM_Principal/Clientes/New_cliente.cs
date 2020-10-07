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

        SqlConnection conectar = new SqlConnection("Data Source = 10.23.249.209; Initial Catalog = junodoctor_cliente; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
         public void Buscar() {
            {//guardar user en el admin
                conectar.Open();
                SqlCommand cliente_pasiente = new SqlCommand();
                SqlConnection conectanos = new SqlConnection();
                cliente_pasiente.Connection = conectar;
                cliente_pasiente.CommandText = ("Select *from usuari WHERE Nombre='"+text_nombre.Text+"';");
                SqlDataReader cliente_user = cliente_pasiente.ExecuteReader();
                if (cliente_user.Read())
                {
                    DialogResult resultado = MessageBox.Show("el cliente " + text_nombre.Text + " Ya existe en el sistema ", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conectar.Close();
                }
                else
                {

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
        public void Claves()
        {
            Random obj = new Random();
            String posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
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
                "'" + text_nombre.Text + "','" + txt_telefono.Text + "','" + Txt_direcc.Text + "','" + Txt_correo.Text + "','"+ubicacion+"','" + usera + "','" + contra + "','" + clave + "') ");
            SqlDataReader cliente_user = agregado_user.ExecuteReader();
            if (cliente_user.Read())
            {
                MessageBox.Show("error");
                conectar.Close();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("el cliente " + text_nombre.Text + " Se registro exitosamente ", "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
                conectar.Close();
                

            }
        }
        public void Borar()
        {
            SqlConnection conectar2 = new SqlConnection("Data Source = 10.23.249.209; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
            conectar2.Open();
            SqlCommand agregado_user = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            agregado_user.Connection = conectar2;
            agregado_user.CommandText = ("DELETE FROM clientes_sin_status WHERE Nombre='"+nom+"'");
            SqlDataReader cliente_user = agregado_user.ExecuteReader();
            conectar2.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creacion_user();
        }
    }
}

