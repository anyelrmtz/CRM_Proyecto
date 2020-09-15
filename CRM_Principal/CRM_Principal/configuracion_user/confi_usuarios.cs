﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CRM_Principal
{
    public partial class confi_usuarios : Form
    {
        public confi_usuarios()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Registrar_Usuarios nuevo = new Registrar_Usuarios();
            nuevo.ShowDialog();
        }

        private void confi_usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'crmDataSet.entrada_user' Puede moverla o quitarla según sea necesario.
            this.entrada_userTableAdapter.Fill(this.crmDataSet.entrada_user);
            // TODO: esta línea de código carga datos en la tabla 'crmDataSet.entrada_user' Puede moverla o quitarla según sea necesario.

            dataGridView_user.DataSource = mostrardatos_user();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataTable mostrardatos_user()
        {
            MySqlConnection conectar = new MySqlConnection("server=10.23.249.209;  Uid=doctorjuno; pwd=12345; database=crm;");
            conectar.Open();

            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("select user,nombre,tipo_user from usuarios ");
            MySqlDataAdapter leer = new MySqlDataAdapter(codigo.CommandText, conectar);
            DataTable mostrardatos = new DataTable();
            leer.Fill(mostrardatos);
            return mostrardatos;

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }



    }




}