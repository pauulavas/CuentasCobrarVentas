namespace MDI_Ventas
{
    partial class ConsultaDevoluciones
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
            this.cU_DevolucionesConsulta1 = new Facturacion.CU_DevolucionesConsulta();
            this.SuspendLayout();
            // 
            // cU_DevolucionesConsulta1
            // 
            this.cU_DevolucionesConsulta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.cU_DevolucionesConsulta1.Location = new System.Drawing.Point(3, 2);
            this.cU_DevolucionesConsulta1.Name = "cU_DevolucionesConsulta1";
            this.cU_DevolucionesConsulta1.Size = new System.Drawing.Size(1100, 523);
            this.cU_DevolucionesConsulta1.TabIndex = 0;
            this.cU_DevolucionesConsulta1.Load += new System.EventHandler(this.CU_DevolucionesConsulta1_Load);
            // 
            // ConsultaDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 526);
            this.Controls.Add(this.cU_DevolucionesConsulta1);
            this.Name = "ConsultaDevoluciones";
            this.Text = "ConsultaDevoluciones";
            this.ResumeLayout(false);

        }

        #endregion

        private Facturacion.CU_DevolucionesConsulta cU_DevolucionesConsulta1;
    }
}