namespace pryPonceDeLeonGestion
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.btnCancelarRegistro = new System.Windows.Forms.Button();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.btnRegistrarRegistro = new System.Windows.Forms.Button();
            this.gboxTareas = new System.Windows.Forms.GroupBox();
            this.optNoReunion = new System.Windows.Forms.RadioButton();
            this.optSiReunion = new System.Windows.Forms.RadioButton();
            this.gboxReunion = new System.Windows.Forms.GroupBox();
            this.lblDetalleDeActividad = new System.Windows.Forms.Label();
            this.cboTipoDeActividad = new System.Windows.Forms.ComboBox();
            this.dtpFechaDeRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblTipoDeActividad = new System.Windows.Forms.Label();
            this.txtDetalleActividad = new System.Windows.Forms.TextBox();
            this.lblFechaDeRegistro = new System.Windows.Forms.Label();
            this.gboxTareas.SuspendLayout();
            this.gboxReunion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarRegistro
            // 
            this.btnCancelarRegistro.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelarRegistro.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRegistro.Location = new System.Drawing.Point(127, 397);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(102, 31);
            this.btnCancelarRegistro.TabIndex = 21;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = false;
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnCancelarRegistro_Click);
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(178, 56);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(78, 25);
            this.chkDebate.TabIndex = 3;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Location = new System.Drawing.Point(27, 56);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(128, 25);
            this.chkNotasReunion.TabIndex = 2;
            this.chkNotasReunion.Text = "Notas reunión";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(178, 33);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(120, 25);
            this.chkInvestigacion.TabIndex = 1;
            this.chkInvestigacion.Text = "Investigación";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Location = new System.Drawing.Point(27, 33);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(109, 25);
            this.chkRepositorio.TabIndex = 0;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarRegistro
            // 
            this.btnRegistrarRegistro.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRegistrarRegistro.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarRegistro.Location = new System.Drawing.Point(240, 397);
            this.btnRegistrarRegistro.Name = "btnRegistrarRegistro";
            this.btnRegistrarRegistro.Size = new System.Drawing.Size(94, 31);
            this.btnRegistrarRegistro.TabIndex = 22;
            this.btnRegistrarRegistro.Text = "Registar";
            this.btnRegistrarRegistro.UseVisualStyleBackColor = false;
            this.btnRegistrarRegistro.Click += new System.EventHandler(this.btnRegistrarRegistro_Click);
            // 
            // gboxTareas
            // 
            this.gboxTareas.Controls.Add(this.chkDebate);
            this.gboxTareas.Controls.Add(this.chkNotasReunion);
            this.gboxTareas.Controls.Add(this.chkInvestigacion);
            this.gboxTareas.Controls.Add(this.chkRepositorio);
            this.gboxTareas.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxTareas.Location = new System.Drawing.Point(28, 271);
            this.gboxTareas.Name = "gboxTareas";
            this.gboxTareas.Size = new System.Drawing.Size(306, 106);
            this.gboxTareas.TabIndex = 20;
            this.gboxTareas.TabStop = false;
            this.gboxTareas.Text = "Tareas";
            // 
            // optNoReunion
            // 
            this.optNoReunion.AutoSize = true;
            this.optNoReunion.Location = new System.Drawing.Point(27, 60);
            this.optNoReunion.Name = "optNoReunion";
            this.optNoReunion.Size = new System.Drawing.Size(49, 25);
            this.optNoReunion.TabIndex = 1;
            this.optNoReunion.TabStop = true;
            this.optNoReunion.Text = "No";
            this.optNoReunion.UseVisualStyleBackColor = true;
            // 
            // optSiReunion
            // 
            this.optSiReunion.AutoSize = true;
            this.optSiReunion.Location = new System.Drawing.Point(27, 27);
            this.optSiReunion.Name = "optSiReunion";
            this.optSiReunion.Size = new System.Drawing.Size(41, 25);
            this.optSiReunion.TabIndex = 0;
            this.optSiReunion.TabStop = true;
            this.optSiReunion.Text = "Si";
            this.optSiReunion.UseVisualStyleBackColor = true;
            // 
            // gboxReunion
            // 
            this.gboxReunion.Controls.Add(this.optNoReunion);
            this.gboxReunion.Controls.Add(this.optSiReunion);
            this.gboxReunion.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxReunion.Location = new System.Drawing.Point(28, 164);
            this.gboxReunion.Name = "gboxReunion";
            this.gboxReunion.Size = new System.Drawing.Size(306, 100);
            this.gboxReunion.TabIndex = 19;
            this.gboxReunion.TabStop = false;
            this.gboxReunion.Text = "Reunión";
            // 
            // lblDetalleDeActividad
            // 
            this.lblDetalleDeActividad.AutoSize = true;
            this.lblDetalleDeActividad.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleDeActividad.Location = new System.Drawing.Point(24, 114);
            this.lblDetalleDeActividad.Name = "lblDetalleDeActividad";
            this.lblDetalleDeActividad.Size = new System.Drawing.Size(124, 21);
            this.lblDetalleDeActividad.TabIndex = 18;
            this.lblDetalleDeActividad.Text = "Detalle actividad";
            // 
            // cboTipoDeActividad
            // 
            this.cboTipoDeActividad.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDeActividad.FormattingEnabled = true;
            this.cboTipoDeActividad.Items.AddRange(new object[] {
            "Relevamiento",
            "Diagnóstico",
            "Análisis",
            "Diagrama de base de datos",
            "Programación"});
            this.cboTipoDeActividad.Location = new System.Drawing.Point(174, 59);
            this.cboTipoDeActividad.Name = "cboTipoDeActividad";
            this.cboTipoDeActividad.Size = new System.Drawing.Size(160, 29);
            this.cboTipoDeActividad.TabIndex = 17;
            // 
            // dtpFechaDeRegistro
            // 
            this.dtpFechaDeRegistro.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDeRegistro.Location = new System.Drawing.Point(174, 16);
            this.dtpFechaDeRegistro.Name = "dtpFechaDeRegistro";
            this.dtpFechaDeRegistro.Size = new System.Drawing.Size(160, 28);
            this.dtpFechaDeRegistro.TabIndex = 15;
            // 
            // lblTipoDeActividad
            // 
            this.lblTipoDeActividad.AutoSize = true;
            this.lblTipoDeActividad.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeActividad.Location = new System.Drawing.Point(24, 67);
            this.lblTipoDeActividad.Name = "lblTipoDeActividad";
            this.lblTipoDeActividad.Size = new System.Drawing.Size(127, 21);
            this.lblTipoDeActividad.TabIndex = 14;
            this.lblTipoDeActividad.Text = "Tipo de actividad";
            // 
            // txtDetalleActividad
            // 
            this.txtDetalleActividad.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleActividad.Location = new System.Drawing.Point(174, 111);
            this.txtDetalleActividad.Name = "txtDetalleActividad";
            this.txtDetalleActividad.Size = new System.Drawing.Size(160, 28);
            this.txtDetalleActividad.TabIndex = 13;
            // 
            // lblFechaDeRegistro
            // 
            this.lblFechaDeRegistro.AutoSize = true;
            this.lblFechaDeRegistro.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeRegistro.Location = new System.Drawing.Point(24, 22);
            this.lblFechaDeRegistro.Name = "lblFechaDeRegistro";
            this.lblFechaDeRegistro.Size = new System.Drawing.Size(129, 21);
            this.lblFechaDeRegistro.TabIndex = 12;
            this.lblFechaDeRegistro.Text = "Fecha de registro";
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 451);
            this.Controls.Add(this.btnCancelarRegistro);
            this.Controls.Add(this.btnRegistrarRegistro);
            this.Controls.Add(this.gboxTareas);
            this.Controls.Add(this.gboxReunion);
            this.Controls.Add(this.lblDetalleDeActividad);
            this.Controls.Add(this.cboTipoDeActividad);
            this.Controls.Add(this.dtpFechaDeRegistro);
            this.Controls.Add(this.lblTipoDeActividad);
            this.Controls.Add(this.txtDetalleActividad);
            this.Controls.Add(this.lblFechaDeRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.gboxTareas.ResumeLayout(false);
            this.gboxTareas.PerformLayout();
            this.gboxReunion.ResumeLayout(false);
            this.gboxReunion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarRegistro;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkNotasReunion;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkRepositorio;
        private System.Windows.Forms.Button btnRegistrarRegistro;
        private System.Windows.Forms.GroupBox gboxTareas;
        private System.Windows.Forms.RadioButton optNoReunion;
        private System.Windows.Forms.RadioButton optSiReunion;
        private System.Windows.Forms.GroupBox gboxReunion;
        private System.Windows.Forms.Label lblDetalleDeActividad;
        private System.Windows.Forms.ComboBox cboTipoDeActividad;
        private System.Windows.Forms.DateTimePicker dtpFechaDeRegistro;
        private System.Windows.Forms.Label lblTipoDeActividad;
        private System.Windows.Forms.TextBox txtDetalleActividad;
        private System.Windows.Forms.Label lblFechaDeRegistro;
    }
}