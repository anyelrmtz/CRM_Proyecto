using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_Principal.Clientes;

namespace CRM_Principal
{
    public partial class AC_Adultos : Form
    {
        public String Hora_fecha;
        public AC_Adultos()
        {
            InitializeComponent();
            DateTime ahora = DateTime.Now;
            Hora_fecha = ahora.ToString("dd-MM-yyyy hh:mm:ss:tt");
            Especialidadse();
        }
        //conexion
        SqlConnection conectar2 = new SqlConnection("Data Source = 10.23.249.209; Initial Catalog = junodoctor ; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");

        //pasiente
        String En_tuto;
        String Medi_tuto;
        //clave Paciente
        String clavesit;
        public struct Datos
        { //variable para nombre
            public string nom;
            //variable para telefono
            public string tel;
            //variable para correo
            public string correo;


        }
        public void Especialidadse()
        {

            cobo_tipc.Items.Clear();
            conectar2.Open();

            SqlCommand serv = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            serv.Connection = conectar2;
            serv.CommandText = ("Select *from Especialidad");

            SqlDataReader leer = serv.ExecuteReader();
            while (leer.Read())
            {
                cobo_tipc.Items.Add(leer["nombre"].ToString());
            }

            conectar2.Close();



        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                En_tuto = "SI";
                textBox5.Enabled = true;
            }

        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                En_tuto = "No";
                textBox5.Enabled = false;
            }
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                Medi_tuto = "Si";
                textBox1.Enabled = true;
            }
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                Medi_tuto = "No";
                textBox1.Enabled = false;
            }
        }
        //conexion
        SqlConnection conectar = new SqlConnection("Data Source = 10.23.249.209; Initial Catalog = junodoctor_cliente ; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
        private void btn_guardar_Click(object sender, EventArgs e)
        {
                conectar.Open();
            SqlCommand cliente = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            cliente.Connection = conectar;
            cliente.CommandText = ("select *from usuario where Nombre='" + txt_nombre.Text + "' ");
            SqlDataReader cliente_user = cliente.ExecuteReader();
            if (cliente_user.Read())
            {
                clavesit = cliente_user["clave"].ToString();
                conectar.Close();
                Guardar_consulta();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("El cliente " + txt_nombre.Text + " no aparece en el sistema \n ¿ Desea agregarla al Sistema? ", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //si dise que si ase la funcion de actualisar la tabla de entrada_user y cecierra la ventana actual
                if (resultado == DialogResult.Yes)
                {
                    conectar.Close();
                    Datos info2;
                    info2.nom = txt_nombre.Text;
                    info2.tel = text_telefono.Text;
                    info2.correo = txt_correo.Text;
                  
                    Clientes_new ver = new Clientes_new(info2);
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
            cliente_pasiente.CommandText = ("INSERT INTO " + clavesit + "(nombre_paciente,fehca_nac,edad,estatus)Values('" + txt_nombre.Text + "','" + fehca_naci.Text + "','" + txt_edad.Text+ "','2')");
            SqlDataReader cliente_user = cliente_pasiente.ExecuteReader();
            if (cliente_user.Read())
            {
                MessageBox.Show("Error guardar user en admin");
                conectar.Close();
            }
            else
            {///guardar historial
                conectar.Close();
                conectar.Open();
                SqlCommand cliente_pasi_historial = new SqlCommand();
                cliente_pasi_historial.Connection = conectar;
                cliente_pasi_historial.CommandText = ("INSERT INTO consul_adulto(fhec_hora,tipo_consulta,doctora,fehca_cita,hora_cita,genero,nombre,fecha_nac,edad,tipo_sangre,telefono,correo,enfermedad,enfermedad_info,medicacion,info_medicacion,pago,cantidad,clave)VALUES('" + Hora_fecha + "','" + cobo_tipc.Text + "','" + combo_doc.Text + "','" + combo_fehc_cit.Text + "','" + hora_text.Text + "'" +
                    ",'" + combo_genero.Text + "','" + txt_nombre.Text + "','" + fehca_naci.Text + "'," +
                    "'" + txt_edad.Text + "','" + combo_sangre.Text + "','" + text_telefono.Text + "'," +
                    "'" + txt_correo.Text + "','" + En_tuto+ "','" + textBox5.Text + "','" + Medi_tuto + "'," +
                    "'" + textBox1.Text + "','NO','','" + clavesit + "');");
                SqlDataReader cliente_nino = cliente_pasi_historial.ExecuteReader();
                if (cliente_nino.Read())
                {
                    MessageBox.Show("ERROR EN AGREGAR HISTORIAL");
                    conectar.Close();
                }
                else
                {
                    MessageBox.Show("La cita fue agendada");
                    conectar.Close();
                    Limpiar();
                }
            }
        }

        public void Limpiar()

        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                    this.textBox1.Focus();
                }
            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.SelectedIndex = -1;
                }
            }
            /////////////////////grupo bos 1
            foreach (Control c in this.groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                    this.textBox1.Focus();
                }
            }
            foreach (Control ctrl in this.groupBox1.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.SelectedIndex = -1;
                }
            } /////////////////////grupo bos 2
            foreach (Control c in this.groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = false;

                    this.textBox1.Focus();
                }
            }
            foreach (Control ctrl in this.groupBox2.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton text = ctrl as RadioButton;
                    text.Checked = false;
                }
            }
            /////////////////////grupo bos 3
            foreach (Control c in this.groupBox3.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = false;

                    this.textBox1.Focus();
                }
            }
            foreach (Control ctrl in this.groupBox3
.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton text = ctrl as RadioButton;
                    text.Checked = false;
                }
            }
        }

        private void fehca_naci_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaacutal = DateTime.Today;
            int anos = fechaacutal.Year - fehca_naci.Value.Year;
            if (fechaacutal < fehca_naci.Value.AddYears(anos)) anos--;
            txt_edad.Text = anos + " Años";
            
        }

        private void combo_doc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cobo_tipc_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_doc.Items.Clear();
            conectar2.Open();

            SqlCommand serva = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            serva.Connection = conectar2;
            serva.CommandText = ("select *from " + cobo_tipc.Text + ";");

            SqlDataReader leer = serva.ExecuteReader();
            while (leer.Read())
            {
                combo_doc.Items.Add(leer["nombre"].ToString());
            }

            conectar2.Close();
        }
    }
}
