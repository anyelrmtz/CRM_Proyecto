namespace CRM_Principal.Agenda
{
    partial class Ver_citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_citas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Calendario_citas = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.junodoctor_clienteDataSet = new CRM_Principal.junodoctor_clienteDataSet();
            this.consulninoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consul_ninoTableAdapter = new CRM_Principal.junodoctor_clienteDataSetTableAdapters.consul_ninoTableAdapter();
            this.nombreninoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoconsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fehcacitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horacitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.junodoctorclienteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.junodoctor_clienteDataSet1 = new CRM_Principal.junodoctor_clienteDataSet1();
            this.consuladultoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consul_adultoTableAdapter = new CRM_Principal.junodoctor_clienteDataSet1TableAdapters.consul_adultoTableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fehcacitaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horacitaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctor_clienteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulninoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctorclienteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctor_clienteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consuladultoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(920, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Citas  Niños";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Citas Agendadas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 177);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Citas Adultos";
            // 
            // Calendario_citas
            // 
            this.Calendario_citas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Calendario_citas.CalendarDimensions = new System.Drawing.Size(2, 3);
            this.Calendario_citas.ForeColor = System.Drawing.Color.DarkGreen;
            this.Calendario_citas.Location = new System.Drawing.Point(525, 9);
            this.Calendario_citas.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.Calendario_citas.Name = "Calendario_citas";
            this.Calendario_citas.TabIndex = 3;
            this.Calendario_citas.TitleForeColor = System.Drawing.Color.Red;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreninoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.tutorDataGridViewTextBoxColumn,
            this.tipoconsultaDataGridViewTextBoxColumn,
            this.doctoraDataGridViewTextBoxColumn,
            this.fehcacitaDataGridViewTextBoxColumn,
            this.horacitaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.consulninoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(481, 158);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn1,
            this.fehcacitaDataGridViewTextBoxColumn1,
            this.doctora,
            this.horacitaDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.consuladultoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(476, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // junodoctor_clienteDataSet
            // 
            this.junodoctor_clienteDataSet.DataSetName = "junodoctor_clienteDataSet";
            this.junodoctor_clienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consulninoBindingSource
            // 
            this.consulninoBindingSource.DataMember = "consul_nino";
            this.consulninoBindingSource.DataSource = this.junodoctor_clienteDataSet;
            // 
            // consul_ninoTableAdapter
            // 
            this.consul_ninoTableAdapter.ClearBeforeFill = true;
            // 
            // nombreninoDataGridViewTextBoxColumn
            // 
            this.nombreninoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreninoDataGridViewTextBoxColumn.DataPropertyName = "nombre_nino";
            this.nombreninoDataGridViewTextBoxColumn.HeaderText = "Pasiente";
            this.nombreninoDataGridViewTextBoxColumn.Name = "nombreninoDataGridViewTextBoxColumn";
            this.nombreninoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreninoDataGridViewTextBoxColumn.Width = 73;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            this.edadDataGridViewTextBoxColumn.Width = 57;
            // 
            // tutorDataGridViewTextBoxColumn
            // 
            this.tutorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tutorDataGridViewTextBoxColumn.DataPropertyName = "tutor";
            this.tutorDataGridViewTextBoxColumn.HeaderText = "Acompañante";
            this.tutorDataGridViewTextBoxColumn.Name = "tutorDataGridViewTextBoxColumn";
            this.tutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.tutorDataGridViewTextBoxColumn.Width = 98;
            // 
            // tipoconsultaDataGridViewTextBoxColumn
            // 
            this.tipoconsultaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tipoconsultaDataGridViewTextBoxColumn.DataPropertyName = "tipo_consulta";
            this.tipoconsultaDataGridViewTextBoxColumn.HeaderText = "Consulta";
            this.tipoconsultaDataGridViewTextBoxColumn.Name = "tipoconsultaDataGridViewTextBoxColumn";
            this.tipoconsultaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoconsultaDataGridViewTextBoxColumn.Width = 73;
            // 
            // doctoraDataGridViewTextBoxColumn
            // 
            this.doctoraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.doctoraDataGridViewTextBoxColumn.DataPropertyName = "doctora";
            this.doctoraDataGridViewTextBoxColumn.HeaderText = "Doctora";
            this.doctoraDataGridViewTextBoxColumn.Name = "doctoraDataGridViewTextBoxColumn";
            this.doctoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctoraDataGridViewTextBoxColumn.Width = 70;
            // 
            // fehcacitaDataGridViewTextBoxColumn
            // 
            this.fehcacitaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fehcacitaDataGridViewTextBoxColumn.DataPropertyName = "fehca_cita";
            this.fehcacitaDataGridViewTextBoxColumn.HeaderText = "Fecha de Cita";
            this.fehcacitaDataGridViewTextBoxColumn.Name = "fehcacitaDataGridViewTextBoxColumn";
            this.fehcacitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fehcacitaDataGridViewTextBoxColumn.Width = 98;
            // 
            // horacitaDataGridViewTextBoxColumn
            // 
            this.horacitaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.horacitaDataGridViewTextBoxColumn.DataPropertyName = "hora_cita";
            this.horacitaDataGridViewTextBoxColumn.HeaderText = "Hora ";
            this.horacitaDataGridViewTextBoxColumn.Name = "horacitaDataGridViewTextBoxColumn";
            this.horacitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horacitaDataGridViewTextBoxColumn.Width = 58;
            // 
            // junodoctorclienteDataSetBindingSource
            // 
            this.junodoctorclienteDataSetBindingSource.DataSource = this.junodoctor_clienteDataSet;
            this.junodoctorclienteDataSetBindingSource.Position = 0;
            // 
            // junodoctor_clienteDataSet1
            // 
            this.junodoctor_clienteDataSet1.DataSetName = "junodoctor_clienteDataSet1";
            this.junodoctor_clienteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consuladultoBindingSource
            // 
            this.consuladultoBindingSource.DataMember = "consul_adulto";
            this.consuladultoBindingSource.DataSource = this.junodoctor_clienteDataSet1;
            // 
            // consul_adultoTableAdapter
            // 
            this.consul_adultoTableAdapter.ClearBeforeFill = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Paciente";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edadDataGridViewTextBoxColumn1
            // 
            this.edadDataGridViewTextBoxColumn1.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn1.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn1.Name = "edadDataGridViewTextBoxColumn1";
            this.edadDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fehcacitaDataGridViewTextBoxColumn1
            // 
            this.fehcacitaDataGridViewTextBoxColumn1.DataPropertyName = "fehca_cita";
            this.fehcacitaDataGridViewTextBoxColumn1.HeaderText = "Fecha de Cita";
            this.fehcacitaDataGridViewTextBoxColumn1.Name = "fehcacitaDataGridViewTextBoxColumn1";
            this.fehcacitaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // doctora
            // 
            this.doctora.DataPropertyName = "doctora";
            this.doctora.HeaderText = "Doctora";
            this.doctora.Name = "doctora";
            this.doctora.ReadOnly = true;
            // 
            // horacitaDataGridViewTextBoxColumn1
            // 
            this.horacitaDataGridViewTextBoxColumn1.DataPropertyName = "hora_cita";
            this.horacitaDataGridViewTextBoxColumn1.HeaderText = "Hora";
            this.horacitaDataGridViewTextBoxColumn1.Name = "horacitaDataGridViewTextBoxColumn1";
            this.horacitaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Ver_citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 487);
            this.Controls.Add(this.Calendario_citas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ver_citas";
            this.Text = "Ver_citas";
            this.Load += new System.EventHandler(this.Ver_citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctor_clienteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consulninoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctorclienteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctor_clienteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consuladultoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar Calendario_citas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private junodoctor_clienteDataSet junodoctor_clienteDataSet;
        private System.Windows.Forms.BindingSource consulninoBindingSource;
        private junodoctor_clienteDataSetTableAdapters.consul_ninoTableAdapter consul_ninoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreninoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoconsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fehcacitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horacitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource junodoctorclienteDataSetBindingSource;
        private junodoctor_clienteDataSet1 junodoctor_clienteDataSet1;
        private System.Windows.Forms.BindingSource consuladultoBindingSource;
        private junodoctor_clienteDataSet1TableAdapters.consul_adultoTableAdapter consul_adultoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fehcacitaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctora;
        private System.Windows.Forms.DataGridViewTextBoxColumn horacitaDataGridViewTextBoxColumn1;
    }
}