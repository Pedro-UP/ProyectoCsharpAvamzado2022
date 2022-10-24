namespace ProyectoCsharpAvamzado2022
{
    partial class MantenimientoProducto
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
            this.lblidP = new System.Windows.Forms.Label();
            this.lblNP = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.txtPrec = new MiLibreria.ErrortxtBox();
            this.txtNomP = new MiLibreria.ErrortxtBox();
            this.txtIdP = new MiLibreria.ErrortxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblidP
            // 
            this.lblidP.AutoSize = true;
            this.lblidP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidP.Location = new System.Drawing.Point(78, 119);
            this.lblidP.Name = "lblidP";
            this.lblidP.Size = new System.Drawing.Size(93, 16);
            this.lblidP.TabIndex = 5;
            this.lblidP.Text = "ID Producto:";
            // 
            // lblNP
            // 
            this.lblNP.AutoSize = true;
            this.lblNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNP.Location = new System.Drawing.Point(78, 172);
            this.lblNP.Name = "lblNP";
            this.lblNP.Size = new System.Drawing.Size(67, 16);
            this.lblNP.TabIndex = 9;
            this.lblNP.Text = "Nombre:";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP.Location = new System.Drawing.Point(78, 223);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(57, 16);
            this.lblP.TabIndex = 10;
            this.lblP.Text = "Precio:";
            this.lblP.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPrec
            // 
            this.txtPrec.Location = new System.Drawing.Point(202, 223);
            this.txtPrec.Name = "txtPrec";
            this.txtPrec.Size = new System.Drawing.Size(164, 20);
            this.txtPrec.SoloNumeros = false;
            this.txtPrec.TabIndex = 13;
            this.txtPrec.Validar = true;
            // 
            // txtNomP
            // 
            this.txtNomP.Location = new System.Drawing.Point(202, 172);
            this.txtNomP.Name = "txtNomP";
            this.txtNomP.Size = new System.Drawing.Size(164, 20);
            this.txtNomP.SoloNumeros = false;
            this.txtNomP.TabIndex = 12;
            this.txtNomP.Validar = true;
            // 
            // txtIdP
            // 
            this.txtIdP.Location = new System.Drawing.Point(202, 119);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(164, 20);
            this.txtIdP.SoloNumeros = true;
            this.txtIdP.TabIndex = 11;
            this.txtIdP.Validar = true;
            this.txtIdP.TextChanged += new System.EventHandler(this.txtIdP_TextChanged);
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 465);
            this.Controls.Add(this.txtPrec);
            this.Controls.Add(this.txtNomP);
            this.Controls.Add(this.txtIdP);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblNP);
            this.Controls.Add(this.lblidP);
            this.Name = "MantenimientoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoProducto";
            this.Controls.SetChildIndex(this.lblidP, 0);
            this.Controls.SetChildIndex(this.lblNP, 0);
            this.Controls.SetChildIndex(this.lblP, 0);
            this.Controls.SetChildIndex(this.txtIdP, 0);
            this.Controls.SetChildIndex(this.txtNomP, 0);
            this.Controls.SetChildIndex(this.txtPrec, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidP;
        private System.Windows.Forms.Label lblNP;
        private System.Windows.Forms.Label lblP;
        private MiLibreria.ErrortxtBox txtIdP;
        private MiLibreria.ErrortxtBox txtNomP;
        private MiLibreria.ErrortxtBox txtPrec;
    }
}