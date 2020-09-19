using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace CRM_Principal
{
    public partial class Cotizacion : Form
    {
        public Cotizacion()
        {
            InitializeComponent();
            Bloqueo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comb_cotizar.Text== "Selecione una Opcion")
            {
                MessageBox.Show("Selecione una Cotizacion");
            }
            else
            {
                if(combo_tipo.Text== "Selecione una Opcion")
                {
                    MessageBox.Show("Selecione un tipo ");
                }
                else
                {
                    if(combo_servicio.Text== "Selecione una Opcion")
                    {
                        MessageBox.Show("Seleccione un Servicio");
                    }
                    else
                    {
                        if (cantidad_text.Text == "")
                        {
                            MessageBox.Show("ingrese un monto");
                        }
                        else
                        {
                            MessageBox.Show("agrgado exitosamente, este mensaje es de prueba no agrega datos a la BD");
                        }
                    }
                }
            }
        }
        //bloquea combobos asta llenar los campos
        public void Bloqueo()
        {
            if (comb_cotizar.Text == "Selecione una Opcion")
            {
                combo_tipo.Enabled = false;
                cantidad_text.Enabled = false;
                

            }
        }

        private void combo_tipo_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comb_cotizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comb_cotizar_TabIndexChanged(object sender, EventArgs e)
        {

        }
        // verificamos que el combobox este con alguna opcion
        private void comb_cotizar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(comb_cotizar.SelectedItem.ToString()== "Gastos")
            {
                Gastos();
               
            }
            
            else if (comb_cotizar.SelectedItem.ToString() == "Ingresos")
            {

                Ingresos();
            }

        }
        public void Ingresos()
        {
            combo_servicio.Text = "Selecione una Opcion";
            combo_tipo.Items.Clear();
            combo_tipo.Text = "Selecione una Opcion";
            combo_tipo.Items.Add("Procedimientos");

            combo_servicio.Items.Clear();
        }
        public void Gastos()
        {

            combo_servicio.Text = "Selecione una Opcion";
            combo_tipo.Text = "Selecione una Opcion";
            combo_tipo.Items.Clear();
            combo_tipo.Enabled = true;
            combo_tipo.Items.Add("Vacunas");
            combo_tipo.Items.Add("Servicios");

        }


        SqlConnection conectar = new SqlConnection("Data Source = 10.23.249.209; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
        //vacunas,procesos,Consultas,Talleres,Cursos,Servicios
        public void Vacuna()
        {
            combo_servicio.Items.Clear();
            conectar.Open();

            SqlCommand medician = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            medician.Connection = conectar;
            medician.CommandText = ("select Nombre from Vacuna ");

            SqlDataReader leer = medician.ExecuteReader();
            while (leer.Read())
            {
                combo_servicio.Items.Add(leer["Nombre"].ToString());
            }
            
            conectar.Close();
        }

        public void Procesos(){
            combo_servicio.Items.Clear();
            conectar.Open();
            
            SqlCommand proce = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            proce.Connection = conectar;
            proce.CommandText = ("select Nombre from Procedimiento ");

            SqlDataReader leer = proce.ExecuteReader();
            while (leer.Read())
            {
                combo_servicio.Items.Add(leer["Nombre"].ToString());
            }

            conectar.Close();
        }
       /* public void Taller()
        {

        }
        public void Cursos()
        {

        }*/
        public void Servicio()

        {
            combo_servicio.Items.Clear();
            conectar.Open();

            SqlCommand serv = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            serv.Connection = conectar;
            serv.CommandText = ("select Nombre from Servicios ");

            SqlDataReader leer = serv.ExecuteReader();
            while (leer.Read())
            {
                combo_servicio.Items.Add(leer["Nombre"].ToString());
            }

            conectar.Close();
        }
        //seleciona tipo de dato
        private void combo_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_tipo.SelectedItem.ToString() == "Vacunas")
            {
                
                Vacuna();

            }
            else if (combo_tipo.SelectedItem.ToString() == "Procedimientos")
            {
                Procesos();
            }
            else if (combo_tipo.SelectedItem.ToString() == "Servicios")
            {
                Servicio();
            }
        }

        private void combo_servicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_servicio.SelectedItem.ToString() == "")
            {
                cantidad_text.Enabled = false;
            }
            else
            {
                cantidad_text.Enabled = true;
            }
        }
    }
}

