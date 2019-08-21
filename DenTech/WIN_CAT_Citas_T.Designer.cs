namespace DenTech
{
    partial class WIN_CAT_Citas_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Citas_T));
            this.PANEL_Mes = new System.Windows.Forms.Panel();
            this.STC_MesAño = new System.Windows.Forms.Label();
            this.PANEL_Flechas = new System.Windows.Forms.Panel();
            this.BTN_FechaActual = new System.Windows.Forms.Button();
            this.BTN_Adelante = new System.Windows.Forms.Button();
            this.BTN_Atras = new System.Windows.Forms.Button();
            this.LAYOUT_Cuerpo = new System.Windows.Forms.FlowLayoutPanel();
            this.PANEL_CuadroDia = new System.Windows.Forms.FlowLayoutPanel();
            this.STC_NumDia = new System.Windows.Forms.Label();
            this.LSTC_Appointment = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.STC_Sabado = new System.Windows.Forms.Label();
            this.STC_Viernes = new System.Windows.Forms.Label();
            this.STC_Jueves = new System.Windows.Forms.Label();
            this.STC_Miercoles = new System.Windows.Forms.Label();
            this.STC_Martes = new System.Windows.Forms.Label();
            this.STC_Lunes = new System.Windows.Forms.Label();
            this.STC_Domingo = new System.Windows.Forms.Label();
            this.Menu_ModEli = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuOp_Modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.recetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOp_Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.PANEL_Mes.SuspendLayout();
            this.PANEL_Flechas.SuspendLayout();
            this.LAYOUT_Cuerpo.SuspendLayout();
            this.PANEL_CuadroDia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Menu_ModEli.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_Mes
            // 
            this.PANEL_Mes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PANEL_Mes.Controls.Add(this.STC_MesAño);
            this.PANEL_Mes.Location = new System.Drawing.Point(28, 22);
            this.PANEL_Mes.Name = "PANEL_Mes";
            this.PANEL_Mes.Size = new System.Drawing.Size(966, 45);
            this.PANEL_Mes.TabIndex = 40;
            // 
            // STC_MesAño
            // 
            this.STC_MesAño.AutoSize = true;
            this.STC_MesAño.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_MesAño.ForeColor = System.Drawing.Color.Black;
            this.STC_MesAño.Location = new System.Drawing.Point(8, 5);
            this.STC_MesAño.Name = "STC_MesAño";
            this.STC_MesAño.Size = new System.Drawing.Size(117, 32);
            this.STC_MesAño.TabIndex = 41;
            this.STC_MesAño.Text = "Mes, Año";
            // 
            // PANEL_Flechas
            // 
            this.PANEL_Flechas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PANEL_Flechas.Controls.Add(this.BTN_FechaActual);
            this.PANEL_Flechas.Controls.Add(this.BTN_Adelante);
            this.PANEL_Flechas.Controls.Add(this.BTN_Atras);
            this.PANEL_Flechas.Location = new System.Drawing.Point(782, 22);
            this.PANEL_Flechas.Name = "PANEL_Flechas";
            this.PANEL_Flechas.Size = new System.Drawing.Size(212, 45);
            this.PANEL_Flechas.TabIndex = 41;
            // 
            // BTN_FechaActual
            // 
            this.BTN_FechaActual.BackColor = System.Drawing.Color.White;
            this.BTN_FechaActual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_FechaActual.FlatAppearance.BorderSize = 2;
            this.BTN_FechaActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FechaActual.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FechaActual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_FechaActual.Location = new System.Drawing.Point(79, 4);
            this.BTN_FechaActual.Name = "BTN_FechaActual";
            this.BTN_FechaActual.Size = new System.Drawing.Size(54, 36);
            this.BTN_FechaActual.TabIndex = 2;
            this.BTN_FechaActual.Text = "Hoy";
            this.BTN_FechaActual.UseVisualStyleBackColor = false;
            this.BTN_FechaActual.Click += new System.EventHandler(this.BTN_FechaActual_Click);
            // 
            // BTN_Adelante
            // 
            this.BTN_Adelante.BackColor = System.Drawing.Color.White;
            this.BTN_Adelante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Adelante.FlatAppearance.BorderSize = 2;
            this.BTN_Adelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Adelante.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Adelante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Adelante.Location = new System.Drawing.Point(139, 4);
            this.BTN_Adelante.Name = "BTN_Adelante";
            this.BTN_Adelante.Size = new System.Drawing.Size(40, 36);
            this.BTN_Adelante.TabIndex = 3;
            this.BTN_Adelante.Text = ">";
            this.BTN_Adelante.UseVisualStyleBackColor = false;
            this.BTN_Adelante.Click += new System.EventHandler(this.BTN_Adelante_Click);
            // 
            // BTN_Atras
            // 
            this.BTN_Atras.BackColor = System.Drawing.Color.White;
            this.BTN_Atras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Atras.FlatAppearance.BorderSize = 2;
            this.BTN_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Atras.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Atras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Atras.Location = new System.Drawing.Point(33, 4);
            this.BTN_Atras.Name = "BTN_Atras";
            this.BTN_Atras.Size = new System.Drawing.Size(40, 36);
            this.BTN_Atras.TabIndex = 1;
            this.BTN_Atras.Text = "<";
            this.BTN_Atras.UseVisualStyleBackColor = false;
            this.BTN_Atras.Click += new System.EventHandler(this.BTN_Atras_Click);
            // 
            // LAYOUT_Cuerpo
            // 
            this.LAYOUT_Cuerpo.Controls.Add(this.PANEL_CuadroDia);
            this.LAYOUT_Cuerpo.Location = new System.Drawing.Point(28, 94);
            this.LAYOUT_Cuerpo.Name = "LAYOUT_Cuerpo";
            this.LAYOUT_Cuerpo.Size = new System.Drawing.Size(966, 464);
            this.LAYOUT_Cuerpo.TabIndex = 41;
            // 
            // PANEL_CuadroDia
            // 
            this.PANEL_CuadroDia.Controls.Add(this.STC_NumDia);
            this.PANEL_CuadroDia.Controls.Add(this.LSTC_Appointment);
            this.PANEL_CuadroDia.Location = new System.Drawing.Point(3, 3);
            this.PANEL_CuadroDia.Name = "PANEL_CuadroDia";
            this.PANEL_CuadroDia.Size = new System.Drawing.Size(132, 71);
            this.PANEL_CuadroDia.TabIndex = 0;
            // 
            // STC_NumDia
            // 
            this.STC_NumDia.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_NumDia.ForeColor = System.Drawing.Color.Black;
            this.STC_NumDia.Location = new System.Drawing.Point(3, 0);
            this.STC_NumDia.Name = "STC_NumDia";
            this.STC_NumDia.Size = new System.Drawing.Size(119, 25);
            this.STC_NumDia.TabIndex = 50;
            this.STC_NumDia.Text = "1";
            this.STC_NumDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LSTC_Appointment
            // 
            this.LSTC_Appointment.AutoSize = true;
            this.LSTC_Appointment.Location = new System.Drawing.Point(3, 25);
            this.LSTC_Appointment.Name = "LSTC_Appointment";
            this.LSTC_Appointment.Size = new System.Drawing.Size(66, 13);
            this.LSTC_Appointment.TabIndex = 51;
            this.LSTC_Appointment.TabStop = true;
            this.LSTC_Appointment.Text = "Appointment";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.STC_Sabado);
            this.panel1.Controls.Add(this.STC_Viernes);
            this.panel1.Controls.Add(this.STC_Jueves);
            this.panel1.Controls.Add(this.STC_Miercoles);
            this.panel1.Controls.Add(this.STC_Martes);
            this.panel1.Controls.Add(this.STC_Lunes);
            this.panel1.Controls.Add(this.STC_Domingo);
            this.panel1.Location = new System.Drawing.Point(28, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 29);
            this.panel1.TabIndex = 42;
            // 
            // STC_Sabado
            // 
            this.STC_Sabado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Sabado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.STC_Sabado.ForeColor = System.Drawing.Color.Black;
            this.STC_Sabado.Location = new System.Drawing.Point(828, 0);
            this.STC_Sabado.Name = "STC_Sabado";
            this.STC_Sabado.Size = new System.Drawing.Size(138, 29);
            this.STC_Sabado.TabIndex = 49;
            this.STC_Sabado.Text = "Sábado";
            this.STC_Sabado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STC_Viernes
            // 
            this.STC_Viernes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Viernes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.STC_Viernes.ForeColor = System.Drawing.Color.Black;
            this.STC_Viernes.Location = new System.Drawing.Point(690, 0);
            this.STC_Viernes.Name = "STC_Viernes";
            this.STC_Viernes.Size = new System.Drawing.Size(138, 29);
            this.STC_Viernes.TabIndex = 48;
            this.STC_Viernes.Text = "Viernes";
            this.STC_Viernes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STC_Jueves
            // 
            this.STC_Jueves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Jueves.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.STC_Jueves.ForeColor = System.Drawing.Color.Black;
            this.STC_Jueves.Location = new System.Drawing.Point(552, 0);
            this.STC_Jueves.Name = "STC_Jueves";
            this.STC_Jueves.Size = new System.Drawing.Size(138, 29);
            this.STC_Jueves.TabIndex = 47;
            this.STC_Jueves.Text = "Jueves";
            this.STC_Jueves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STC_Miercoles
            // 
            this.STC_Miercoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Miercoles.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.STC_Miercoles.ForeColor = System.Drawing.Color.Black;
            this.STC_Miercoles.Location = new System.Drawing.Point(414, 0);
            this.STC_Miercoles.Name = "STC_Miercoles";
            this.STC_Miercoles.Size = new System.Drawing.Size(138, 29);
            this.STC_Miercoles.TabIndex = 46;
            this.STC_Miercoles.Text = "Miércoles";
            this.STC_Miercoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STC_Martes
            // 
            this.STC_Martes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Martes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.STC_Martes.ForeColor = System.Drawing.Color.Black;
            this.STC_Martes.Location = new System.Drawing.Point(276, 0);
            this.STC_Martes.Name = "STC_Martes";
            this.STC_Martes.Size = new System.Drawing.Size(138, 29);
            this.STC_Martes.TabIndex = 45;
            this.STC_Martes.Text = "Martes";
            this.STC_Martes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STC_Lunes
            // 
            this.STC_Lunes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Lunes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.STC_Lunes.ForeColor = System.Drawing.Color.Black;
            this.STC_Lunes.Location = new System.Drawing.Point(138, 0);
            this.STC_Lunes.Name = "STC_Lunes";
            this.STC_Lunes.Size = new System.Drawing.Size(138, 29);
            this.STC_Lunes.TabIndex = 44;
            this.STC_Lunes.Text = "Lunes";
            this.STC_Lunes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STC_Domingo
            // 
            this.STC_Domingo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Domingo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.STC_Domingo.ForeColor = System.Drawing.Color.Black;
            this.STC_Domingo.Location = new System.Drawing.Point(0, 0);
            this.STC_Domingo.Name = "STC_Domingo";
            this.STC_Domingo.Size = new System.Drawing.Size(138, 29);
            this.STC_Domingo.TabIndex = 43;
            this.STC_Domingo.Text = "Domingo";
            this.STC_Domingo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu_ModEli
            // 
            this.Menu_ModEli.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOp_Modificar,
            this.recetasToolStripMenuItem,
            this.MenuOp_Eliminar});
            this.Menu_ModEli.Name = "Menu_General";
            this.Menu_ModEli.Size = new System.Drawing.Size(126, 70);
            // 
            // MenuOp_Modificar
            // 
            this.MenuOp_Modificar.Name = "MenuOp_Modificar";
            this.MenuOp_Modificar.Size = new System.Drawing.Size(125, 22);
            this.MenuOp_Modificar.Text = "Modificar";
            this.MenuOp_Modificar.Click += new System.EventHandler(this.MenuOp_Modificar_Click);
            // 
            // recetasToolStripMenuItem
            // 
            this.recetasToolStripMenuItem.Name = "recetasToolStripMenuItem";
            this.recetasToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.recetasToolStripMenuItem.Text = "Recetas";
            this.recetasToolStripMenuItem.Click += new System.EventHandler(this.recetasToolStripMenuItem_Click);
            // 
            // MenuOp_Eliminar
            // 
            this.MenuOp_Eliminar.Name = "MenuOp_Eliminar";
            this.MenuOp_Eliminar.Size = new System.Drawing.Size(125, 22);
            this.MenuOp_Eliminar.Text = "Eliminar";
            this.MenuOp_Eliminar.Click += new System.EventHandler(this.MenuOp_Eliminar_Click);
            // 
            // WIN_CAT_Citas_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PANEL_Flechas);
            this.Controls.Add(this.LAYOUT_Cuerpo);
            this.Controls.Add(this.PANEL_Mes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WIN_CAT_Citas_T";
            this.Load += new System.EventHandler(this.WIN_CAT_Citas_T_Load);
            this.Controls.SetChildIndex(this.PANEL_Mes, 0);
            this.Controls.SetChildIndex(this.LAYOUT_Cuerpo, 0);
            this.Controls.SetChildIndex(this.PANEL_Flechas, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.PANEL_Mes.ResumeLayout(false);
            this.PANEL_Mes.PerformLayout();
            this.PANEL_Flechas.ResumeLayout(false);
            this.LAYOUT_Cuerpo.ResumeLayout(false);
            this.PANEL_CuadroDia.ResumeLayout(false);
            this.PANEL_CuadroDia.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Menu_ModEli.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PANEL_Mes;
        private System.Windows.Forms.Panel PANEL_Flechas;
        private System.Windows.Forms.Label STC_MesAño;
        private System.Windows.Forms.Button BTN_Adelante;
        private System.Windows.Forms.Button BTN_Atras;
        private System.Windows.Forms.FlowLayoutPanel LAYOUT_Cuerpo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label STC_Domingo;
        private System.Windows.Forms.Label STC_Lunes;
        private System.Windows.Forms.FlowLayoutPanel PANEL_CuadroDia;
        private System.Windows.Forms.Label STC_Sabado;
        private System.Windows.Forms.Label STC_Viernes;
        private System.Windows.Forms.Label STC_Jueves;
        private System.Windows.Forms.Label STC_Miercoles;
        private System.Windows.Forms.Label STC_Martes;
        private System.Windows.Forms.Label STC_NumDia;
        private System.Windows.Forms.LinkLabel LSTC_Appointment;
        private System.Windows.Forms.Button BTN_FechaActual;
        private System.Windows.Forms.ContextMenuStrip Menu_ModEli;
        private System.Windows.Forms.ToolStripMenuItem MenuOp_Modificar;
        private System.Windows.Forms.ToolStripMenuItem MenuOp_Eliminar;
        private System.Windows.Forms.ToolStripMenuItem recetasToolStripMenuItem;
    }
}