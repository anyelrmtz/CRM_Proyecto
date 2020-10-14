namespace CRM_Principal.configuracion_user
{
    partial class Doctores
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_guardar_new = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.text_correo = new System.Windows.Forms.TextBox();
            this.text_telefono = new System.Windows.Forms.TextBox();
            this.combo_especialidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.butn_actualizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.text_actualizar_coreeo = new System.Windows.Forms.TextBox();
            this.text_actualisar_tele = new System.Windows.Forms.TextBox();
            this.combo_actualizar_espe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_actualisa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.junodoctorDataSet4 = new CRM_Principal.junodoctorDataSet4();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Buscar_doctor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.datos_Especialisados = new System.Windows.Forms.DataGridView();
            this.doctorTableAdapter = new CRM_Principal.junodoctorDataSet4TableAdapters.DoctorTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctorDataSet4)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_Especialisados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_guardar_new);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.text_correo);
            this.groupBox1.Controls.Add(this.text_telefono);
            this.groupBox1.Controls.Add(this.combo_especialidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Doctor";
            // 
            // btn_guardar_new
            // 
            this.btn_guardar_new.BackColor = System.Drawing.Color.Lime;
            this.btn_guardar_new.Location = new System.Drawing.Point(97, 156);
            this.btn_guardar_new.Name = "btn_guardar_new";
            this.btn_guardar_new.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar_new.TabIndex = 8;
            this.btn_guardar_new.Text = "Guardar";
            this.btn_guardar_new.UseVisualStyleBackColor = false;
            this.btn_guardar_new.Click += new System.EventHandler(this.btn_guardar_new_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Correo";
            // 
            // text_correo
            // 
            this.text_correo.Location = new System.Drawing.Point(63, 130);
            this.text_correo.Name = "text_correo";
            this.text_correo.Size = new System.Drawing.Size(159, 20);
            this.text_correo.TabIndex = 6;
            // 
            // text_telefono
            // 
            this.text_telefono.Location = new System.Drawing.Point(63, 93);
            this.text_telefono.Name = "text_telefono";
            this.text_telefono.Size = new System.Drawing.Size(159, 20);
            this.text_telefono.TabIndex = 5;
            // 
            // combo_especialidad
            // 
            this.combo_especialidad.FormattingEnabled = true;
            this.combo_especialidad.Location = new System.Drawing.Point(84, 56);
            this.combo_especialidad.Name = "combo_especialidad";
            this.combo_especialidad.Size = new System.Drawing.Size(138, 21);
            this.combo_especialidad.TabIndex = 4;
            this.combo_especialidad.Text = "Seleccione una Opcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Especialidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(55, 19);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(203, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_borrar);
            this.groupBox2.Controls.Add(this.butn_actualizar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.text_actualizar_coreeo);
            this.groupBox2.Controls.Add(this.text_actualisar_tele);
            this.groupBox2.Controls.Add(this.combo_actualizar_espe);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.text_actualisa);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actualizar datos";
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(147, 164);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 17;
            this.btn_borrar.Text = "Limpiar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // butn_actualizar
            // 
            this.butn_actualizar.BackColor = System.Drawing.Color.Lime;
            this.butn_actualizar.Location = new System.Drawing.Point(43, 164);
            this.butn_actualizar.Name = "butn_actualizar";
            this.butn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.butn_actualizar.TabIndex = 16;
            this.butn_actualizar.Text = "Actualizar";
            this.butn_actualizar.UseVisualStyleBackColor = false;
            this.butn_actualizar.Click += new System.EventHandler(this.butn_actualizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Correo";
            // 
            // text_actualizar_coreeo
            // 
            this.text_actualizar_coreeo.Location = new System.Drawing.Point(73, 129);
            this.text_actualizar_coreeo.Name = "text_actualizar_coreeo";
            this.text_actualizar_coreeo.Size = new System.Drawing.Size(159, 20);
            this.text_actualizar_coreeo.TabIndex = 14;
            // 
            // text_actualisar_tele
            // 
            this.text_actualisar_tele.Location = new System.Drawing.Point(73, 92);
            this.text_actualisar_tele.Name = "text_actualisar_tele";
            this.text_actualisar_tele.Size = new System.Drawing.Size(159, 20);
            this.text_actualisar_tele.TabIndex = 13;
            // 
            // combo_actualizar_espe
            // 
            this.combo_actualizar_espe.FormattingEnabled = true;
            this.combo_actualizar_espe.Location = new System.Drawing.Point(94, 55);
            this.combo_actualizar_espe.Name = "combo_actualizar_espe";
            this.combo_actualizar_espe.Size = new System.Drawing.Size(138, 21);
            this.combo_actualizar_espe.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Especialidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nombre:";
            // 
            // text_actualisa
            // 
            this.text_actualisa.Location = new System.Drawing.Point(65, 18);
            this.text_actualisa.Name = "text_actualisa";
            this.text_actualisa.Size = new System.Drawing.Size(203, 20);
            this.text_actualisa.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(581, 174);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 74;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoDataGridViewTextBoxColumn.Width = 63;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.junodoctorDataSet4;
            // 
            // junodoctorDataSet4
            // 
            this.junodoctorDataSet4.DataSetName = "junodoctorDataSet4";
            this.junodoctorDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(300, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 214);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doctores ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Buscar_doctor);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.datos_Especialisados);
            this.groupBox4.Location = new System.Drawing.Point(300, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(587, 182);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Especialidad";
            // 
            // Buscar_doctor
            // 
            this.Buscar_doctor.FormattingEnabled = true;
            this.Buscar_doctor.Location = new System.Drawing.Point(6, 81);
            this.Buscar_doctor.Name = "Buscar_doctor";
            this.Buscar_doctor.Size = new System.Drawing.Size(138, 21);
            this.Buscar_doctor.TabIndex = 13;
            this.Buscar_doctor.Text = "Seleccione una Opcion";
            this.Buscar_doctor.SelectedIndexChanged += new System.EventHandler(this.Buscar_doctor_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Especialidad:";
            // 
            // datos_Especialisados
            // 
            this.datos_Especialisados.AllowUserToAddRows = false;
            this.datos_Especialisados.AllowUserToDeleteRows = false;
            this.datos_Especialisados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datos_Especialisados.Location = new System.Drawing.Point(162, 19);
            this.datos_Especialisados.Name = "datos_Especialisados";
            this.datos_Especialisados.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.datos_Especialisados.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datos_Especialisados.Size = new System.Drawing.Size(419, 157);
            this.datos_Especialisados.TabIndex = 0;
            this.datos_Especialisados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datos_Especialisados_CellContentClick);
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // Doctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 448);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctores";
            this.Text = "Doctores";
            this.Load += new System.EventHandler(this.Doctores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctorDataSet4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_Especialisados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_guardar_new;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_correo;
        private System.Windows.Forms.TextBox text_telefono;
        private System.Windows.Forms.ComboBox combo_especialidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button butn_actualizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_actualizar_coreeo;
        private System.Windows.Forms.TextBox text_actualisar_tele;
        private System.Windows.Forms.ComboBox combo_actualizar_espe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_actualisa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox Buscar_doctor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView datos_Especialisados;
        private junodoctorDataSet4 junodoctorDataSet4;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private junodoctorDataSet4TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
    }
}