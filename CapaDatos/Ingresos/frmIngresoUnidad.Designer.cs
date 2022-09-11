namespace CapaPresentacion.Ingresos
{
    partial class frmIngresoUnidad
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idChofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFabricacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUnidad,
            this.idChofer,
            this.Placa,
            this.Modelo,
            this.Marca,
            this.FechaFabricacion,
            this.idLinea,
            this.Capacidad,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(109, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(966, 380);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idUnidad
            // 
            this.idUnidad.DataPropertyName = "idUnidad";
            this.idUnidad.HeaderText = "idUnidad";
            this.idUnidad.MinimumWidth = 8;
            this.idUnidad.Name = "idUnidad";
            this.idUnidad.Visible = false;
            this.idUnidad.Width = 150;
            // 
            // idChofer
            // 
            this.idChofer.DataPropertyName = "idChofer";
            this.idChofer.HeaderText = "idChofer";
            this.idChofer.MinimumWidth = 8;
            this.idChofer.Name = "idChofer";
            this.idChofer.Visible = false;
            this.idChofer.Width = 150;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.MinimumWidth = 8;
            this.Placa.Name = "Placa";
            this.Placa.Width = 150;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 8;
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 150;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 8;
            this.Marca.Name = "Marca";
            this.Marca.Width = 150;
            // 
            // FechaFabricacion
            // 
            this.FechaFabricacion.DataPropertyName = "fechaFabricacion";
            this.FechaFabricacion.HeaderText = "FechaFabricacion";
            this.FechaFabricacion.MinimumWidth = 8;
            this.FechaFabricacion.Name = "FechaFabricacion";
            this.FechaFabricacion.Width = 150;
            // 
            // idLinea
            // 
            this.idLinea.DataPropertyName = "idLinea";
            this.idLinea.HeaderText = "idLinea";
            this.idLinea.MinimumWidth = 8;
            this.idLinea.Name = "idLinea";
            this.idLinea.Visible = false;
            this.idLinea.Width = 150;
            // 
            // Capacidad
            // 
            this.Capacidad.DataPropertyName = "capacidad";
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.MinimumWidth = 8;
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Width = 150;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 8;
            this.Estado.Name = "Estado";
            this.Estado.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Asignar Unidad";
            // 
            // frmIngresoUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmIngresoUnidad";
            this.Text = "frmIngresoUnidad";
            this.Load += new System.EventHandler(this.frmIngresoUnidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFabricacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label1;
    }
}