namespace CapaPresentacion.Ingresos
{
    partial class frmEditAfiliados
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
            this.txt_idA = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_celu = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_EstadoCivil = new System.Windows.Forms.ComboBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_F = new System.Windows.Forms.RadioButton();
            this.rb_M = new System.Windows.Forms.RadioButton();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 32);
            this.button2.TabIndex = 35;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_idA
            // 
            this.txt_idA.Location = new System.Drawing.Point(461, 26);
            this.txt_idA.Name = "txt_idA";
            this.txt_idA.Size = new System.Drawing.Size(52, 26);
            this.txt_idA.TabIndex = 33;
            this.txt_idA.Visible = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(408, 29);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(30, 20);
            this.lb_id.TabIndex = 32;
            this.lb_id.Text = "ID:";
            this.lb_id.Visible = false;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Activo",
            "No activo"});
            this.cb_estado.Location = new System.Drawing.Point(240, 496);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(180, 28);
            this.cb_estado.TabIndex = 31;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(240, 259);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(180, 26);
            this.txt_cedula.TabIndex = 30;
            this.txt_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cedula_KeyPress);
            // 
            // txt_celu
            // 
            this.txt_celu.Location = new System.Drawing.Point(240, 210);
            this.txt_celu.Name = "txt_celu";
            this.txt_celu.Size = new System.Drawing.Size(180, 26);
            this.txt_celu.TabIndex = 29;
            this.txt_celu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_celu_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(240, 160);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(180, 26);
            this.txt_name.TabIndex = 28;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(240, 118);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(180, 26);
            this.txt_direccion.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cedula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Afiliados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Sexo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Correo";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Estado Civil:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cb_EstadoCivil
            // 
            this.cb_EstadoCivil.FormattingEnabled = true;
            this.cb_EstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado",
            "Union Libre",
            "Viudo"});
            this.cb_EstadoCivil.Location = new System.Drawing.Point(240, 450);
            this.cb_EstadoCivil.Name = "cb_EstadoCivil";
            this.cb_EstadoCivil.Size = new System.Drawing.Size(180, 28);
            this.cb_EstadoCivil.TabIndex = 39;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(240, 405);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(180, 26);
            this.txt_Correo.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_F);
            this.groupBox1.Controls.Add(this.rb_M);
            this.groupBox1.Location = new System.Drawing.Point(240, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 55);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // rb_F
            // 
            this.rb_F.AutoSize = true;
            this.rb_F.Location = new System.Drawing.Point(108, 17);
            this.rb_F.Name = "rb_F";
            this.rb_F.Size = new System.Drawing.Size(44, 24);
            this.rb_F.TabIndex = 1;
            this.rb_F.TabStop = true;
            this.rb_F.Text = "F";
            this.rb_F.UseVisualStyleBackColor = true;
            // 
            // rb_M
            // 
            this.rb_M.AutoSize = true;
            this.rb_M.Location = new System.Drawing.Point(17, 19);
            this.rb_M.Name = "rb_M";
            this.rb_M.Size = new System.Drawing.Size(47, 24);
            this.rb_M.TabIndex = 0;
            this.rb_M.TabStop = true;
            this.rb_M.Text = "M";
            this.rb_M.UseVisualStyleBackColor = true;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(240, 312);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(180, 26);
            this.txt_Edad.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Edad:";
            // 
            // frmEditAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 653);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.cb_EstadoCivil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_idA);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.txt_celu);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmEditAfiliados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditAfiliados";
            this.Load += new System.EventHandler(this.frmEditAfiliados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_idA;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_celu;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_EstadoCivil;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_F;
        private System.Windows.Forms.RadioButton rb_M;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Label label10;
    }
}