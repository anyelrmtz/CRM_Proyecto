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
        public String tipo_user;
        public String nombre_user;
        public String salida_user;
        public Inicio_Principal()
        {
            InitializeComponent();
            
            DateTime ahora = DateTime.Now;
            salida_user = ahora.ToString("dd-MM-yyyy hh:mm:ss:tt");
            
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
                MySqlConnection conectar = new MySqlConnection("server=sql3.freemysqlhosting.net; database=sql3364286;Uid=sql3364286;pwd=j1AwNptgUn;");
                conectar.Open();
                MySqlCommand buscaruser = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                buscaruser.Connection = conectar;
                buscaruser.CommandText = ("update entrada_user set salida ='"+salida_user+"' where user='"+nombre_user+"' ");
                MySqlDataReader leer = buscaruser.ExecuteReader();
                login inicio = new login();
                this.Hide();
                inicio.ShowDialog();
                this.Close();

            }
        }
    }
}
