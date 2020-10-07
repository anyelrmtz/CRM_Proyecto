namespace CRM_Principal
{
    partial class U_Prospecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(U_Prospecto));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.junodoctor_clienteDataSet_cliente_prospecto = new CRM_Principal.junodoctor_clienteDataSet_cliente_prospecto();
            this.prospectosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prospectosTableAdapter = new CRM_Principal.junodoctor_clienteDataSet_cliente_prospectoTableAdapters.ProspectosTableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoubiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultasninoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaadultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctor_clienteDataSet_cliente_prospecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prospectosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prospectos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(920, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.tipoubiDataGridViewTextBoxColumn,
            this.consultasninoDataGridViewTextBoxColumn,
            this.consultaadultDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prospectosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(822, 336);
            this.dataGridView1.TabIndex = 4;
            // 
            // junodoctor_clienteDataSet_cliente_prospecto
            // 
            this.junodoctor_clienteDataSet_cliente_prospecto.DataSetName = "junodoctor_clienteDataSet_cliente_prospecto";
            this.junodoctor_clienteDataSet_cliente_prospecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prospectosBindingSource
            // 
            this.prospectosBindingSource.DataMember = "Prospectos";
            this.prospectosBindingSource.DataSource = this.junodoctor_clienteDataSet_cliente_prospecto;
            // 
            // prospectosTableAdapter
            // 
            this.prospectosTableAdapter.ClearBeforeFill = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre Completo";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoubiDataGridViewTextBoxColumn
            // 
            this.tipoubiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoubiDataGridViewTextBoxColumn.DataPropertyName = "tipo_ubi";
            this.tipoubiDataGridViewTextBoxColumn.HeaderText = "Grupo";
            this.tipoubiDataGridViewTextBoxColumn.Name = "tipoubiDataGridViewTextBoxColumn";
            this.tipoubiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consultasninoDataGridViewTextBoxColumn
            // 
            this.consultasninoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.consultasninoDataGridViewTextBoxColumn.DataPropertyName = "Consultas_nino";
            this.consultasninoDataGridViewTextBoxColumn.HeaderText = "Consulta Total de Niño";
            this.consultasninoDataGridViewTextBoxColumn.Name = "consultasninoDataGridViewTextBoxColumn";
            this.consultasninoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // consultaadultDataGridViewTextBoxColumn
            // 
            this.consultaadultDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.consultaadultDataGridViewTextBoxColumn.DataPropertyName = "Consulta_adult";
            this.consultaadultDataGridViewTextBoxColumn.HeaderText = "Consulta Total de Adultos";
            this.consultaadultDataGridViewTextBoxColumn.Name = "consultaadultDataGridViewTextBoxColumn";
            this.consultaadultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // U_Prospecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 489);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "U_Prospecto";
            this.Text = "U_Prospecto";
            this.Load += new System.EventHandler(this.U_Prospecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctor_clienteDataSet_cliente_prospecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prospectosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private junodoctor_clienteDataSet_cliente_prospecto junodoctor_clienteDataSet_cliente_prospecto;
        private System.Windows.Forms.BindingSource prospectosBindingSource;
        private junodoctor_clienteDataSet_cliente_prospectoTableAdapters.ProspectosTableAdapter prospectosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoubiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultasninoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultaadultDataGridViewTextBoxColumn;
    }
}