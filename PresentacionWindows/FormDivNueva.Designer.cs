namespace PresentacionWindows
{
    partial class FormDivNueva
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
            this.lbNomDiv = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.btAñadir = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNomDiv
            // 
            this.lbNomDiv.AutoSize = true;
            this.lbNomDiv.Location = new System.Drawing.Point(38, 94);
            this.lbNomDiv.Name = "lbNomDiv";
            this.lbNomDiv.Size = new System.Drawing.Size(56, 16);
            this.lbNomDiv.TabIndex = 0;
            this.lbNomDiv.Text = "Nombre";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(234, 94);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(147, 16);
            this.lbValor.TabIndex = 1;
            this.lbValor.Text = "Valor (respecto al euro)";
            this.lbValor.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(41, 129);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 22);
            this.tbNombre.TabIndex = 2;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(237, 129);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 22);
            this.tbValor.TabIndex = 3;
            // 
            // btAñadir
            // 
            this.btAñadir.Location = new System.Drawing.Point(41, 298);
            this.btAñadir.Name = "btAñadir";
            this.btAñadir.Size = new System.Drawing.Size(97, 36);
            this.btAñadir.TabIndex = 4;
            this.btAñadir.Text = "Añadir";
            this.btAñadir.UseVisualStyleBackColor = true;
            this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(254, 298);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(97, 36);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // FormDivNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 389);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAñadir);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbNomDiv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDivNueva";
            this.Text = "Añadir nueva divisa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomDiv;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Button btAñadir;
        private System.Windows.Forms.Button btSalir;
    }
}