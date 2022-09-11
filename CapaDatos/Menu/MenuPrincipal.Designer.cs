namespace CapaPresentacion.Menu
{
    partial class MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_rol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuusuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuafiliado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuunidad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuchofer = new System.Windows.Forms.ToolStripMenuItem();
            this.menupago = new System.Windows.Forms.ToolStripMenuItem();
            this.menurecorrido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuturno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuturnounidad = new System.Windows.Forms.ToolStripMenuItem();
            this.menulineas = new System.Windows.Forms.ToolStripMenuItem();
            this.menucobro = new System.Windows.Forms.ToolStripMenuItem();
            this.all_menu = new System.Windows.Forms.MenuStrip();
            this.menuturnochofer = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.container.SuspendLayout();
            this.all_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lb_rol);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(207, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 89);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_rol
            // 
            this.lb_rol.AutoSize = true;
            this.lb_rol.BackColor = System.Drawing.Color.SteelBlue;
            this.lb_rol.Location = new System.Drawing.Point(772, 37);
            this.lb_rol.Name = "lb_rol";
            this.lb_rol.Size = new System.Drawing.Size(0, 20);
            this.lb_rol.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(350, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(682, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rol:";
            // 
            // txt_user
            // 
            this.txt_user.AutoSize = true;
            this.txt_user.BackColor = System.Drawing.Color.SteelBlue;
            this.txt_user.Location = new System.Drawing.Point(488, 37);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(0, 20);
            this.txt_user.TabIndex = 17;
            // 
            // container
            // 
            this.container.Controls.Add(this.panel2);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(207, 89);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1471, 875);
            this.container.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 805);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1471, 70);
            this.panel2.TabIndex = 0;
            // 
            // menuusuario
            // 
            this.menuusuario.AutoSize = false;
            this.menuusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuusuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuusuario.Name = "menuusuario";
            this.menuusuario.Size = new System.Drawing.Size(192, 50);
            this.menuusuario.Text = "Usuarios";
            this.menuusuario.Click += new System.EventHandler(this.menuusuario_Click_1);
            // 
            // menuafiliado
            // 
            this.menuafiliado.AutoSize = false;
            this.menuafiliado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuafiliado.Name = "menuafiliado";
            this.menuafiliado.Size = new System.Drawing.Size(192, 50);
            this.menuafiliado.Text = "Afiliados";
            this.menuafiliado.Click += new System.EventHandler(this.menuafiliado_Click_1);
            // 
            // menuunidad
            // 
            this.menuunidad.AutoSize = false;
            this.menuunidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuunidad.Name = "menuunidad";
            this.menuunidad.Size = new System.Drawing.Size(192, 50);
            this.menuunidad.Text = "Unidades";
            this.menuunidad.Click += new System.EventHandler(this.menuunidad_Click_1);
            // 
            // menuchofer
            // 
            this.menuchofer.AutoSize = false;
            this.menuchofer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuchofer.Name = "menuchofer";
            this.menuchofer.Size = new System.Drawing.Size(192, 50);
            this.menuchofer.Text = "Choferes";
            this.menuchofer.Click += new System.EventHandler(this.menuchofer_Click_1);
            // 
            // menupago
            // 
            this.menupago.AutoSize = false;
            this.menupago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menupago.Name = "menupago";
            this.menupago.Size = new System.Drawing.Size(192, 50);
            this.menupago.Text = "Pagos";
            this.menupago.Click += new System.EventHandler(this.menupago_Click_1);
            // 
            // menurecorrido
            // 
            this.menurecorrido.AutoSize = false;
            this.menurecorrido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menurecorrido.Name = "menurecorrido";
            this.menurecorrido.Size = new System.Drawing.Size(192, 50);
            this.menurecorrido.Text = "Recorridos";
            this.menurecorrido.Click += new System.EventHandler(this.menurecorrido_Click_1);
            // 
            // menuturno
            // 
            this.menuturno.AutoSize = false;
            this.menuturno.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuturno.Name = "menuturno";
            this.menuturno.Size = new System.Drawing.Size(192, 50);
            this.menuturno.Text = "Turnos";
            this.menuturno.Click += new System.EventHandler(this.menuturno_Click_1);
            // 
            // menuturnounidad
            // 
            this.menuturnounidad.AutoSize = false;
            this.menuturnounidad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuturnounidad.Name = "menuturnounidad";
            this.menuturnounidad.Size = new System.Drawing.Size(192, 50);
            this.menuturnounidad.Text = "Turno Unidad";
            this.menuturnounidad.Click += new System.EventHandler(this.menuturnounidad_Click);
            // 
            // menulineas
            // 
            this.menulineas.AutoSize = false;
            this.menulineas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menulineas.Name = "menulineas";
            this.menulineas.Size = new System.Drawing.Size(192, 50);
            this.menulineas.Text = "Lineas";
            this.menulineas.Click += new System.EventHandler(this.menulineas_Click_1);
            // 
            // menucobro
            // 
            this.menucobro.AutoSize = false;
            this.menucobro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucobro.Name = "menucobro";
            this.menucobro.Size = new System.Drawing.Size(192, 50);
            this.menucobro.Text = "Cobros";
            this.menucobro.Click += new System.EventHandler(this.menucobro_Click_1);
            // 
            // all_menu
            // 
            this.all_menu.AutoSize = false;
            this.all_menu.BackColor = System.Drawing.Color.AliceBlue;
            this.all_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.all_menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.all_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.all_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuario,
            this.menuafiliado,
            this.menuunidad,
            this.menuchofer,
            this.menupago,
            this.menurecorrido,
            this.menuturno,
            this.menuturnounidad,
            this.menulineas,
            this.menucobro,
            this.menuturnochofer});
            this.all_menu.Location = new System.Drawing.Point(0, 0);
            this.all_menu.Name = "all_menu";
            this.all_menu.Size = new System.Drawing.Size(207, 964);
            this.all_menu.TabIndex = 1;
            this.all_menu.Text = "menu_all";
            // 
            // menuturnochofer
            // 
            this.menuturnochofer.AutoSize = false;
            this.menuturnochofer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuturnochofer.Name = "menuturnochofer";
            this.menuturnochofer.Size = new System.Drawing.Size(192, 50);
            this.menuturnochofer.Text = "Turno Chofer";
            this.menuturnochofer.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1678, 964);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.all_menu);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.container.ResumeLayout(false);
            this.all_menu.ResumeLayout(false);
            this.all_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_user;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.ToolStripMenuItem menuusuario;
        private System.Windows.Forms.ToolStripMenuItem menuafiliado;
        private System.Windows.Forms.ToolStripMenuItem menuunidad;
        private System.Windows.Forms.ToolStripMenuItem menuchofer;
        private System.Windows.Forms.ToolStripMenuItem menupago;
        private System.Windows.Forms.ToolStripMenuItem menurecorrido;
        private System.Windows.Forms.ToolStripMenuItem menuturno;
        private System.Windows.Forms.ToolStripMenuItem menuturnounidad;
        private System.Windows.Forms.ToolStripMenuItem menulineas;
        private System.Windows.Forms.ToolStripMenuItem menucobro;
        private System.Windows.Forms.MenuStrip all_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem menuturnochofer;
    }
}