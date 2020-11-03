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
    public partial class Vacunas_new : Form
    {
        public Vacunas_new()
        {
            InitializeComponent();
        }
        string nombre;
        private void Vacunas_new_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'junodoctorDataSet_vacunasnew.Vacuna' Puede moverla o quitarla según sea necesario.
            Tablita();

        }
        public void Tablita()
        {
            this.vacunaTableAdapter.Fill(this.junodoctorDataSet_vacunasnew.Vacuna);
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
            buscar_especial.CommandText = ("Select *from Vacuna WHERE Nombre='" + text_vacuna.Text + "'");
            SqlDataReader datos = buscar_especial.ExecuteReader();
            if (datos.Read())
            {
                conectar.Close();
                MessageBox.Show(" '" + text_vacuna.Text + "' Ya existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                conectar.Close();
                conectar.Open();
                SqlCommand insertar_especial = new SqlCommand();
                insertar_especial.Connection = conectar;
                insertar_especial.CommandText = ("Insert INTO Vacuna(Nombre) Values('" + text_vacuna.Text + "');");
                SqlDataReader entrada = insertar_especial.ExecuteReader();
                conectar.Close();
                MessageBox.Show(" '" + text_vacuna.Text + "' fue Registrado exitosamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tablita();
                text_vacuna.Clear();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("De se eliminar la Vacuna '" + nombre + "' ? ", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                conectar.Close();
                conectar.Open();
                SqlCommand insertar_especial = new SqlCommand();
                insertar_especial.Connection = conectar;
                insertar_especial.CommandText = ("Delete from Vacuna WHERE Nombre='" + nombre + "'");
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
