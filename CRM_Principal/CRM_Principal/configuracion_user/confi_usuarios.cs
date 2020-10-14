using System;
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


namespace CRM_Principal
{
    public partial class confi_usuarios : Form
    {  
        //bariable para guardar el nombre del ususario
        public String data;
        //bariable para guardar el nombre del ususario y mandarlo al otro from
        public struct Envio
        {
            public string user;

        }

        public confi_usuarios()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {//llama al from re Registrar ususario
            Registrar_Usuarios nuevo = new Registrar_Usuarios();
            nuevo.ShowDialog();
        }

        private void confi_usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'junodoctorDataSet1.entrada_user' Puede moverla o quitarla según sea necesario.
            this.entrada_userTableAdapter.Fill(this.junodoctorDataSet1.entrada_user);
            // TODO: esta línea de código carga datos en la tabla 'junodoctorDataSet.usuarios' Puede moverla o quitarla según sea necesario.
         
            // muestra la tabla de los usuarios
            Datos(this);
         




        }
        //conexion de base de datos
        //MySqlConnection conectar = new MySqlConnection("server=10.23.249.209;  Uid=doctorjuno; pwd=12345; database=crm;");
        SqlConnection conectar = new SqlConnection("Data Source = 10.23.249.209; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
        //llama la funcion para mostrar los datos
        public void Datos(Control control)
        {
            this.usuariosTableAdapter.Fill(this.junodoctorDataSet.usuarios);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btn_actualisar_Click(object sender, EventArgs e)
        {
           
            Datos(this);
        }
        //boton para actualisar un usuario
        private void btn_actualizar_Click(object sender, EventArgs e)
        {  if((data==null))
            {
                MessageBox.Show("Seleccione un Usuario porfavor");
            }
            else
            {
                Envio info;
                info.user = data;

                Actulizar_Datos_user con = new Actulizar_Datos_user(info);
                con.ShowDialog();

            }




        }

        private void dataGridView_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           data = dataGridView_user.CurrentRow.Cells[1].Value.ToString();
        }
        //boton para eliminar un usuario
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if ((data == null))
            {
                MessageBox.Show("Seleccione un Usuario porfavor");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("En verdad quiere Eliminar el Usuario? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    conectar.Open();
                    SqlCommand agregar_user = new SqlCommand();
                    agregar_user.Connection = conectar;
                    agregar_user.CommandText = ("DELETE FROM usuarios WHERE usuario='" + data + "';");
                    SqlDataReader leer3 = agregar_user.ExecuteReader();
                    if (leer3.Read())
                    {
                        MessageBox.Show("Error en guardar");
                        conectar.Close();
                    }
                    else
                    {
                        conectar.Close();
                        MessageBox.Show("Usuario Eliminado ");
                        Datos(this);

                        
                    }
                }

            }
           
        }

        private void btn_elimi_historial_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("En verdad quieres Eliminar todo el historial? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                conectar.Open();
                SqlCommand agregar_user = new SqlCommand();
                agregar_user.Connection = conectar;
                agregar_user.CommandText = ("TRUNCATE TABLE entrada_user");
                SqlDataReader leer3 = agregar_user.ExecuteReader();
                MessageBox.Show("Se Elimino todo los datos correctamente");
                this.entrada_userTableAdapter.Fill(this.junodoctorDataSet1.entrada_user);
                conectar.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }




}