using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Principal
{
    public partial class Registrar_Usuarios : Form
    {
        public Registrar_Usuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login inicio = new login();
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }
    }
}
