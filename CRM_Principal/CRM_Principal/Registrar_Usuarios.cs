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
    public partial class Registrar_Usuarios : Form
    {
        public Registrar_Usuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login inicio = new login();
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=sql3.freemysqlhosting.net; database=sql3364286;Uid=sql3364286;pwd=j1AwNptgUn;");
            conectar.Open();

            MySqlCommand buscaruser = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            buscaruser.Connection = conectar;
            buscaruser.CommandText = ("select * from usuarios where user = '" + ususario.Text + "'");
            
            MySqlDataReader leer = buscaruser.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("ya existe el este usuario");
                conectar.Close();

            }
            else
            {
                conectar.Close();
                conectar.Open();
                MySqlCommand buscanom = new MySqlCommand();
                buscanom.Connection = conectar;
                buscanom.CommandText = ("select * from usuarios where nombre = '" + Nombre.Text + "'");
                MySqlDataReader leer2 = buscanom.ExecuteReader();
                if(leer2.Read())
                {
                    MessageBox.Show("Este nombre ya esta registrado");
                    conectar.Close();
                }
                else
                {
                    conectar.Close();
                    conectar.Open();
                    MySqlCommand agregar_user = new MySqlCommand();
                    agregar_user.Connection = conectar;
                    agregar_user.CommandText = ("insert into usuarios(user,contra,nombre) values('"+ususario.Text+"','"+contra.Text+"','"+Nombre.Text+"')");
                    MySqlDataReader leer3 = agregar_user.ExecuteReader();
                    if (leer3.Read())
                    {
                        MessageBox.Show("Error en guardad");
                    }
                    else
                    {
                        MessageBox.Show("El Usuario Se guardo Exitosamente ");
                        limpiar borrar = new limpiar();
                        borrar.limpiarcampos(this);
                    }
                }


            }
            conectar.Close();
           
        }
        class limpiar
        {
            public void limpiarcampos(Control control)
            {
                foreach(var txt in control.Controls)
                {
                    if (txt is TextBox)
                    {
                        ((TextBox)txt).Clear();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cancelar el guardado? ", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(resultado == DialogResult.Yes)
            {
                login inicio = new login();
                this.Hide();
                inicio.ShowDialog();
                this.Close();

            }
        }
    }
}
