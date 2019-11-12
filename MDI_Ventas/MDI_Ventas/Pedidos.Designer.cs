namespace MDI_Ventas
{
    partial class Pedidos
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
            this.cU_Pedido1 = new Facturacion.CU_Pedido();
            this.SuspendLayout();
            // 
            // cU_Pedido1
            // 
            this.cU_Pedido1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.cU_Pedido1.Location = new System.Drawing.Point(3, 1);
            this.cU_Pedido1.Name = "cU_Pedido1";
            this.cU_Pedido1.Size = new System.Drawing.Size(1080, 700);
            this.cU_Pedido1.TabIndex = 0;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 701);
            this.Controls.Add(this.cU_Pedido1);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.ResumeLayout(false);

        }

        #endregion

        private Facturacion.CU_Pedido cU_Pedido1;
    }
}