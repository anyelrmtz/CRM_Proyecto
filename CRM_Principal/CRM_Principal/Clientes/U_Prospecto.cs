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
    public partial class U_Prospecto : Form
    {
        public U_Prospecto()
        {
            InitializeComponent();
        }

        private void U_Prospecto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'junodoctor_clienteDataSet_cliente_prospecto.Prospectos' Puede moverla o quitarla según sea necesario.
            this.prospectosTableAdapter.Fill(this.junodoctor_clienteDataSet_cliente_prospecto.Prospectos);

        }
    }
}
