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
    public partial class AC_Adultos : Form
    {
        public AC_Adultos()
        {
            InitializeComponent();
        }
        //pasiente
        String En_tuto;
        String Medi_tuto;
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                En_tuto = "SI";
                textBox5.Enabled = true;
            }

        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                En_tuto = "No";
                textBox5.Enabled = false;
            }
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                Medi_tuto = "Si";
                textBox1.Enabled = true;
            }
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                Medi_tuto = "No";
                textBox1.Enabled = false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }


        public void Limpiar()

        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                    this.textBox1.Focus();
                }
            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.SelectedIndex = -1;
                }
            }
            /////////////////////grupo bos 1
            foreach (Control c in this.groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                    this.textBox1.Focus();
                }
            }
            foreach (Control ctrl in this.groupBox1.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.SelectedIndex = -1;
                }
            } /////////////////////grupo bos 2
            foreach (Control c in this.groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = false;

                    this.textBox1.Focus();
                }
            }
            foreach (Control ctrl in this.groupBox2.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton text = ctrl as RadioButton;
                    text.Checked = false;
                }
            }
            /////////////////////grupo bos 3
            foreach (Control c in this.groupBox3.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    c.Enabled = false;

                    this.textBox1.Focus();
                }
            }
            foreach (Control ctrl in this.groupBox3
.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton text = ctrl as RadioButton;
                    text.Checked = false;
                }
            }
        }

    }
}
