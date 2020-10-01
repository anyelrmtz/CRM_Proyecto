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
namespace CRM_Principal.Agenda
{
    public partial class Ver_citas : Form
    {
        public Ver_citas()
        {
            InitializeComponent();
            btn_pagar.Enabled = false;
          
        }
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //beta de calendario
     /*   public void Calendario()
        {
           
            SqlConnection conectar = new SqlConnection("Data Source = 10.23.249.209; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
            conectar.Open();

            SqlCommand calen = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            calen.Connection = conectar;
            calen.CommandText = ("select fecha from Prueba ");

            SqlDataReader leer = calen.ExecuteReader();
               
            while(leer.Read())
            {


                this.Calendario_citas.AnnuallyBoldedDates = new DateTime[]
                { 
                     DateTime.Parse(leer[0].ToString()),
                   

                     

                     }; 
                
                
            
            
            
            }
            

            

        }*/

        private void Ver_citas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'junodoctor_clienteDataSet1.consul_adulto' Puede moverla o quitarla según sea necesario.
            this.consul_adultoTableAdapter.Fill(this.junodoctor_clienteDataSet1.consul_adulto);
            // TODO: esta línea de código carga datos en la tabla 'junodoctor_clienteDataSet.consul_nino' Puede moverla o quitarla según sea necesario.
            this.consul_ninoTableAdapter.Fill(this.junodoctor_clienteDataSet.consul_nino);


        }
        public struct Envio
        {
            public string nombre2;
            public string estado2;
            public string modo2;

        }

        string nombre;
        string estado;
        string modo;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Calendario_citas.BoldedDates = new DateTime[]
            {
                DateTime.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),
               
            };
            nombre = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            estado = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            modo = "1";
            btn_pagar.Enabled = true;


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            estado = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            modo = "2";
            btn_pagar.Enabled = true;
            Calendario_citas.BoldedDates = new DateTime[]
            {
                DateTime.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()),
                
            };
           
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            if (modo.ToString() == null)
            {
                MessageBox.Show("Selecione una Cita");

            }else
            if(modo.ToString() == "1")
            {
                Envio info;
                info.nombre2 = nombre;
                info.estado2 = estado;
                info.modo2 = modo;

                Pago_cita_nino.pago_ninocs entrada = new Pago_cita_nino.pago_ninocs(info);
                entrada.ShowDialog();
                    

            }
            else if (modo.ToString() == "2")
            {

            }
        }
    }
}
