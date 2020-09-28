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

namespace CRM_Principal.Agenda
{
    public partial class AC_Niños : Form
    {
        public String Hora_fecha;
        public AC_Niños()
        {

            InitializeComponent();
            DateTime ahora = DateTime.Now;
            Hora_fecha = ahora.ToString("dd-MM-yyyy hh:mm:ss:tt");
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
        //clave tutor
        String clavesit;

        
        private void btn_Guar_Click(object sender, EventArgs e)
        {
            
            
            conectar.Open();
            SqlCommand cliente  = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            cliente.Connection = conectar;
           cliente.CommandText = ("select *from usuario where Nombre='"+text_nom_tutor.Text+"' ");
            SqlDataReader cliente_user = cliente.ExecuteReader();
            if (cliente_user.Read())
            {
                clavesit = cliente_user["clave"].ToString();
                conectar.Close();
                Guardar_consulta();
            }
            else{
                DialogResult resultado = MessageBox.Show("la Señora "+text_nom_tutor.Text+" no aparece en el sistema \n ¿ Desea agregarla al Sistema? ", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //si dise que si ase la funcion de actualisar la tabla de entrada_user y cecierra la ventana actual
                if (resultado == DialogResult.Yes)
                {
                    conectar.Close();
                    Clientes_new ver = new Clientes_new();
                    ver.ShowDialog();

                }
                else
                {
                    conectar.Close();
                }
            }


        }
        //guardado
        public void Guardar_consulta()
        {//guardar user en el admin
            conectar.Open();
            SqlCommand cliente_pasiente = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            cliente_pasiente.Connection = conectar;
            cliente_pasiente.CommandText = ("INSERT INTO "+clavesit+"(nombre_paciente,fehca_nac,edad,estatus)Values('"+nombre_nino.Text+"','"+fecha_na_nino.Text+"','"+edad_nino.Text+"','1')");
            SqlDataReader cliente_user = cliente_pasiente.ExecuteReader();
            if (cliente_user.Read())
            {
                MessageBox.Show("error guardar user en admin");
                conectar.Close();
            }
            else
            {///guardar historial
                conectar.Close();
                conectar.Open();
                SqlCommand cliente_pasi_historial = new SqlCommand();
                cliente_pasi_historial.Connection = conectar;
                cliente_pasi_historial.CommandText = ("INSERT INTO consul_nino(fhec_hora,tipo_consulta,doctora,fehca_cita,hora_cita,tutor,nombre_tt,fehca_na,tipo_san,telefono,correo,enfermedas,infi_enfer,medicacion,infi_medic,nombre_nino,fecha_nino,tipo_sangre,edad,enfer_nino,info_enfer_nino,medicacion_nino,info_medicacion_nino" +
                    ",hermano,info_hermano,clave)VALUES('" + Hora_fecha+"','"+tipo_consulta.Text+"','"+doctora_combo.Text+"','"+fehca_sita.Text+"','"+hora_text.Text+"'" +
                    ",'"+combo_acompaña.Text+"','"+text_nom_tutor.Text+"','"+fecha_tutor_na.Text+"'," +
                    "'"+tipo_sangre_tu.Text+"','"+telefono.Text+"','"+correo.Text+"'," +
                    "'"+En_tuto+"','"+info_enfer_tutor.Text+"','"+Medi_tuto+"','"+info_medicacion_tuto.Text+"'," +
                    "'"+nombre_nino.Text+"','"+fecha_na_nino.Text+"','"+tipo_sangre_nino.Text+"'," +
                    "'"+edad_nino.Text+"','"+enfer_nino+"','"+textBox7.Text+"','"+medi_nino+"','"+textBox1.Text+"','"+hermano+"','"+textBox2.Text+"','"+clavesit+"');");
                SqlDataReader cliente_nino = cliente_pasi_historial.ExecuteReader();
                if (cliente_nino.Read())
                {
                    MessageBox.Show("EROR EN AGREGAR HISTORIAL");
                    conectar.Close();
                }
                else
                {
                    MessageBox.Show("La cita fue agendada");
                    conectar.Close();
                }
            }
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
