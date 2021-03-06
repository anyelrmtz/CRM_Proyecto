﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data.Sql;
using CRM_Principal.Agenda;
using CRM_Principal.configuracion_user;
using CRM_Principal.configuracion_user.servicios;

namespace CRM_Principal
{
    public partial class Inicio_Principal : Form
    {
        //llamamos las nuevas variables para optener los datos enviados
        public string id_us;
        public string usuario;
        public string nombre_user;
        public string tipo_user;
        public string salida_user;
        //se estancia para obtener los datos mandados
        public Inicio_Principal(login.Datos info)
        {
            InitializeComponent();
            //optiene la hora y fecha del sistema
            DateTime ahora = DateTime.Now;
            salida_user = ahora.ToString("dd-MM-yyyy hh:mm:ss:tt");
            //se guarda la variable del id del usuario
            id_us = info.id_user;
            //se guarda la variable del ususario
            usuario = info.usuario;
            //se guarda la variable del nombre del usuario
            nombre_user = info.usuario;
            //se guarda la variable de tipo del ususario
            tipo_user = info.tipo_usuario;
            //se llama una clase para indetificar si es Administrador o Asistente
            Estatus_user();
           
        }
        //clase que compara si es un Administrador o un Asistente
        public void Estatus_user()
        {
            if(tipo_user == "Administrador")
            {
                menuStrip1.Enabled = true;
            }else if(tipo_user == "Asistente")
            {
                agregarUsuarioToolStripMenuItem1.Enabled= false;
                doctoresToolStripMenuItem.Enabled = false;
             serviciosToolStripMenuItem.Enabled = false;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tallerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //clase para optener la hora y fecha actual del sistema
        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora_envivo.Text = DateTime.Now.ToString();
        }
        
        private void Inicio_Principal_Load(object sender, EventArgs e)
        {
            Citas_nollegadas();
           
        }
        //funcion para borra las citas que no llegaron el dia anterior niño
        public void Citas_nollegadas()
        {
            DateTime fecha = DateTime.Now;
            fecha = fecha.AddDays(-1);
            
            string a = Convert.ToString(fecha.ToShortDateString());
            SqlConnection conectar = new SqlConnection("Data Source = 192.168.100.65; Initial Catalog = junodoctor_cliente; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
            conectar.Open();
            // MySqlCommand actualisar = new MySqlCommand();
            SqlCommand actualisar = new SqlCommand();
            //MySqlConnection conectanos = new MySqlConnection();
            SqlConnection conectanos = new SqlConnection();
            actualisar.Connection = conectar;
            actualisar.CommandText = ("DELETE FROM consul_nino where fehca_cita='"+a+"' and pago='NO'");
            // MySqlDataReader leer = actualisar.ExecuteReader();
            SqlDataReader leer = actualisar.ExecuteReader();
            conectar.Close();
            citas_adulto_nollegada();
        }
        //funcion para borra las citas que no llegaron el dia anterior Adulto
        public void citas_adulto_nollegada()
        {
            DateTime fecha = DateTime.Now;
            fecha = fecha.AddDays(-1);

            string a = Convert.ToString(fecha.ToShortDateString());
            SqlConnection conectar = new SqlConnection("Data Source = 192.168.100.65; Initial Catalog = junodoctor_cliente; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
            conectar.Open();
            // MySqlCommand actualisar = new MySqlCommand();
            SqlCommand actualisar = new SqlCommand();
            //MySqlConnection conectanos = new MySqlConnection();
            SqlConnection conectanos = new SqlConnection();
            actualisar.Connection = conectar;
            actualisar.CommandText = ("DELETE FROM consul_adulto where fehca_cita='" + a + "' and pago='NO'");
            // MySqlDataReader leer = actualisar.ExecuteReader();
            SqlDataReader leer = actualisar.ExecuteReader();
            conectar.Close();
            Clientes_sin_estatus_pasado();
        }

        //funcion para eliminar los ususarios que llegan desde la pagina web mas tardar 2 dias despues
        public void Clientes_sin_estatus_pasado()
        {
            DateTime fecha = DateTime.Now;
            fecha = fecha.AddDays(-2);
            string a = Convert.ToString(fecha.ToShortDateString());
         
          
            SqlConnection conectar = new SqlConnection("Data Source = 192.168.100.65; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
            conectar.Open();
            // MySqlCommand actualisar = new MySqlCommand();
            SqlCommand actualisar = new SqlCommand();
            //MySqlConnection conectanos = new MySqlConnection();
            SqlConnection conectanos = new SqlConnection();
            actualisar.Connection = conectar;
            actualisar.CommandText = ("DELETE FROM clientes_sin_status where fehca='" + a + "'");
            // MySqlDataReader leer = actualisar.ExecuteReader();
            SqlDataReader leer = actualisar.ExecuteReader();
            conectar.Close();
        }



        private void Inicio_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //accion para el botton de Cerrar no aga ninguna funcion
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void cerrarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        { //se llama un mensaje de avertencia si de sea cerrar sesion 
            DialogResult resultado = MessageBox.Show("En verdad quiere cerrar Sesión? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //si dise que si ase la funcion de actualisar la tabla de entrada_user y cecierra la ventana actual
            if (resultado == DialogResult.Yes)
            {
                //MySqlConnection conectar = new MySqlConnection("server = 10.23.249.209; Uid = doctorjuno; pwd = 12345; database = crm; ");
                SqlConnection conectar = new SqlConnection("Data Source = 192.168.100.65; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
                conectar.Open();
                // MySqlCommand actualisar = new MySqlCommand();
                SqlCommand actualisar = new SqlCommand();
                //MySqlConnection conectanos = new MySqlConnection();
                SqlConnection conectanos = new SqlConnection();
                actualisar.Connection = conectar;
                actualisar.CommandText = ("UPDATE entrada_user SET salida='"+salida_user+ "', on_of=0 WHERE usuario='" + nombre_user+ "' AND on_of='" + id_us+"';");
                // MySqlDataReader leer = actualisar.ExecuteReader();
                SqlDataReader leer = actualisar.ExecuteReader();
                conectar.Close();
                login inicio = new login();
                this.Hide();
                inicio.ShowDialog();
                this.Close();

            }
        }
        //llamar un from hijo para que el actual(padre) este visisble y se adapte el hijo ala ventana del padre
        private void Abrirfromconfig_user(object fromconfig_user)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            confi_usuarios con = fromconfig_user as confi_usuarios;
            con.TopLevel = false;
            con.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(con);
            this.panel_contenedor.Tag = con;
            con.Show();
        }

        private void agregarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {//llamamos el from hijo para que se visualice al tamaño del from padre
            Abrirfromconfig_user(new confi_usuarios());
        }
        private void AbrirfromU_Leads(object fromU_Leads)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            U_Leads con = fromU_Leads as U_Leads;
            con.TopLevel = false;
            con.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(con);
            this.panel_contenedor.Tag = con;
            con.Show();
        }

        private void leadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirfromU_Leads(new U_Leads());
        }
        private void AbrirfromU_Prospectos(object fromU_Prospectos)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            U_Prospecto con = fromU_Prospectos as U_Prospecto;
            con.TopLevel = false;
            con.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(con);
            this.panel_contenedor.Tag = con;
            con.Show();
        }

        private void prospectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirfromU_Prospectos(new U_Prospecto());
        }
        private void AbrirfromU_General(object fromU_General)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Principal con = fromU_General as Principal;
            con.TopLevel = false;
            con.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(con);
            this.panel_contenedor.Tag = con;
            con.Show();
        }

