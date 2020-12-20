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
        SqlConnection conectar2 = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor ; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");

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
        //busca las especialidades disponibles
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
        SqlConnection conectar = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor_cliente ; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");

        //Boton de guardado
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
                DialogResult resultado = MessageBox.Show("El cliente " + txt_nombre.Text + " no aparece en el sistema \n ¿ Desea agregarlo al Sistema? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            conectar.Close();
            conectar.Open();
            SqlCommand cliente_pasiente2 = new SqlCommand();
            SqlConnection conectanos2 = new SqlConnection();
            cliente_pasiente2.Connection = conectar;
            cliente_pasiente2.CommandText = ("Select *from " + clavesit + " where nombre_paciente='"+txt_nombre.Text+"'");
            SqlDataReader cliente_user2 = cliente_pasiente2.ExecuteReader();
            if (cliente_user2.Read())
            {
                conectar.Close();
                Historial();
            }
            else
            {
                conectar.Close();
                conectar.Open();
                SqlCommand cliente_pasiente = new SqlCommand();
                SqlConnection conectanos = new SqlConnection();
                cliente_pasiente.Connection = conectar;
                cliente_pasiente.CommandText = ("INSERT INTO " + clavesit + "(nombre_paciente,fehca_nac,edad,estatus)Values('" + txt_nombre.Text + "','" + fehca_naci.Text + "','" + txt_edad.Text + "','2')");
                SqlDataReader cliente_user = cliente_pasiente.ExecuteReader();
                if (cliente_user.Read())
                {
                    MessageBox.Show("Error guardar user en admin");
                    conectar.Close();
                }
                else
                {
                    conectar.Close();
                    Historial();
                }
            }
        }

        public void Historial()
        {
            ///guardar historial
            
            conectar.Open();
            SqlCommand cliente_pasi_historial = new SqlCommand();
            cliente_pasi_historial.Connection = conectar;
            cliente_pasi_historial.CommandText = ("INSERT INTO consul_adulto(fhec_hora,tipo_consulta,doctora,fehca_cita,hora_cita,genero,nombre,fecha_nac,edad,tipo_sangre,telefono,correo,enfermedad,enfermedad_info,medicacion,info_medicacion,pago,cantidad,clave)VALUES('" + Hora_fecha + "','" + cobo_tipc.Text + "','" + combo_doc.Text + "','" + combo_fehc_cit.Text + "','" + hora_text.Text + "'" +
                ",'" + combo_genero.Text + "','" + txt_nombre.Text + "','" + fehca_naci.Text + "'," +
                "'" + txt_edad.Text + "','" + combo_sangre.Text + "','" + text_telefono.Text + "'," +
                "'" + txt_correo.Text + "','" + En_tuto + "','" + textBox5.Text + "','" + Medi_tuto + "'," +
                "'" + textBox1.Text + "','NO','','" + clavesit + "');");
            SqlDataReader cliente_nino = cliente_pasi_historial.ExecuteReader();
            if (cliente_nino.Read())
            {
                MessageBox.Show("ERROR EN AGREGAR HISTORIAL");
                conectar.Close();
            }
            else
            {
                
                conectar.Close();
                Correo();
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
        //funciona de calcular la edad del paciente automaticamente
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

        //enviar correo electronico
        public void Correo()
        {

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(txt_correo.Text);
            msg.Subject = "JUNO DOCTOR: Paciente: " + txt_nombre.Text + " ";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = "Bienvenido a Juno Doctors estos son los datos de su siguiente consulta  <br>" +
                "Dr.(a):" + combo_doc.Text + "<br>"
            + "Tipo de consulta: " + cobo_tipc.Text + "<br>"
             + "Fecha de la consulta:" + combo_fehc_cit.Text + "<br>"
             + "Hora de la consulta:" + hora_text.Text + "<br>"
            + "IMPORTANTE: Recuerde llegar 30 minutos antes de la hora de su consulta <br>"
             + "----------------------------------------------------------------------------- <br>"
            + "Recuerde que puede revisar sus Consultas con la aplicación de Juno Doctors, sí aun no cuenta con la aplicación Descárguela aquí." + "<br> "
            + "<div><p>Descarga la App Juno Doctors: <a href='http://177.228.214.8/junodoctor/Descarga.php'>Descargar</a></p> </div>" + "";
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("manuelangelrmtz19@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("manuelangelrmtz19@gmail.com", "anyel2602@2");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(msg);
                Limpiar();
                MessageBox.Show("La cita fue agendada");
            }
            catch
            {
                MessageBox.Show("error de correo");
            }
        }

        private void combo_fehc_cit_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
