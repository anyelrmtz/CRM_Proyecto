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
namespace CRM_Principal.configuracion_user
{
    public partial class Doctores : Form
    {
        public Doctores()
        {
            InitializeComponent();
            Especialida();
            buscar();

        }

        //funcion mostrar las especialidades exitentes en la base de datos
        public void Especialida()
        {
            try
            {
                conectar.Open();
                SqlCommand Especialidad = new SqlCommand();
                SqlConnection conectanos = new SqlConnection();
                Especialidad.Connection = conectar;
                Especialidad.CommandText = ("select Nombre from Especialidad ");

                SqlDataReader leer = Especialidad.ExecuteReader();
                while (leer.Read())
                {
                    combo_especialidad.Items.Add(leer["nombre"].ToString());

                }
                conectar.Close();
            }
            catch
            {

            }



        }

        //busca la especialidad
        public void buscar()
        {
            try
            {
                conectar.Open();
                SqlCommand Especialidad2 = new SqlCommand();
                SqlConnection conectanos = new SqlConnection();
                Especialidad2.Connection = conectar;
                Especialidad2.CommandText = ("select Nombre from Especialidad ");

                SqlDataReader leer = Especialidad2.ExecuteReader();
                while (leer.Read())
                {
                    Buscar_doctor.Items.Add(leer["nombre"].ToString());

                }
                conectar.Close();
            }
            catch
            {

            }



        }

        //MySqlConnection conectar = new MySqlConnection("server=10.23.249.209;  Uid=doctorjuno; pwd=12345; database=crm;");
        SqlConnection conectar = new SqlConnection("Data Source = 192.168.100.65; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");

        //boton de guardado 
        private void btn_guardar_new_Click(object sender, EventArgs e)
        {
            conectar.Open();
            SqlCommand agregar_Doctor = new SqlCommand();
            agregar_Doctor.Connection = conectar;
            agregar_Doctor.CommandText = ("Select *from Doctor WHERE Nombre='" + txt_nombre.Text + "'");
            SqlDataReader datos = agregar_Doctor.ExecuteReader();
            if (datos.Read())
            {
                conectar.Close();
                Especialidad();
            }
            else
            {
                Guardado();

            }

        }
        
        //funcion de Guardado  en la base de datos
        public void Guardado()
        {
            conectar.Close();
            conectar.Open();
            SqlCommand agregar_Doctor = new SqlCommand();
            agregar_Doctor.Connection = conectar;
            agregar_Doctor.CommandText = ("INSERT INTO Doctor(Nombre,telefono,correo)Values('" + txt_nombre.Text + "','" + text_telefono.Text + "','" + text_correo.Text + "')");
            SqlDataReader datos = agregar_Doctor.ExecuteReader();
            if (datos.Read())
            {
                conectar.Close();
            }
            else
            {
                conectar.Close();
                Especialidad();

            }
        }

