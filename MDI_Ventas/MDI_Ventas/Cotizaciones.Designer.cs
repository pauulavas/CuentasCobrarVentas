namespace MDI_Ventas
{
    partial class Cotizaciones
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
            this.cU_Cotizacion1 = new Facturacion.CU_Cotizacion();
            this.SuspendLayout();
            // 
            // cU_Cotizacion1
            // 
            this.cU_Cotizacion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.cU_Cotizacion1.Location = new System.Drawing.Point(2, 1);
            this.cU_Cotizacion1.Name = "cU_Cotizacion1";
            this.cU_Cotizacion1.Size = new System.Drawing.Size(1080, 670);
            this.cU_Cotizacion1.TabIndex = 0;
            // 
            // Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 670);
            this.Controls.Add(this.cU_Cotizacion1);
            this.Name = "Cotizaciones";
            this.Text = "Cotizaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private Facturacion.CU_Cotizacion cU_Cotizacion1;
    }
}