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

namespace CRM_Principal.configuracion_user.servicios
{
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }
        string nombre;
        private void Servicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'junodoctorDataSet5.Servicios' Puede moverla o quitarla según sea necesario.
            Tablita();

        }
        public void Tablita()
        {
            this.serviciosTableAdapter.Fill(this.junodoctorDataSet5.Servicios);
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Guardado();
        }
        SqlConnection conectar = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
        public void Guardado()
        {
            conectar.Open();
            SqlCommand buscar_especial = new SqlCommand();
            buscar_especial.Connection = conectar;
            buscar_especial.CommandText = ("Select *from Servicios WHERE Nombre='" + text_Servicios.Text + "'");
            SqlDataReader datos = buscar_especial.ExecuteReader();
            if (datos.Read())
            {
                conectar.Close();
                MessageBox.Show(" '" + text_Servicios.Text + "' Ya existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                conectar.Close();
                conectar.Open();
                SqlCommand insertar_especial = new SqlCommand();
                insertar_especial.Connection = conectar;
                insertar_especial.CommandText = ("Insert INTO Servicios(Nombre) Values('" + text_Servicios.Text + "');");
                SqlDataReader entrada = insertar_especial.ExecuteReader();
                conectar.Close();
                MessageBox.Show(" '" + text_Servicios.Text + "' fue Registrado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tablita();
                text_Servicios.Clear();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("De se eliminar el Servicio '" + nombre + "' ? ", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                conectar.Close();
                conectar.Open();
                SqlCommand insertar_especial = new SqlCommand();
                insertar_especial.Connection = conectar;
                insertar_especial.CommandText = ("Delete from Servicios WHERE Nombre='" + nombre + "'");
                SqlDataReader entrada = insertar_especial.ExecuteReader();
                conectar.Close();
                Tablita();
                button1.Enabled = false;


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            button1.Enabled = true;
        }
    }
}