        //busca en la expecialidad si el doctor existe
        public void Especialidad()
        {
            if (combo_especialidad.Text == combo_especialidad.Text)
            {
                conectar.Open();
                SqlCommand buscar_Doctor = new SqlCommand();
                buscar_Doctor.Connection = conectar;
                buscar_Doctor.CommandText = ("SELECT *FROM " + combo_especialidad.Text + " WHERE nombre='" + txt_nombre.Text + "';");
                SqlDataReader datos = buscar_Doctor.ExecuteReader();
                if (datos.Read())
                {
                    MessageBox.Show("" + txt_nombre.Text + " Ya existe en la Especialidad de " + combo_especialidad.Text + " ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conectar.Close();
                }
                else
                {
                    conectar.Close();
                    conectar.Open();
                    SqlCommand agregar_Doctor = new SqlCommand();
                    agregar_Doctor.Connection = conectar;
                    agregar_Doctor.CommandText = ("insert into " + combo_especialidad.Text + "(nombre) VALUES('" + txt_nombre.Text + "');");
                    SqlDataReader guardado = agregar_Doctor.ExecuteReader();
                    if (guardado.Read())
                    {
                        conectar.Close();
                    }
                    else
                    {
                        conectar.Close();
                        MessageBox.Show("" + txt_nombre.Text + " Se registro correctamente en la Especialidad " + combo_especialidad.Text + " ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        Tablita_doct();
                    }

                }

            }
        }


        //boton de actualisar los datos del doctor
        private void butn_actualizar_Click(object sender, EventArgs e)
        {
            Actualisar();
        }
        string especialidades;
        string nombres;
        public void Actualisar()
        {
            conectar.Open();
            SqlCommand actualisar = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            actualisar.Connection = conectar;
            actualisar.CommandText = ("UPDATE Doctor SET Nombre= '" + text_actualisa.Text + "', telefono='" + text_actualisar_tele.Text + "', correo='" + text_actualizar_coreeo.Text + "' WHERE Nombre='" + nombres + "';");
            SqlDataReader leer = actualisar.ExecuteReader();
            if (leer.Read())
            {
                conectar.Close();
            }
            else
            {
                conectar.Close();
                conectar.Open();
                SqlCommand actualisar_especialidad = new SqlCommand();
                SqlConnection connection2 = new SqlConnection();
                actualisar.Connection = conectar;
                actualisar.CommandText = ("DELETE FROM " + especialidades + " WHERE nombre='" + nombres + "';");
                SqlDataReader eliminar = actualisar.ExecuteReader();
                if (eliminar.Read())
                {
                    conectar.Close();
                }
                else
                {
                    conectar.Close();
                    conectar.Open();
                    SqlCommand actualisado = new SqlCommand();
                    SqlConnection conectanos3 = new SqlConnection();
                    actualisado.Connection = conectar;
                    actualisado.CommandText = ("insert into " + combo_actualizar_espe.Text + "(nombre) VALUES('" + text_actualisa.Text + "');");
                    SqlDataReader leer2 = actualisado.ExecuteReader();
                    MessageBox.Show(" Actualiado Correctamente");
                    conectar.Close();
                    groupBox2.Enabled = false;
                    limpiando();
                    Tablita_doct();

                }

            }

        }

        //funcion limpiar los campos
        public void limpiando()
        {
            foreach (Control c in this.groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                    this.text_actualisa.Focus();
                }
            }
            foreach (Control ctrl in this.groupBox2.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.SelectedIndex = -1;
                }
            }
        }

        private void Doctores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'junodoctorDataSet4.Doctor' Puede moverla o quitarla según sea necesario.

            this.doctorTableAdapter.Fill(this.junodoctorDataSet4.Doctor);
        }
        public void Tablita_doct()
        {
            this.doctorTableAdapter.Fill(this.junodoctorDataSet4.Doctor);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void Buscar_doctor_SelectedIndexChanged(object sender, EventArgs e)
        {

            string orden = "SELECT nombre FROM " + Buscar_doctor.Text + "";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(orden, conectar);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            datos_Especialisados.ReadOnly = true;
            datos_Especialisados.DataSource = ds.Tables[0];


        }

        private void datos_Especialisados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox2.Enabled = true;
            nombres = datos_Especialisados.CurrentRow.Cells[0].Value.ToString();
            especialidades = Buscar_doctor.Text;
            text_actualisa.Text = nombres;
            combo_actualizar_espe.Text = especialidades;
            
            Buscar_o();
            Especia();


        }
        public void Buscar_o()
        {
            conectar.Close();
            conectar.Open();
            SqlCommand buscar_Doctor = new SqlCommand();
            buscar_Doctor.Connection = conectar;
            buscar_Doctor.CommandText = ("SELECT *from Doctor WHERE nombre='" + nombres + "';");
            SqlDataReader datos = buscar_Doctor.ExecuteReader();
            if (datos.Read())
            {
                text_actualisar_tele.Text= datos.GetString(2);
                text_actualizar_coreeo.Text= datos.GetString(3);

                conectar.Close();

            }


            }
        public void Especia()
        {
            try
            {
                conectar.Open();
                SqlCommand Especialidad = new SqlCommand();
                SqlConnection conectanos = new SqlConnection();
                Especialidad.Connection = conectar;
                Especialidad.CommandText = ("select Nombre from Especialidad ");

                SqlDataReader leer = Especialidad.ExecuteReader();
                while (leer.Read())
                {
                    combo_actualizar_espe.Items.Add(leer["nombre"].ToString());

                }
                conectar.Close();
            }
            catch
            {

            }



        }

    }

}

