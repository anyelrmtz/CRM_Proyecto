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
    public partial class Especialidad : Form
    {
        public Especialidad()
        {
            InitializeComponent();
        }

        string nombre;

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
            buscar_especial.CommandText = ("Select *from Especialidad WHERE nombre='" + text_especial.Text + "'");
            SqlDataReader datos = buscar_especial.ExecuteReader();
            if (datos.Read())
            {
                conectar.Close();
                MessageBox.Show(" '"+text_especial.Text+"' Ya existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                conectar.Close();
                conectar.Open();
                SqlCommand insertar_especial = new SqlCommand();
                insertar_especial.Connection = conectar;
                insertar_especial.CommandText = ("Insert INTO Especialidad(nombre) Values('" + text_especial.Text + "');");
                SqlDataReader entrada = insertar_especial.ExecuteReader();
                conectar.Close();
                Creo_tabla();
            }


        }
        public void Creo_tabla()
        {
            conectar.Open();
            SqlCommand tabla = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            tabla.Connection = conectar;
            tabla.CommandText = ("CREATE TABLE " + text_especial.Text + "(Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,nombre varchar(50)); ");
            SqlDataReader cliente_user = tabla.ExecuteReader();
            if (cliente_user.Read())
            {
                conectar.Close();
            }
            else
            {
                conectar.Close();
                MessageBox.Show(" '" + text_especial.Text + "' Ingresado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tabla();
            }

        }

        private void Especialidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'junodoctorDataSet3.Especialidad' Puede moverla o quitarla según sea necesario.
            this.especialidadTableAdapter.Fill(this.junodoctorDataSet3.Especialidad);

        }


        public void Tabla()
        {
            this.especialidadTableAdapter.Fill(this.junodoctorDataSet3.Especialidad);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("De se eliminar la Especialidad '"+nombre+"' ? ", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                conectar.Close();
                conectar.Open();
                SqlCommand insertar_especial = new SqlCommand();
                insertar_especial.Connection = conectar;
                insertar_especial.CommandText = ("Delete from Especialidad WHERE nombre='" + nombre + "'");
                SqlDataReader entrada = insertar_especial.ExecuteReader();
                conectar.Close();
                Eliminado();
            }
        }

        public void Eliminado() {
            conectar.Close();
            conectar.Open();
            SqlCommand insertar_especial = new SqlCommand();
            insertar_especial.Connection = conectar;
            insertar_especial.CommandText = ("Delete from "+nombre+";");
            SqlDataReader entrada = insertar_especial.ExecuteReader();
            if (entrada.Read())
            {
                conectar.Close();
            }
            else
            {
                conectar.Close();
                MessageBox.Show(" '" + nombre + "' Fue elimano exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tabla();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
