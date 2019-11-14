namespace MDI_Ventas
{
    partial class Facturas
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
            this.cU_Facturacion1 = new Facturacion.CU_Facturacion();
            this.SuspendLayout();
            // 
            // cU_Facturacion1
            // 
            this.cU_Facturacion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.cU_Facturacion1.Location = new System.Drawing.Point(0, 0);
            this.cU_Facturacion1.Name = "cU_Facturacion1";
            this.cU_Facturacion1.Size = new System.Drawing.Size(1080, 700);
            this.cU_Facturacion1.TabIndex = 0;
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 706);
            this.Controls.Add(this.cU_Facturacion1);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.ResumeLayout(false);

        }

        #endregion

        private Facturacion.CU_Facturacion cU_Facturacion1;
    }
}