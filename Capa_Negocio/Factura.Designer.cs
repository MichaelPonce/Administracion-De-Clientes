namespace Capa_Negocio
{
    partial class Factura
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
            this.spReporte_fctTableAdapter1 = new Capa_Negocio.dsPrinicipalTableAdapters.spReporte_fctTableAdapter();
            this.spReporte_fctTableAdapter2 = new Capa_Negocio.dsPrinicipalTableAdapters.spReporte_fctTableAdapter();
            this.spReporte_fctTableAdapter3 = new Capa_Negocio.dsPrinicipalTableAdapters.spReporte_fctTableAdapter();
            this.spReporte_fctTableAdapter4 = new Capa_Negocio.dsPrinicipalTableAdapters.spReporte_fctTableAdapter();
            this.SuspendLayout();
            // 
            // spReporte_fctTableAdapter1
            // 
            this.spReporte_fctTableAdapter1.ClearBeforeFill = true;
            // 
            // spReporte_fctTableAdapter2
            // 
            this.spReporte_fctTableAdapter2.ClearBeforeFill = true;
            // 
            // spReporte_fctTableAdapter3
            // 
            this.spReporte_fctTableAdapter3.ClearBeforeFill = true;
            // 
            // spReporte_fctTableAdapter4
            // 
            this.spReporte_fctTableAdapter4.ClearBeforeFill = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Factura";
            this.Text = "Factura";
            this.ResumeLayout(false);

        }

        #endregion

        private dsPrinicipalTableAdapters.spReporte_fctTableAdapter spReporte_fctTableAdapter1;
        private dsPrinicipalTableAdapters.spReporte_fctTableAdapter spReporte_fctTableAdapter2;
        private dsPrinicipalTableAdapters.spReporte_fctTableAdapter spReporte_fctTableAdapter3;
        private dsPrinicipalTableAdapters.spReporte_fctTableAdapter spReporte_fctTableAdapter4;
    }
}