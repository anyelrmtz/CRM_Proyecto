﻿using System;
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
namespace CRM_Principal.Agenda.Pago_cita_nino
{
    public partial class pago_ninocs : Form
    {
        string nombre;
        string estatus;
        string modo;
        string tipo_especia;
        public String Hora_fecha;

        public pago_ninocs(Ver_citas.Envio info)
        {
            InitializeComponent();
            nombre = info.nombre2;
            estatus = info.estado2;
            modo = info.modo2;
            Busqueda();
            DateTime ahora = DateTime.Now;
            Hora_fecha = ahora.ToString("dd-MM-yyyy hh:mm:ss:tt");



        }

        //busqueda de citas 
        public void Busqueda()
        {
            SqlConnection conectar = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor_cliente; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
            conectar.Open();

            SqlCommand buscar = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            buscar.Connection = conectar;
            buscar.CommandText = ("select *from consul_nino WHERE nombre_nino='" + nombre + "' AND pago='" + estatus + "';");

            SqlDataReader leer = buscar.ExecuteReader();

            while (leer.Read())
            { 
                txt_nombre.Text = leer["nombre_nino"].ToString();
                txt_doctora.Text = leer["doctora"].ToString();
                txt_cita.Text = leer["tipo_consulta"].ToString();


            }
            conectar.Close();
        }
        //actualisacion de status del paciente
        public void Update_junio_cliente()
        {
            SqlConnection conectar = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor_cliente; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
            conectar.Open();
            SqlCommand actualisar = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            actualisar.Connection = conectar;
            actualisar.CommandText = ("UPDATE consul_nino SET pago='SI',cantidad='"+txt_costo.Text+"' WHERE nombre_nino='" +txt_nombre.Text+"' AND pago='NO';");
            SqlDataReader leer = actualisar.ExecuteReader();
            if (leer.Read())
            {
                conectar.Close();
            }
            else
            {
                conectar.Close();
                Doctor_ingreso();
            }
        }

        //funcion ingresa a cotizacion la cita
        public void Doctor_ingreso()
        {
            SqlConnection conectar = new SqlConnection("Data Source = 177.228.214.8; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
            conectar.Open();
            SqlCommand agregar_cotizacion = new SqlCommand();
            agregar_cotizacion.Connection = conectar;
            agregar_cotizacion.CommandText = ("insert into Cotizacion(fech_hora,cotizar,tipo_cot,servi,Descrip,cost) values('" + Hora_fecha + "','Ingresos','Consulta','" + txt_cita.Text+ "','Cita para "+txt_nombre.Text+" con "+txt_doctora.Text+"','" + txt_costo.Text+ "');");
            SqlDataReader cotizacion = agregar_cotizacion.ExecuteReader();
            if (cotizacion.Read())
            {
                MessageBox.Show("eror");
                conectar.Close();
            }
            else
            {
                MessageBox.Show("Lacita fue Pagada");
                conectar.Close();
                
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_junio_cliente();
        }
    }
}
