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
using CRM_Principal.Clientes;


namespace CRM_Principal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        
        private void Principal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'junodoctor_clienteDataSet3.Prospectos' Puede moverla o quitarla según sea necesario.
            this.prospectosTableAdapter.Fill(this.junodoctor_clienteDataSet3.Prospectos);
            // TODO: esta línea de código carga datos en la tabla 'junodoctor_clienteDataSet2.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.junodoctor_clienteDataSet2.usuario);
            // TODO: esta línea de código carga datos en la tabla 'junodoctorDataSet6.clientes_sin_status' Puede moverla o quitarla según sea necesario.
            this.clientes_sin_statusTableAdapter.Fill(this.junodoctorDataSet6.clientes_sin_status);

        }
        public struct Envio
        { //variable para nombre
            public string nom;
            //variable para telefono
            public string ubicacion;

        }
        string nombre;
        string ubica;

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conectar = new SqlConnection("Data Source = 192.168.100.65; Initial Catalog = junodoctor_cliente; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            conectar.Open();
            SqlCommand cdm = conectar.CreateCommand();
            cdm.CommandType = CommandType.Text;
            cdm.CommandText = "Select *from usuario where Nombre like ('" + textBox2.Text + "%')";
            cdm.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cdm);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conectar.Close();
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            

        }
        SqlConnection conectar2 = new SqlConnection("Data Source = 192.168.100.65; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");

        //barra de busqueda
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conectar2.Open();
            SqlCommand cdm = conectar2.CreateCommand();
            cdm.CommandType = CommandType.Text;
            cdm.CommandText = "Select *from clientes_sin_status where Nombre like ('" + textBox1.Text + "%')";
            cdm.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cdm);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conectar2.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString();
             ubica = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            button1.Enabled = true;

        }
        //manda informacion del cliente
        public void mandar()
        {
            Envio info;
            info.nom = nombre;
            info.ubicacion = ubica;
            New_clientes entrada = new New_clientes(info);
            entrada.ShowDialog();
         }

        private void button1_Click(object sender, EventArgs e)
        {
            mandar();
        }
    }
}
