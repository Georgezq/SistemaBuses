namespace CapaPresentacion.Ingresos
{
    partial class frmEditRecorridos
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
            this.txt_idRecorrido = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_descripcion = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_origen = new System.Windows.Forms.TextBox();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_idRecorrido
            // 
            this.txt_idRecorrido.Location = new System.Drawing.Point(480, 50);
            this.txt_idRecorrido.Name = "txt_idRecorrido";
            this.txt_idRecorrido.Size = new System.Drawing.Size(52, 26);
            this.txt_idRecorrido.TabIndex = 53;
            this.txt_idRecorrido.Visible = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(427, 53);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(30, 20);
            this.lb_id.TabIndex = 52;
            this.lb_id.Text = "ID:";
            this.lb_id.Visible = false;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Activo",
            "No activo"});
            this.cb_estado.Location = new System.Drawing.Point(219, 383);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(180, 28);
            this.cb_estado.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 49;
            this.label1.Text = "Recorridos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Descripción:";
            // 
            // rtb_descripcion
            // 
            this.rtb_descripcion.Location = new System.Drawing.Point(219, 286);
            this.rtb_descripcion.Name = "rtb_descripcion";
            this.rtb_descripcion.Size = new System.Drawing.Size(313, 65);
            this.rtb_descripcion.TabIndex = 55;
            this.rtb_descripcion.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 32);
            this.button2.TabIndex = 57;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 56;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Origen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Destino:";
            // 
            // txt_origen
            // 
            this.txt_origen.Location = new System.Drawing.Point(219, 138);
            this.txt_origen.Name = "txt_origen";
            this.txt_origen.Size = new System.Drawing.Size(238, 26);
            this.txt_origen.TabIndex = 60;
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(219, 224);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(238, 26);
            this.txt_destino.TabIndex = 61;
            // 
            // frmEditRecorridos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 509);
            this.Controls.Add(this.txt_destino);
            this.Controls.Add(this.txt_origen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_idRecorrido);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "frmEditRecorridos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditRecorridos";
            this.Load += new System.EventHandler(this.frmEditRecorridos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_idRecorrido;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_descripcion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_origen;
        private System.Windows.Forms.TextBox txt_destino;
    }
}