namespace ProyectoCsharpAvamzado2022
{
    partial class MantenimientoCliente
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
            this.lblAp = new System.Windows.Forms.Label();
            this.lblNC = new System.Windows.Forms.Label();
            this.lblidC = new System.Windows.Forms.Label();
            this.txtIdClie = new MiLibreria.ErrortxtBox();
            this.txtNomClie = new MiLibreria.ErrortxtBox();
            this.txtApe = new MiLibreria.ErrortxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(368, 66);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 121);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 172);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(368, 225);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(368, 276);
            // 
            // lblAp
            // 
            this.lblAp.AutoSize = true;
            this.lblAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAp.Location = new System.Drawing.Point(51, 225);
            this.lblAp.Name = "lblAp";
            this.lblAp.Size = new System.Drawing.Size(70, 16);
            this.lblAp.TabIndex = 16;
            this.lblAp.Text = "Apellido:";
            // 
            // lblNC
            // 
            this.lblNC.AutoSize = true;
            this.lblNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNC.Location = new System.Drawing.Point(51, 174);
            this.lblNC.Name = "lblNC";
            this.lblNC.Size = new System.Drawing.Size(67, 16);
            this.lblNC.TabIndex = 15;
            this.lblNC.Text = "Nombre:";
            // 
            // lblidC
            // 
            this.lblidC.AutoSize = true;
            this.lblidC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidC.Location = new System.Drawing.Point(51, 121);
            this.lblidC.Name = "lblidC";
            this.lblidC.Size = new System.Drawing.Size(79, 16);
            this.lblidC.TabIndex = 11;
            this.lblidC.Text = "ID Cliente:";
            // 
            // txtIdClie
            // 
            this.txtIdClie.Location = new System.Drawing.Point(175, 121);
            this.txtIdClie.Name = "txtIdClie";
            this.txtIdClie.Size = new System.Drawing.Size(150, 20);
            this.txtIdClie.SoloNumeros = false;
            this.txtIdClie.TabIndex = 17;
            this.txtIdClie.Validar = true;
            this.txtIdClie.TextChanged += new System.EventHandler(this.txtIdClie_TextChanged);
            // 
            // txtNomClie
            // 
            this.txtNomClie.Location = new System.Drawing.Point(175, 174);
            this.txtNomClie.Name = "txtNomClie";
            this.txtNomClie.Size = new System.Drawing.Size(150, 20);
            this.txtNomClie.SoloNumeros = false;
            this.txtNomClie.TabIndex = 18;
            this.txtNomClie.Validar = true;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(175, 225);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(150, 20);
            this.txtApe.SoloNumeros = false;
            this.txtApe.TabIndex = 19;
            this.txtApe.Validar = true;
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 437);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtNomClie);
            this.Controls.Add(this.txtIdClie);
            this.Controls.Add(this.lblAp);
            this.Controls.Add(this.lblNC);
            this.Controls.Add(this.lblidC);
            this.Name = "MantenimientoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoCliente";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.lblidC, 0);
            this.Controls.SetChildIndex(this.lblNC, 0);
            this.Controls.SetChildIndex(this.lblAp, 0);
            this.Controls.SetChildIndex(this.txtIdClie, 0);
            this.Controls.SetChildIndex(this.txtNomClie, 0);
            this.Controls.SetChildIndex(this.txtApe, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAp;
        private System.Windows.Forms.Label lblNC;
        private System.Windows.Forms.Label lblidC;
        private MiLibreria.ErrortxtBox txtIdClie;
        private MiLibreria.ErrortxtBox txtNomClie;
        private MiLibreria.ErrortxtBox txtApe;
    }
}