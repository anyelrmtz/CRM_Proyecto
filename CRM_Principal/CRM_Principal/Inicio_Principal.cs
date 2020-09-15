using System;
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
    public partial class Inicio_Principal : Form
    {
        public string id_us;
        public string usuario;
        public string nombre_user;
        public string tipo_user;
        public string salida_user;
        public Inicio_Principal(login.Datos info)
        {
            InitializeComponent();
            
            DateTime ahora = DateTime.Now;
            salida_user = ahora.ToString("dd-MM-yyyy hh:mm:ss:tt");
            id_us = info.id_user;
            usuario = info.usuario;
            nombre_user = info.usuario;
            tipo_user = info.tipo_usuario;
            Estatus_user();
        }

        public void Estatus_user()
        {
            if(tipo_user == "Administrador")
            {
                menuStrip1.Enabled = true;
            }else if(tipo_user == "Asistente")
            {
                agregarUsuarioToolStripMenuItem1.Enabled= false;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tallerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora_envivo.Text = DateTime.Now.ToString();
        }

        private void Inicio_Principal_Load(object sender, EventArgs e)
        {

        }

        private void Inicio_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void cerrarSecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("en verdad quiere cerar Sesión? ", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                MySqlConnection conectar = new MySqlConnection("server = 10.23.249.209; Uid = doctorjuno; pwd = 12345; database = crm; ");
                conectar.Open();
                MySqlCommand actualisar = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                actualisar.Connection = conectar;
                actualisar.CommandText = ("UPDATE entrada_user SET salida= '"+salida_user+ "', on_of=0 WHERE user='" + nombre_user+ "' AND on_of='" + id_us+"';");
                MySqlDataReader leer = actualisar.ExecuteReader();
                conectar.Close();
                login inicio = new login();
                this.Hide();
                inicio.ShowDialog();
                this.Close();

            }
        }
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
        {
            Abrirfromconfig_user(new confi_usuarios());
        }
    }
}
