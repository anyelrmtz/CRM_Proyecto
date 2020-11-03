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
        SqlConnection conectar = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");

        private void button1_Click(object sender, EventArgs e)
        {
            //MySqlConnection conectar = new MySqlConnection("server=10.23.249.209;  Uid=doctorjuno; pwd=12345; database=crm;");
            conectar.Open();

            SqlCommand buscaruser = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            buscaruser.Connection = conectar;
            buscaruser.CommandText = ("select *from usuarios WHERE usuario = '" + ususario.Text + "'");
            
            SqlDataReader leer = buscaruser.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Ya existe el este Usuario");
                conectar.Close();

            }
            else
            {
                conectar.Close();
                conectar.Open();
                SqlCommand buscanom = new SqlCommand();
                buscanom.Connection = conectar;
                buscanom.CommandText = ("select * from usuarios where nombre = '" + Nombre.Text + "'");
                SqlDataReader leer2 = buscanom.ExecuteReader();
                if(leer2.Read())
                {
                    MessageBox.Show("Este nombre ya esta registrado");
                    conectar.Close();
                }
                else
                {
                    conectar.Close();
                    DialogResult resultado = MessageBox.Show("Desea guardar los datos Ingresados? ", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        conectar.Open();
                        SqlCommand agregar_user4 = new SqlCommand();
                        agregar_user4.Connection = conectar;
                        agregar_user4.CommandText = ("insert into usuarios(usuario,contra,nombre,tipo_user) values('" + ususario.Text + "','" + contra.Text + "','" + Nombre.Text + "','"+tipo_user.Text+"')");
                        SqlDataReader leer3 = agregar_user4.ExecuteReader();
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
                    } else if(txt is ComboBox)
                    {
                        ((ComboBox)txt).SelectedIndex = 0;
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
