namespace CRM_Principal
{
    partial class Actulizar_Datos_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actulizar_Datos_user));
            this.tipo_user = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ususario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tipo_user
            // 
            this.tipo_user.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tipo_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo_user.FormattingEnabled = true;
            this.tipo_user.Items.AddRange(new object[] {
            "Selecione una Opcion",
            "Administrador",
            "Asistente"});
            this.tipo_user.Location = new System.Drawing.Point(140, 143);
            this.tipo_user.Name = "tipo_user";
            this.tipo_user.Size = new System.Drawing.Size(170, 23);
            this.tipo_user.TabIndex = 19;
            this.tipo_user.Text = "Selecione una Opcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tipo de Usuario";
            // 
            // contra
            // 
            this.contra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra.Location = new System.Drawing.Point(121, 95);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(189, 26);
            this.contra.TabIndex = 17;
            this.contra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contra.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Contraseña";
            // 
            // ususario
            // 
            this.ususario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ususario.Location = new System.Drawing.Point(121, 53);
            this.ususario.Name = "ususario";
            this.ususario.Size = new System.Drawing.Size(189, 26);
            this.ususario.TabIndex = 15;
            this.ususario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Usuario";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSize = true;
            this.btn_actualizar.Location = new System.Drawing.Point(130, 190);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 13;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // Nombre
            // 
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(121, 14);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(189, 26);
            this.Nombre.TabIndex = 12;
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // Actulizar_Datos_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(323, 227);
            this.Controls.Add(this.tipo_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ususario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Actulizar_Datos_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizacion de Datos";
            this.Load += new System.EventHandler(this.Actulizar_Datos_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tipo_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ususario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label1;
    }
}