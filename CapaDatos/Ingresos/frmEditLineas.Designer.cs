namespace CapaPresentacion.Ingresos
{
    partial class frmEditLineas
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
            this.txt_idLinea = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numLinea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_idUnidad = new System.Windows.Forms.TextBox();
            this.bt_recorrido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_idLinea
            // 
            this.txt_idLinea.Location = new System.Drawing.Point(488, 21);
            this.txt_idLinea.Name = "txt_idLinea";
            this.txt_idLinea.Size = new System.Drawing.Size(52, 26);
            this.txt_idLinea.TabIndex = 51;
            this.txt_idLinea.Visible = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(435, 24);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(30, 20);
            this.lb_id.TabIndex = 50;
            this.lb_id.Text = "ID:";
            this.lb_id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 49;
            this.label1.Text = "Lineas";
            // 
            // txt_numLinea
            // 
            this.txt_numLinea.Location = new System.Drawing.Point(288, 116);
            this.txt_numLinea.Name = "txt_numLinea";
            this.txt_numLinea.Size = new System.Drawing.Size(166, 26);
            this.txt_numLinea.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Estado:";
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Activo",
            "No activo"});
            this.cb_estado.Location = new System.Drawing.Point(284, 275);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(166, 28);
            this.cb_estado.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 57;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 32);
            this.button2.TabIndex = 58;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Numero de Linea:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Unidad:";
            // 
            // txt_idUnidad
            // 
            this.txt_idUnidad.Location = new System.Drawing.Point(288, 183);
            this.txt_idUnidad.Name = "txt_idUnidad";
            this.txt_idUnidad.Size = new System.Drawing.Size(166, 26);
            this.txt_idUnidad.TabIndex = 60;
            // 
            // bt_recorrido
            // 
            this.bt_recorrido.Location = new System.Drawing.Point(473, 185);
            this.bt_recorrido.Name = "bt_recorrido";
            this.bt_recorrido.Size = new System.Drawing.Size(46, 24);
            this.bt_recorrido.TabIndex = 61;
            this.bt_recorrido.Text = "...";
            this.bt_recorrido.UseVisualStyleBackColor = true;
            this.bt_recorrido.Click += new System.EventHandler(this.bt_recorrido_Click);
            // 
            // frmEditLineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 469);
            this.Controls.Add(this.bt_recorrido);
            this.Controls.Add(this.txt_idUnidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_numLinea);
            this.Controls.Add(this.txt_idLinea);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmEditLineas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditLineas";
            this.Load += new System.EventHandler(this.frmEditLineas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_idLinea;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numLinea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_idUnidad;
        private System.Windows.Forms.Button bt_recorrido;
    }
}