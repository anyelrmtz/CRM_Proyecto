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
    public partial class U_Leads : Form
    {
        public U_Leads()
        {
            InitializeComponent();
        }

        private void U_Leads_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'junodoctor_clienteDataSet_clienlead.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.junodoctor_clienteDataSet_clienlead.usuario);

        }
    }
}
