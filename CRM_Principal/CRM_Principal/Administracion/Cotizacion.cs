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
        //variable fecha hora
        public String Hora_fecha;
     
        public Cotizacion()
        {
            InitializeComponent();
            Bloqueo();
            DateTime ahora = DateTime.Now;
            Hora_fecha = ahora.ToString("dd-MM-yyyy hh:mm:ss:tt");
        }
      
        //guardado de cotizacion
        private void button1_Click(object sender, EventArgs e)
        {
            if (combo_tipo.Text == "Otros")
            {
                enviado();
            }
            else
            {
                if (comb_cotizar.Text == "Selecione una Opcion")
                {
                    MessageBox.Show("Selecione una Cotizacion");
                }
                else
                {
                    if (combo_tipo.Text == "Selecione una Opcion")
                    {
                        MessageBox.Show("Selecione un tipo ");
                    }
                    else
                    {
                        if (combo_servicio.Text == "Selecione una Opcion")
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


                                enviado();


                            }
                        }
                    }
                }
            }
            
        }

        //funcion de verificacion 
        public void enviado()
        {
            DialogResult resultado = MessageBox.Show("Verifique los siguientes datos \n " +
                               "Cotizar: " + comb_cotizar.Text + "" + "\n" + "tipo: " + combo_tipo.Text + " \n" + "Servicio: " + combo_servicio.Text + "\n" + "Descripción: " + textbox_descrip.Text + "\n" + "Costo: " + cantidad_text.Text + "\n" + "Desea guardar los Datos?", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {


                conectar.Open();
                SqlCommand agregar_cotizacion = new SqlCommand();
                agregar_cotizacion.Connection = conectar;
                agregar_cotizacion.CommandText = ("insert into Cotizacion(fech_hora,cotizar,tipo_cot,servi,Descrip,cost) values('" + Hora_fecha + "','" + comb_cotizar.Text + "','" + combo_tipo.Text + "','" + combo_servicio.Text + "','" + textbox_descrip.Text + "',CONVERT(VARCHAR, CONVERT(VARCHAR, CAST('"+cantidad_text.Text+"'  AS MONEY), 1)));");
                SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
                if (cotizacion.Read())
                {
                    MessageBox.Show("Error");
                    conectar.Close();
                }
                else
                {
                    MessageBox.Show("Agregado exitosamente");
                    conectar.Close();
                    limpiar();
                    Cargar_tabla();
                }
            }
        }
        //limpiesa
        public void limpiar()
        {
            combo_servicio.Text = "Selecione una Opcion";
            combo_tipo.Text = "Selecione una Opcion";
            comb_cotizar. Text = "Selecione una Opcion";
            textbox_descrip.Clear();
            cantidad_text.Clear();
            combo_tipo.Enabled = false;
            cantidad_text.Enabled = false;

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
            combo_tipo.Enabled = true;
            combo_tipo.Text = "Selecione una Opcion";
            combo_tipo.Items.Add("Vacunas");
            combo_tipo.Items.Add("Otros");
            combo_servicio.Enabled = false;

            combo_servicio.Items.Clear();
        }
        public void Gastos()
        {
            combo_servicio.Enabled = false;
            combo_servicio.Text = "Selecione una Opcion";
            combo_tipo.Text = "Selecione una Opcion";
            combo_tipo.Items.Clear();
            combo_tipo.Enabled = true;
            combo_tipo.Items.Add("Vacunas");
            combo_tipo.Items.Add("Servicios");
            combo_tipo.Items.Add("Otros");

        }


        SqlConnection conectar = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
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
            combo_servicio.Enabled = true;
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
            combo_servicio.Enabled = true;
        }
       public void otros()
        {
            combo_servicio.Enabled = false;
            cantidad_text.Enabled = true;
            
        }
        /* public void Cursos()
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
            combo_servicio.Enabled = true;
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
            else if (combo_tipo.SelectedItem.ToString() == "Otros")
            {
                otros();
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

        private void Cotizacion_Load(object sender, EventArgs e)
        {
            Cargar_tabla();
        }
        //carga la tabla
        public void Cargar_tabla()
        {
            this.cotizacionTableAdapter.Fill(this.junodoctorDataSet2.Cotizacion);
        }

        private void cantidad_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox4.SelectedItem.ToString() == "Ingreso")
            {
                comboBox5.Enabled = true;
                string orden = "SELECT *FROM Cotizacion WHERE cotizar='"+comboBox4.Text+"';";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(orden, conectar);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                comboBox5.Enabled = true;
                string orden = "SELECT *FROM Cotizacion WHERE cotizar='" + comboBox4.Text + "';";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(orden, conectar);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                string orden = "SELECT *FROM Cotizacion WHERE cotizar='" + comboBox4.Text + "' AND tipo_cot='"+comboBox5.Text+"';";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(orden, conectar);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            comboBox5.Enabled = false;

            
        }
    }
}

