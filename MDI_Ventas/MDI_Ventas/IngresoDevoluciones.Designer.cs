namespace MDI_Ventas
{
    partial class IngresoDevoluciones
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
            this.cU_Devoluciones1 = new Facturacion.CU_Devoluciones();
            this.SuspendLayout();
            // 
            // cU_Devoluciones1
            // 
            this.cU_Devoluciones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.cU_Devoluciones1.Location = new System.Drawing.Point(1, 0);
            this.cU_Devoluciones1.Name = "cU_Devoluciones1";
            this.cU_Devoluciones1.Size = new System.Drawing.Size(1080, 550);
            this.cU_Devoluciones1.TabIndex = 0;
            // 
            // IngresoDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 706);
            this.Controls.Add(this.cU_Devoluciones1);
            this.Name = "IngresoDevoluciones";
            this.Text = "IngresoDevoluciones";
            this.ResumeLayout(false);

        }

        #endregion

        private Facturacion.CU_Devoluciones cU_Devoluciones1;
    }
}