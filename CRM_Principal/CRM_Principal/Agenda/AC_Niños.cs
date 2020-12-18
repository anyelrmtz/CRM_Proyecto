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
            Especialidadse();
        }
        
        //conexion
        SqlConnection conectar = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor_cliente ; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
        //conexion
        SqlConnection conectar2 = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor ; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");

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
            
               
                conectar2.Open();

                SqlCommand serv = new SqlCommand();
                SqlConnection conectanos = new SqlConnection();
                serv.Connection = conectar2;
                serv.CommandText = ("Select *from Especialidad");

                SqlDataReader leer = serv.ExecuteReader();
                while (leer.Read())
                {
                    tipo_consulta.Items.Add(leer["nombre"].ToString());
                }

                conectar2.Close();
            


        }

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
                //Guardar
                // Guardar_consulta();
                Busqueda_paciente();
            }
            else{
                DialogResult resultado = MessageBox.Show("El cliente "+text_nom_tutor.Text+" no aparece en el sistema \n ¿ Desea agregarlo al Sistema? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //si dise que si ase la funcion de actualisar la tabla de entrada_user y cecierra la ventana actual
                if (resultado == DialogResult.Yes)
                {
                    Datos info;
                    info.nom = text_nom_tutor.Text;
                    info.tel = telefono.Text;
                    info.correo = textcorreo.Text;
                    conectar.Close();
                    Clientes_new ver = new Clientes_new(info);
                    ver.ShowDialog();

                }
                else
                {
                    conectar.Close();
                }
            }


        }
        public void Busqueda_paciente()
        {
            conectar.Open();
            SqlCommand paciente = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            paciente.Connection = conectar;
            paciente.CommandText = ("Select *from " + clavesit + " where nombre_paciente='" + nombre_nino.Text + "'");
            SqlDataReader cliente_user = paciente.ExecuteReader();
            if (cliente_user.Read())
            {
                conectar.Close();
                History();
            }
            else
            {
                conectar.Close();
                Guardar_consulta();
            }
        }
        public void History()
        {
            conectar.Close();
            conectar.Open();
            SqlCommand cliente_pasi_historial = new SqlCommand();
            cliente_pasi_historial.Connection = conectar;
            cliente_pasi_historial.CommandText = ("INSERT INTO consul_nino(fhec_hora,tipo_consulta,doctora,fehca_cita,hora_cita,tutor,nombre_tt,fehca_na,tipo_san,telefono,correo,enfermedas,infi_enfer,medicacion,infi_medic,nombre_nino,fecha_nino,tipo_sangre,edad,enfer_nino,info_enfer_nino,medicacion_nino,info_medicacion_nino" +
                ",hermano,info_hermano,pago,cantidad,clave)VALUES('" + Hora_fecha + "','" + tipo_consulta.Text + "','" + doctora_combo.Text + "','" + fehca_sita.Text + "','" + hora_text.Text + "'" +
                ",'" + combo_acompaña.Text + "','" + text_nom_tutor.Text + "','" + fecha_tutor_na.Text + "'," +
                "'" + tipo_sangre_tu.Text + "','" + telefono.Text + "','" + textcorreo.Text + "'," +
                "'" + En_tuto + "','" + info_enfer_tutor.Text + "','" + Medi_tuto + "','" + info_medicacion_tuto.Text + "'," +
                "'" + nombre_nino.Text + "','" + fecha_na_nino.Text + "','" + tipo_sangre_nino.Text + "'," +
                "'" + edad_nino.Text + "','" + enfer_nino + "','" + textBox7.Text + "','" + medi_nino + "','" + textBox1.Text + "','" + hermano + "','" + textBox2.Text + "','NO','','" + clavesit + "');");
            SqlDataReader cliente_nino = cliente_pasi_historial.ExecuteReader();
            if (cliente_nino.Read())
            {
                MessageBox.Show("ERROR EN AGREGAR HISTORIAL");
                conectar.Close();
            }
            else
            {
                Correo();
                //MessageBox.Show("La cita fue agendada");
                conectar.Close();
                //Limpiar();

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
                MessageBox.Show("Error guardar user en admin");
                conectar.Close();
            }
            else
            {///guardar historial
                conectar.Close();
                conectar.Open();
                SqlCommand cliente_pasi_historial = new SqlCommand();
                cliente_pasi_historial.Connection = conectar;
                cliente_pasi_historial.CommandText = ("INSERT INTO consul_nino(fhec_hora,tipo_consulta,doctora,fehca_cita,hora_cita,tutor,nombre_tt,fehca_na,tipo_san,telefono,correo,enfermedas,infi_enfer,medicacion,infi_medic,nombre_nino,fecha_nino,tipo_sangre,edad,enfer_nino,info_enfer_nino,medicacion_nino,info_medicacion_nino" +
                    ",hermano,info_hermano,pago,cantidad,clave)VALUES('" + Hora_fecha+"','"+tipo_consulta.Text+"','"+doctora_combo.Text+"','"+fehca_sita.Text+"','"+hora_text.Text+"'" +
                    ",'"+combo_acompaña.Text+"','"+text_nom_tutor.Text+"','"+fecha_tutor_na.Text+"'," +
                    "'"+tipo_sangre_tu.Text+"','"+telefono.Text+"','"+textcorreo.Text+"'," +
                    "'"+En_tuto+"','"+info_enfer_tutor.Text+"','"+Medi_tuto+"','"+info_medicacion_tuto.Text+"'," +
                    "'"+nombre_nino.Text+"','"+fecha_na_nino.Text+"','"+tipo_sangre_nino.Text+"'," +
                    "'"+edad_nino.Text+"','"+enfer_nino+"','"+textBox7.Text+"','"+medi_nino+"','"+textBox1.Text+"','"+hermano+"','"+textBox2.Text+"','NO','','"+clavesit+"');");
                SqlDataReader cliente_nino = cliente_pasi_historial.ExecuteReader();
                if (cliente_nino.Read())
                {
                    MessageBox.Show("ERROR EN AGREGAR HISTORIAL");
                    conectar.Close();
                }
                else
                {
                    Correo();
                    //MessageBox.Show("La cita fue agendada");
                    conectar.Close();
                    //Limpiar();
                    
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

        public void Limpiar()
        {
            
            
            

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
            }
            /////////////////////grupo bos 2
            foreach (Control c in this.groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                    this.textBox1.Focus();
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
            foreach (Control ctrl in this.groupBox3.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton text = ctrl as RadioButton;
                    text.Checked = false;
                }
            }
            /////////////////////grupo bos 4
            foreach (Control c in this.groupBox4.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = false;

                    this.textBox1.Focus();
                }
            }
            foreach (Control ctrl in this.groupBox4.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton text = ctrl as RadioButton;
                    text.Checked = false;
                }
            }
            
            /////////////////////grupo bos 5
            foreach (Control c in this.groupBox5.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = false;

                    this.textBox1.Focus();
                }
            }
            foreach (Control ctrl in this.groupBox5.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton text = ctrl as RadioButton;
                    text.Checked = false;
                }
            }
            /////////////////////grupo bos 6
            foreach (Control c in this.groupBox6.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = false;

                    this.textBox1.Focus();
                }
            }
            foreach (Control ctrl in this.groupBox6.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton text = ctrl as RadioButton;
                    text.Checked = false;
                }
            }
            /////////////////////grupo bos 7
            foreach (Control c in this.groupBox7.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = false;

                    this.textBox1.Focus();
                }
            }
            foreach (Control ctrl in this.groupBox7.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton text = ctrl as RadioButton;
                    text.Checked = false;
                }
            }
        }

        private void fecha_tutor_na_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fecha_na_nino_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaacutal = DateTime.Today;
            int anos = fechaacutal.Year - fecha_na_nino.Value.Year;
            if (fechaacutal < fecha_na_nino.Value.AddYears(anos)) anos--;
            int meses = fechaacutal.Month - fecha_na_nino.Value.Month;
            if (fechaacutal < fecha_na_nino.Value.AddMonths(meses)) meses--;

            if (anos > 1)
            {
                edad_nino.Text = anos + " Años";
            }
            else
            {
                edad_nino.Text = meses + " Meses";
            }
        }

        private void tipo_consulta_SelectedIndexChanged(object sender, EventArgs e)
        {

            
                doctora_combo.Items.Clear();
                conectar2.Open();

                SqlCommand serva = new SqlCommand();
                SqlConnection conectanos = new SqlConnection();
            serva.Connection = conectar2;
            serva.CommandText = ("select *from "+tipo_consulta.Text+";");

                SqlDataReader leer = serva.ExecuteReader();
                while (leer.Read())
                {
                    doctora_combo.Items.Add(leer["nombre"].ToString());
                }

                conectar2.Close();
            
            
        }
        public void Correo()
        {
           
             System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
             msg.To.Add(textcorreo.Text);
             msg.Subject = "JUNO DOCTOR: Paciente: " + nombre_nino.Text + " ";
             msg.SubjectEncoding = System.Text.Encoding.UTF8;
             msg.Body = "Bienvenido a Juno Doctors estos son los datos de su siguiente consulta  <br>"+
                 "Dr.(a):" + doctora_combo.Text +"<br>"
             +"Tipo de consulta: "+tipo_consulta.Text+ "<br>"
              + "Fecha de la consulta:" + fehca_sita.Text + "<br>"
              + "Hora de la consulta:" + hora_text.Text + "<br>"
             + "IMPORTANTE: Recuerde llegar 30 minutos antes de la hora de su consulta <br>"
             + "----------------------------------------------------------------------------- <br>"
             + "Recuerde que puede revisar sus Consultas con la aplicación de Juno Doctors, sí aun no cuenta con la aplicación Descárguela aquí." + "<br> "
             + "<div><p>Descarga la App Juno Doctors: <a href='http://177.228.214.8/junodoctor/Descarga.php'>Descargar</a></p> </div>" + "" ;
             msg.BodyEncoding = System.Text.Encoding.UTF8;
             msg.IsBodyHtml = true;
             msg.From = new System.Net.Mail.MailAddress("manuelangelrmtz19@gmail.com");
            //upss
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
                 MessageBox.Show(textcorreo.Text);
             }
        }
    }
} 