        private void generalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirfromU_General(new Principal());
        }
        private void AbrirfromCotizacion(object fromCotizacion)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Cotizacion con = fromCotizacion as Cotizacion;
            con.TopLevel = false;
            con.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(con);
            this.panel_contenedor.Tag = con;
            con.Show();
        }

        private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirfromCotizacion(new Cotizacion());
        }

        private void AbrirfromA_Clientes(object fromA_Clientes)
        {
            
        }

        private void Abrirformulario_cit_adulto(object fromA_adultos)
        {

            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            AC_Adultos con = fromA_adultos  as AC_Adultos;
            con.TopLevel = false;
            con.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(con);
            this.panel_contenedor.Tag = con;
            con.Show();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void adultosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirformulario_cit_adulto(new AC_Adultos());
        }

        private void Abrirfrom_consult_niño(object from_niño_con)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            AC_Niños con = from_niño_con as AC_Niños;
            con.TopLevel = false;
            con.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(con);
            this.panel_contenedor.Tag = con;
            con.Show();
        }

        private void niñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrirfrom_consult_niño(new AC_Niños());
        }

        private void verCitasAgendadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frorom_citas(new Ver_citas());
        }
        public void Frorom_citas(object citas_agendada)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Ver_citas con = citas_agendada as Ver_citas;
            con.TopLevel = false;
            con.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(con);
            this.panel_contenedor.Tag = con;
            con.Show();
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frorom_Doctor(new Doctores());
        }
        public void Frorom_Doctor(object doctores)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Doctores con = doctores as Doctores;
            con.TopLevel = false;
            con.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(con);
            this.panel_contenedor.Tag = con;
            con.Show();
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidad espe = new Especialidad();
            espe.ShowDialog();
        }

        private void vacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vacunas_new espe = new Vacunas_new();
            espe.ShowDialog();
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Servicios espe = new Servicios();
            espe.ShowDialog();
        }

        private void graficasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frorom_grafica(new Administracion.Graficacion.Graficas_mostradas());
        }
        public void Frorom_grafica(object grafica)
        {
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            Administracion.Graficacion.Graficas_mostradas con = grafica as Administracion.Graficacion.Graficas_mostradas;
            con.TopLevel = false;
            con.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(con);
            this.panel_contenedor.Tag = con;
            con.Show();
        }
    }
}

