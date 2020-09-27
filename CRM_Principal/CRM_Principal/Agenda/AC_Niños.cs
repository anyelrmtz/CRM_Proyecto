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
    public partial class AC_Niños : Form
    {
        public AC_Niños()
        {
            InitializeComponent();
            
        }
        //conexion
        SqlConnection conectar = new SqlConnection("Data Source = 10.23.249.209; Initial Catalog = junodoctor_cliente ; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
       
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //tutor
        String En_tuto;
        String Medi_tuto;
        //niño
        String enfer_nino;
        String medi_nino;
        String hermano;

        private void btn_Guar_Click(object sender, EventArgs e)
        {
            conectar.Open();
            SqlCommand cliente  = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            cliente.Connection = conectar;
           // cliente.CommandText = ("select clave from usuario where Nombre='"++"' ");

            SqlDataReader cliente_user = cliente.ExecuteReader();
            while (cliente_user.Read())
            {
                
            }

            conectar.Close();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        
        }

       
        

        private void radioButton7_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                En_tuto = "No";
                info_enfer_tutor.Enabled = false;
            }
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                En_tuto = "Si";
                info_enfer_tutor.Enabled = true;
            }
        }

        private void radioButton7_Click_1(object sender, EventArgs e)
        {
           
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                Medi_tuto = "Si";
                info_medicacion_tuto.Enabled = true;
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                enfer_nino = "Si";
                textBox7.Enabled = true;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                enfer_nino = "No";
                textBox7.Enabled = false;
            }
        }

        private void radioButton11_Click(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                medi_nino = "No";
                textBox1.Enabled = false;

            }
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {

            if (radioButton4.Checked == true)
            {
                hermano = "Si";
                textBox2.Enabled = true;

            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                hermano = "No";
                textBox2.Enabled = false;

            }

        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                Medi_tuto = "No";
                info_medicacion_tuto.Enabled = false;
            }
        }

        private void radioButton12_Click(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                medi_nino = "Si";
                textBox1.Enabled = true;
            }
        }
    }
}
