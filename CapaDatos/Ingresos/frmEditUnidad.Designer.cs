namespace CapaPresentacion.Ingresos
{
    partial class frmEditUnidad
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_idUni = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_placa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_chofer = new System.Windows.Forms.ComboBox();
            this.txt_capacidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_idRecorrido = new System.Windows.Forms.TextBox();
            this.bt_recorrido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 650);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 32);
            this.button2.TabIndex = 50;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 49;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_idUni
            // 
            this.txt_idUni.Location = new System.Drawing.Point(461, 41);
            this.txt_idUni.Name = "txt_idUni";
            this.txt_idUni.Size = new System.Drawing.Size(52, 26);
            this.txt_idUni.TabIndex = 48;
            this.txt_idUni.Visible = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(408, 44);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(30, 20);
            this.lb_id.TabIndex = 47;
            this.lb_id.Text = "ID:";
            this.lb_id.Visible = false;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Activo",
            "No activo"});
            this.cb_estado.Location = new System.Drawing.Point(291, 568);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(180, 28);
            this.cb_estado.TabIndex = 46;
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(291, 309);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(180, 26);
            this.txt_marca.TabIndex = 45;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(291, 246);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(180, 26);
            this.txt_modelo.TabIndex = 44;
            // 
            // txt_placa
            // 
            this.txt_placa.Location = new System.Drawing.Point(291, 183);
            this.txt_placa.Name = "txt_placa";
            this.txt_placa.Size = new System.Drawing.Size(180, 26);
            this.txt_placa.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 576);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Placa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Chofer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "Unidad";
            // 
            // cb_chofer
            // 
            this.cb_chofer.FormattingEnabled = true;
            this.cb_chofer.Location = new System.Drawing.Point(291, 123);
            this.cb_chofer.Name = "cb_chofer";
            this.cb_chofer.Size = new System.Drawing.Size(180, 28);
            this.cb_chofer.TabIndex = 51;
            // 
            // txt_capacidad
            // 
            this.txt_capacidad.Location = new System.Drawing.Point(291, 507);
            this.txt_capacidad.Name = "txt_capacidad";
            this.txt_capacidad.Size = new System.Drawing.Size(180, 26);
            this.txt_capacidad.TabIndex = 53;
            this.txt_capacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_capacidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Capacidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Recorrido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Fecha Fabricación:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(291, 449);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(180, 26);
            this.dtp_fecha.TabIndex = 57;
            // 
            // txt_idRecorrido
            // 
            this.txt_idRecorrido.Location = new System.Drawing.Point(291, 376);
            this.txt_idRecorrido.Name = "txt_idRecorrido";
            this.txt_idRecorrido.Size = new System.Drawing.Size(180, 26);
            this.txt_idRecorrido.TabIndex = 58;
            // 
            // bt_recorrido
            // 
            this.bt_recorrido.Location = new System.Drawing.Point(488, 382);
            this.bt_recorrido.Name = "bt_recorrido";
            this.bt_recorrido.Size = new System.Drawing.Size(46, 24);
            this.bt_recorrido.TabIndex = 62;
            this.bt_recorrido.Text = "...";
            this.bt_recorrido.UseVisualStyleBackColor = true;
            this.bt_recorrido.Click += new System.EventHandler(this.bt_recorrido_Click);
            // 
            // frmEditUnidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 694);
            this.Controls.Add(this.bt_recorrido);
            this.Controls.Add(this.txt_idRecorrido);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_capacidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_chofer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_idUni);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.txt_placa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmEditUnidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditUnidad";
            this.Load += new System.EventHandler(this.frmEditUnidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_idUni;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_placa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_chofer;
        private System.Windows.Forms.TextBox txt_capacidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.TextBox txt_idRecorrido;
        private System.Windows.Forms.Button bt_recorrido;
    }
}