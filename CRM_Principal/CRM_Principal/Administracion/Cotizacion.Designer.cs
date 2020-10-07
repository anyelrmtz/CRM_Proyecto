namespace CRM_Principal
{
    partial class Cotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizacion));
            this.label1 = new System.Windows.Forms.Label();
            this.comb_cotizar = new System.Windows.Forms.ComboBox();
            this.combo_servicio = new System.Windows.Forms.ComboBox();
            this.combo_tipo = new System.Windows.Forms.ComboBox();
            this.cantidad_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechhoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotizarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.junodoctorDataSet2 = new CRM_Principal.junodoctorDataSet2();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textbox_descrip = new System.Windows.Forms.RichTextBox();
            this.cotizacionTableAdapter = new CRM_Principal.junodoctorDataSet2TableAdapters.CotizacionTableAdapter();
            this.junodoctorDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cotizacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctorDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctorDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotización";
            // 
            // comb_cotizar
            // 
            this.comb_cotizar.FormattingEnabled = true;
            this.comb_cotizar.Items.AddRange(new object[] {
            "Gastos",
            "Ingresos"});
            this.comb_cotizar.Location = new System.Drawing.Point(138, 95);
            this.comb_cotizar.Name = "comb_cotizar";
            this.comb_cotizar.Size = new System.Drawing.Size(136, 21);
            this.comb_cotizar.TabIndex = 2;
            this.comb_cotizar.Text = "Selecione una Opcion";
            this.comb_cotizar.SelectedIndexChanged += new System.EventHandler(this.comb_cotizar_SelectedIndexChanged_1);
            this.comb_cotizar.TabIndexChanged += new System.EventHandler(this.comb_cotizar_TabIndexChanged);
            // 
            // combo_servicio
            // 
            this.combo_servicio.FormattingEnabled = true;
            this.combo_servicio.Location = new System.Drawing.Point(138, 181);
            this.combo_servicio.Name = "combo_servicio";
            this.combo_servicio.Size = new System.Drawing.Size(136, 21);
            this.combo_servicio.TabIndex = 3;
            this.combo_servicio.Text = "Selecione una Opcion";
            this.combo_servicio.SelectedIndexChanged += new System.EventHandler(this.combo_servicio_SelectedIndexChanged);
            // 
            // combo_tipo
            // 
            this.combo_tipo.FormattingEnabled = true;
            this.combo_tipo.Location = new System.Drawing.Point(138, 136);
            this.combo_tipo.Name = "combo_tipo";
            this.combo_tipo.Size = new System.Drawing.Size(136, 21);
            this.combo_tipo.TabIndex = 4;
            this.combo_tipo.Text = "Selecione una Opcion";
            this.combo_tipo.SelectedIndexChanged += new System.EventHandler(this.combo_tipo_SelectedIndexChanged);
            this.combo_tipo.SelectedValueChanged += new System.EventHandler(this.combo_tipo_SelectedValueChanged);
            // 
            // cantidad_text
            // 
            this.cantidad_text.Location = new System.Drawing.Point(138, 313);
            this.cantidad_text.Name = "cantidad_text";
            this.cantidad_text.Size = new System.Drawing.Size(121, 20);
            this.cantidad_text.TabIndex = 5;
            this.cantidad_text.TextChanged += new System.EventHandler(this.cantidad_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cotizar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Costo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(906, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Location = new System.Drawing.Point(302, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 363);
            this.panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechhoraDataGridViewTextBoxColumn,
            this.cotizarDataGridViewTextBoxColumn,
            this.tipocotDataGridViewTextBoxColumn,
            this.serviDataGridViewTextBoxColumn,
            this.descripDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cotizacionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(523, 255);
            this.dataGridView1.TabIndex = 14;
            // 
            // fechhoraDataGridViewTextBoxColumn
            // 
            this.fechhoraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechhoraDataGridViewTextBoxColumn.DataPropertyName = "fech_hora";
            this.fechhoraDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechhoraDataGridViewTextBoxColumn.Name = "fechhoraDataGridViewTextBoxColumn";
            this.fechhoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechhoraDataGridViewTextBoxColumn.Width = 62;
            // 
            // cotizarDataGridViewTextBoxColumn
            // 
            this.cotizarDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cotizarDataGridViewTextBoxColumn.DataPropertyName = "cotizar";
            this.cotizarDataGridViewTextBoxColumn.HeaderText = "Cotizasiòn";
            this.cotizarDataGridViewTextBoxColumn.Name = "cotizarDataGridViewTextBoxColumn";
            this.cotizarDataGridViewTextBoxColumn.ReadOnly = true;
            this.cotizarDataGridViewTextBoxColumn.Width = 80;
            // 
            // tipocotDataGridViewTextBoxColumn
            // 
            this.tipocotDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tipocotDataGridViewTextBoxColumn.DataPropertyName = "tipo_cot";
            this.tipocotDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipocotDataGridViewTextBoxColumn.Name = "tipocotDataGridViewTextBoxColumn";
            this.tipocotDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipocotDataGridViewTextBoxColumn.Width = 53;
            // 
            // serviDataGridViewTextBoxColumn
            // 
            this.serviDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.serviDataGridViewTextBoxColumn.DataPropertyName = "servi";
            this.serviDataGridViewTextBoxColumn.HeaderText = "Servicio";
            this.serviDataGridViewTextBoxColumn.Name = "serviDataGridViewTextBoxColumn";
            this.serviDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviDataGridViewTextBoxColumn.Width = 70;
            // 
            // descripDataGridViewTextBoxColumn
            // 
            this.descripDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.descripDataGridViewTextBoxColumn.DataPropertyName = "descrip";
            this.descripDataGridViewTextBoxColumn.HeaderText = "Descripciòn";
            this.descripDataGridViewTextBoxColumn.Name = "descripDataGridViewTextBoxColumn";
            this.descripDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripDataGridViewTextBoxColumn.Width = 88;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "$";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 5;
            // 
            // cotizacionBindingSource
            // 
            this.cotizacionBindingSource.DataMember = "Cotizacion";
            this.cotizacionBindingSource.DataSource = this.junodoctorDataSet2;
            // 
            // junodoctorDataSet2
            // 
            this.junodoctorDataSet2.DataSetName = "junodoctorDataSet2";
            this.junodoctorDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Informacion";
            // 
            // comboBox5
            // 
            this.comboBox5.Enabled = false;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Opciones",
            "Cursos",
            "Talleres",
            "Procedimietos",
            "Servicios",
            "Consulta",
            "Vacunas",
            "Medicinas"});
            this.comboBox5.Location = new System.Drawing.Point(246, 50);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 9;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Filtros";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Ingresos",
            "Gastos"});
            this.comboBox4.Location = new System.Drawing.Point(108, 50);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 7;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Descripcion";
            // 
            // textbox_descrip
            // 
            this.textbox_descrip.Location = new System.Drawing.Point(139, 222);
            this.textbox_descrip.Name = "textbox_descrip";
            this.textbox_descrip.Size = new System.Drawing.Size(145, 80);
            this.textbox_descrip.TabIndex = 14;
            this.textbox_descrip.Text = "";
            // 
            // cotizacionTableAdapter
            // 
            this.cotizacionTableAdapter.ClearBeforeFill = true;
            // 
            // junodoctorDataSet2BindingSource
            // 
            this.junodoctorDataSet2BindingSource.DataSource = this.junodoctorDataSet2;
            this.junodoctorDataSet2BindingSource.Position = 0;
            // 
            // cotizacionBindingSource1
            // 
            this.cotizacionBindingSource1.DataMember = "Cotizacion";
            this.cotizacionBindingSource1.DataSource = this.junodoctorDataSet2;
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 448);
            this.Controls.Add(this.textbox_descrip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidad_text);
            this.Controls.Add(this.combo_tipo);
            this.Controls.Add(this.combo_servicio);
            this.Controls.Add(this.comb_cotizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cotizacion";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.Cotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctorDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.junodoctorDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comb_cotizar;
        private System.Windows.Forms.ComboBox combo_servicio;
        private System.Windows.Forms.ComboBox combo_tipo;
        private System.Windows.Forms.TextBox cantidad_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox textbox_descrip;
        private junodoctorDataSet2 junodoctorDataSet2;
        private System.Windows.Forms.BindingSource cotizacionBindingSource;
        private junodoctorDataSet2TableAdapters.CotizacionTableAdapter cotizacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechhoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotizarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource junodoctorDataSet2BindingSource;
        private System.Windows.Forms.BindingSource cotizacionBindingSource1;
    }
}