namespace DenTech
{
    partial class WIN_GLO_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_GLO_Principal));
            this.BTN_Citas = new System.Windows.Forms.Button();
            this.BTN_Pacientes = new System.Windows.Forms.Button();
            this.BTN_Inventario = new System.Windows.Forms.Button();
            this.BTN_Empleados = new System.Windows.Forms.Button();
            this.TIMER_Hora = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.STC_Dia = new System.Windows.Forms.Label();
            this.STC_Hora = new System.Windows.Forms.Label();
            this.Panel_General = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Servicios = new System.Windows.Forms.Button();
            this.BTN_Expediente = new System.Windows.Forms.Button();
            this.PNL_Ventanas = new DenTech.FormsPanel();
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.Panel_General.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Citas
            // 
            this.BTN_Citas.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BTN_Citas, "BTN_Citas");
            this.BTN_Citas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Citas.FlatAppearance.BorderSize = 2;
            this.BTN_Citas.Name = "BTN_Citas";
            this.BTN_Citas.UseVisualStyleBackColor = false;
            this.BTN_Citas.Click += new System.EventHandler(this.BTN_Citas_Click);
            // 
            // BTN_Pacientes
            // 
            this.BTN_Pacientes.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BTN_Pacientes, "BTN_Pacientes");
            this.BTN_Pacientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Pacientes.FlatAppearance.BorderSize = 2;
            this.BTN_Pacientes.Name = "BTN_Pacientes";
            this.BTN_Pacientes.UseVisualStyleBackColor = false;
            this.BTN_Pacientes.Click += new System.EventHandler(this.BTN_Pacientes_Click);
            // 
            // BTN_Inventario
            // 
            this.BTN_Inventario.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BTN_Inventario, "BTN_Inventario");
            this.BTN_Inventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Inventario.FlatAppearance.BorderSize = 2;
            this.BTN_Inventario.Name = "BTN_Inventario";
            this.BTN_Inventario.UseVisualStyleBackColor = false;
            this.BTN_Inventario.Click += new System.EventHandler(this.BTN_Inventario_Click);
            // 
            // BTN_Empleados
            // 
            this.BTN_Empleados.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BTN_Empleados, "BTN_Empleados");
            this.BTN_Empleados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Empleados.FlatAppearance.BorderSize = 2;
            this.BTN_Empleados.Name = "BTN_Empleados";
            this.BTN_Empleados.UseVisualStyleBackColor = false;
            this.BTN_Empleados.Click += new System.EventHandler(this.BTN_Empleados_Click);
            // 
            // TIMER_Hora
            // 
            this.TIMER_Hora.Enabled = true;
            this.TIMER_Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.STC_Dia);
            this.panel2.Controls.Add(this.STC_Hora);
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // STC_Dia
            // 
            resources.ApplyResources(this.STC_Dia, "STC_Dia");
            this.STC_Dia.ForeColor = System.Drawing.Color.White;
            this.STC_Dia.Name = "STC_Dia";
            // 
            // STC_Hora
            // 
            resources.ApplyResources(this.STC_Hora, "STC_Hora");
            this.STC_Hora.ForeColor = System.Drawing.Color.White;
            this.STC_Hora.Name = "STC_Hora";
            // 
            // Panel_General
            // 
            resources.ApplyResources(this.Panel_General, "Panel_General");
            this.Panel_General.Controls.Add(this.BTN_Empleados);
            this.Panel_General.Controls.Add(this.BTN_Pacientes);
            this.Panel_General.Controls.Add(this.BTN_Citas);
            this.Panel_General.Controls.Add(this.BTN_Inventario);
            this.Panel_General.Controls.Add(this.BTN_Servicios);
            this.Panel_General.Controls.Add(this.BTN_Expediente);
            this.Panel_General.Controls.Add(this.BTN_Salir);
            this.Panel_General.Name = "Panel_General";
            // 
            // BTN_Servicios
            // 
            this.BTN_Servicios.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BTN_Servicios, "BTN_Servicios");
            this.BTN_Servicios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Servicios.FlatAppearance.BorderSize = 2;
            this.BTN_Servicios.Name = "BTN_Servicios";
            this.BTN_Servicios.UseVisualStyleBackColor = false;
            this.BTN_Servicios.Click += new System.EventHandler(this.BTN_Servicios_Click);
            // 
            // BTN_Expediente
            // 
            this.BTN_Expediente.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BTN_Expediente, "BTN_Expediente");
            this.BTN_Expediente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Expediente.FlatAppearance.BorderSize = 2;
            this.BTN_Expediente.Name = "BTN_Expediente";
            this.BTN_Expediente.UseVisualStyleBackColor = false;
            this.BTN_Expediente.Click += new System.EventHandler(this.BTN_Expediente_Click);
            // 
            // PNL_Ventanas
            // 
            this.PNL_Ventanas.ActiveMDIWnd = this;
            resources.ApplyResources(this.PNL_Ventanas, "PNL_Ventanas");
            this.PNL_Ventanas.Name = "PNL_Ventanas";
            this.PNL_Ventanas.Resize += new System.EventHandler(this.PNL_Ventanas_Resize);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BTN_Salir, "BTN_Salir");
            this.BTN_Salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Salir.FlatAppearance.BorderSize = 2;
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.UseVisualStyleBackColor = false;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // WIN_GLO_Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Cerrar = true;
            this.Controls.Add(this.PNL_Ventanas);
            this.Controls.Add(this.Panel_General);
            this.Controls.Add(this.panel2);
            this.Name = "WIN_GLO_Principal";
            this.Load += new System.EventHandler(this.WIN_GLO_Principal_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.Panel_General, 0);
            this.Controls.SetChildIndex(this.PNL_Ventanas, 0);
            this.panel2.ResumeLayout(false);
            this.Panel_General.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_Citas;
        private System.Windows.Forms.Button BTN_Pacientes;
        private System.Windows.Forms.Button BTN_Inventario;
        private System.Windows.Forms.Button BTN_Empleados;
        private System.Windows.Forms.Timer TIMER_Hora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label STC_Hora;
        private System.Windows.Forms.Label STC_Dia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel Panel_General;
        public FormsPanel PNL_Ventanas;
        private System.Windows.Forms.Button BTN_Servicios;
        private System.Windows.Forms.Button BTN_Expediente;
        private System.Windows.Forms.Button BTN_Salir;
    }
}