namespace CRM_Principal.Agenda.Pagar_cita_adulto
{
    partial class Pago_adulto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pago_adulto));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_doctora = new System.Windows.Forms.TextBox();
            this.txt_cita = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(110, 143);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(180, 20);
            this.txt_costo.TabIndex = 16;
            // 
            // txt_doctora
            // 
            this.txt_doctora.Location = new System.Drawing.Point(110, 104);
            this.txt_doctora.Name = "txt_doctora";
            this.txt_doctora.ReadOnly = true;
            this.txt_doctora.Size = new System.Drawing.Size(180, 20);
            this.txt_doctora.TabIndex = 15;
            this.txt_doctora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cita
            // 
            this.txt_cita.Location = new System.Drawing.Point(110, 72);
            this.txt_cita.Name = "txt_cita";
            this.txt_cita.ReadOnly = true;
            this.txt_cita.Size = new System.Drawing.Size(180, 20);
            this.txt_cita.TabIndex = 14;
            this.txt_cita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(153, 41);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(180, 20);
            this.txt_nombre.TabIndex = 13;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Doctora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cita:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre del Paciente: ";
            // 
            // Pago_adulto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(369, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.txt_doctora);
            this.Controls.Add(this.txt_cita);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pago_adulto";
            this.Text = "Pagar cita de Adulto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_doctora;
        private System.Windows.Forms.TextBox txt_cita;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}