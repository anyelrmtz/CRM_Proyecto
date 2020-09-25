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
namespace CRM_Principal.Agenda
{
    public partial class Ver_citas : Form
    {
        public Ver_citas()
        {
            InitializeComponent();
          
        }
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void Calendario()
        {
            SqlConnection conectar = new SqlConnection("Data Source = 10.23.249.209; Initial Catalog = junodoctor; Persist Security Info = True; User ID = DOCTORJUNIO; Password = junodoctor2020");
            conectar.Open();

            SqlCommand calen = new SqlCommand();
            SqlConnection conectanos = new SqlConnection();
            calen.Connection = conectar;
            calen.CommandText = ("select *from Prueba ");

            SqlDataReader leer = calen.ExecuteReader();
            if(leer.Read())
            {
                

                Calendario_citas.BoldedDates =new DateTime[]
                {
                     DateTime.Parse(leer["fecha"].ToString()),
                     
                    DateTime.Today.AddDays(0),
                    new DateTime()
                     }; 
                

            }
            conectar.Close();
            
           

        }

        private void Ver_citas_Load(object sender, EventArgs e)
        {
            Calendario();

        }
    }
}
