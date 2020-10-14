namespace CRM_Principal
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientessinstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.junodoctorDataSet6 = new CRM_Principal.junodoctorDataSet6();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoubiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.junodoctor_clienteDataSet2 = new CRM_Principal.junodoctor_clienteDataSet2();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoubiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prospectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.junodoctor_clienteDataSet3 = new CRM_Principal.junodoctor_clienteDataSet3();
            this.clientes_sin_statusTableAdapter = new CRM_Principal.junodoctorDataSet6TableAdapters.clientes_sin_statusTableAdapter();
            this.usuarioTableAdapter = new CRM_Principal.junodoctor_clienteDataSet2TableAdapters.usuarioTableAdapter();
            this.prospectosTableAdapter = new CRM_Principal.junodoctor_clienteDataSet3TableAdapters.ProspectosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientessinstatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctorDataSet6)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctor_clienteDataSet2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prospectosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctor_clienteDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(922, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuarios General";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 154);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes sin estatus";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(292, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar al Sistema";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Busqueda por nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.ubicacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientessinstatusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(262, 116);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre Completo";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicacionDataGridViewTextBoxColumn
            // 
            this.ubicacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ubicacionDataGridViewTextBoxColumn.DataPropertyName = "ubicacion";
            this.ubicacionDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.ubicacionDataGridViewTextBoxColumn.Name = "ubicacionDataGridViewTextBoxColumn";
            this.ubicacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientessinstatusBindingSource
            // 
            this.clientessinstatusBindingSource.DataMember = "clientes_sin_status";
            this.clientessinstatusBindingSource.DataSource = this.junodoctorDataSet6;
            // 
            // junodoctorDataSet6
            // 
            this.junodoctorDataSet6.DataSetName = "junodoctorDataSet6";
            this.junodoctorDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(469, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 154);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes leads";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Busqueda por nombre";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn1,
            this.tipoubiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.usuarioBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(20, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(236, 116);
            this.dataGridView2.TabIndex = 3;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre Completo";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tipoubiDataGridViewTextBoxColumn
            // 
            this.tipoubiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoubiDataGridViewTextBoxColumn.DataPropertyName = "tipo_ubi";
            this.tipoubiDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.tipoubiDataGridViewTextBoxColumn.Name = "tipoubiDataGridViewTextBoxColumn";
            this.tipoubiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.junodoctor_clienteDataSet2;
            // 
            // junodoctor_clienteDataSet2
            // 
            this.junodoctor_clienteDataSet2.DataSetName = "junodoctor_clienteDataSet2";
            this.junodoctor_clienteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(248, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 154);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes Prospecto";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn2,
            this.tipoubiDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.prospectosBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(20, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(381, 116);
            this.dataGridView3.TabIndex = 3;
            // 
            // nombreDataGridViewTextBoxColumn2
            // 
            this.nombreDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn2.HeaderText = "Nombre Completo";
            this.nombreDataGridViewTextBoxColumn2.Name = "nombreDataGridViewTextBoxColumn2";
            this.nombreDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tipoubiDataGridViewTextBoxColumn1
            // 
            this.tipoubiDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoubiDataGridViewTextBoxColumn1.DataPropertyName = "tipo_ubi";
            this.tipoubiDataGridViewTextBoxColumn1.HeaderText = "Grupo";
            this.tipoubiDataGridViewTextBoxColumn1.Name = "tipoubiDataGridViewTextBoxColumn1";
            this.tipoubiDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prospectosBindingSource
            // 
            this.prospectosBindingSource.DataMember = "Prospectos";
            this.prospectosBindingSource.DataSource = this.junodoctor_clienteDataSet3;
            // 
            // junodoctor_clienteDataSet3
            // 
            this.junodoctor_clienteDataSet3.DataSetName = "junodoctor_clienteDataSet3";
            this.junodoctor_clienteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientes_sin_statusTableAdapter
            // 
            this.clientes_sin_statusTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // prospectosTableAdapter
            // 
            this.prospectosTableAdapter.ClearBeforeFill = true;
            // 
            // Principal
            // 
            this.ClientSize = new System.Drawing.Size(922, 487);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "CRM Juno Doctors";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientessinstatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctorDataSet6)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctor_clienteDataSet2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prospectosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctor_clienteDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prospectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem leadsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prospectosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pediatriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem leadsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem prospectosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem medicianasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talleresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem talleresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vacunasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem procedimientosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem graficasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem leadsToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem procedenciaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prospectosToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem procedenciaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem procedenciaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private junodoctorDataSet6 junodoctorDataSet6;
        private System.Windows.Forms.BindingSource clientessinstatusBindingSource;
        private junodoctorDataSet6TableAdapters.clientes_sin_statusTableAdapter clientes_sin_statusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacionDataGridViewTextBoxColumn;
        private junodoctor_clienteDataSet2 junodoctor_clienteDataSet2;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private junodoctor_clienteDataSet2TableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoubiDataGridViewTextBoxColumn;
        private junodoctor_clienteDataSet3 junodoctor_clienteDataSet3;
        private System.Windows.Forms.BindingSource prospectosBindingSource;
        private junodoctor_clienteDataSet3TableAdapters.ProspectosTableAdapter prospectosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoubiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
    }
}