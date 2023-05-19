namespace pryPonceDeLeonGestion
{
    partial class frmMostrar
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
            this.btnVolverMostrar = new System.Windows.Forms.Button();
            this.lstActividades = new System.Windows.Forms.ListBox();
            this.lblActividadMostrar = new System.Windows.Forms.Label();
            this.cboActividadMostrar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVolverMostrar
            // 
            this.btnVolverMostrar.Location = new System.Drawing.Point(111, 388);
            this.btnVolverMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolverMostrar.Name = "btnVolverMostrar";
            this.btnVolverMostrar.Size = new System.Drawing.Size(112, 37);
            this.btnVolverMostrar.TabIndex = 7;
            this.btnVolverMostrar.Text = "Volver";
            this.btnVolverMostrar.UseVisualStyleBackColor = true;
            // 
            // lstActividades
            // 
            this.lstActividades.FormattingEnabled = true;
            this.lstActividades.ItemHeight = 21;
            this.lstActividades.Location = new System.Drawing.Point(22, 71);
            this.lstActividades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.Size = new System.Drawing.Size(287, 298);
            this.lstActividades.TabIndex = 6;
            // 
            // lblActividadMostrar
            // 
            this.lblActividadMostrar.AutoSize = true;
            this.lblActividadMostrar.Location = new System.Drawing.Point(31, 25);
            this.lblActividadMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividadMostrar.Name = "lblActividadMostrar";
            this.lblActividadMostrar.Size = new System.Drawing.Size(74, 21);
            this.lblActividadMostrar.TabIndex = 5;
            this.lblActividadMostrar.Text = "Actividad";
            // 
            // cboActividadMostrar
            // 
            this.cboActividadMostrar.FormattingEnabled = true;
            this.cboActividadMostrar.Location = new System.Drawing.Point(129, 17);
            this.cboActividadMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboActividadMostrar.Name = "cboActividadMostrar";
            this.cboActividadMostrar.Size = new System.Drawing.Size(180, 29);
            this.cboActividadMostrar.TabIndex = 4;
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 438);
            this.Controls.Add(this.btnVolverMostrar);
            this.Controls.Add(this.lstActividades);
            this.Controls.Add(this.lblActividadMostrar);
            this.Controls.Add(this.cboActividadMostrar);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Actividad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverMostrar;
        private System.Windows.Forms.ListBox lstActividades;
        private System.Windows.Forms.Label lblActividadMostrar;
        private System.Windows.Forms.ComboBox cboActividadMostrar;
    }
}