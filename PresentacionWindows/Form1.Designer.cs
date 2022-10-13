namespace PresentacionWindows
{
    partial class FormConv
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbDivOrig = new System.Windows.Forms.Label();
            this.lbDivDest = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.cbDivOrig = new System.Windows.Forms.ComboBox();
            this.cbDivDest = new System.Windows.Forms.ComboBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(62, 80);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 13);
            this.lbCantidad.TabIndex = 0;
            this.lbCantidad.Text = "Cantidad";
            this.lbCantidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDivOrig
            // 
            this.lbDivOrig.AutoSize = true;
            this.lbDivOrig.Location = new System.Drawing.Point(271, 80);
            this.lbDivOrig.Name = "lbDivOrig";
            this.lbDivOrig.Size = new System.Drawing.Size(71, 13);
            this.lbDivOrig.TabIndex = 1;
            this.lbDivOrig.Text = "Divisa origen:";
            // 
            // lbDivDest
            // 
            this.lbDivDest.AutoSize = true;
            this.lbDivDest.Location = new System.Drawing.Point(493, 80);
            this.lbDivDest.Name = "lbDivDest";
            this.lbDivDest.Size = new System.Drawing.Size(76, 13);
            this.lbDivDest.TabIndex = 2;
            this.lbDivDest.Text = "Divisa destino:";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(65, 373);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(98, 32);
            this.btCalcular.TabIndex = 3;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(65, 105);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(121, 20);
            this.tbCantidad.TabIndex = 4;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(274, 385);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(127, 20);
            this.tbResultado.TabIndex = 5;
            this.tbResultado.TextChanged += new System.EventHandler(this.tbResultado_TextChanged);
            // 
            // cbDivOrig
            // 
            this.cbDivOrig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDivOrig.FormattingEnabled = true;
            this.cbDivOrig.Location = new System.Drawing.Point(274, 105);
            this.cbDivOrig.Name = "cbDivOrig";
            this.cbDivOrig.Size = new System.Drawing.Size(121, 21);
            this.cbDivOrig.TabIndex = 6;
            this.cbDivOrig.SelectedIndexChanged += new System.EventHandler(this.cbDivOrig_SelectedIndexChanged);
            // 
            // cbDivDest
            // 
            this.cbDivDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDivDest.FormattingEnabled = true;
            this.cbDivDest.Location = new System.Drawing.Point(496, 105);
            this.cbDivDest.Name = "cbDivDest";
            this.cbDivDest.Size = new System.Drawing.Size(121, 21);
            this.cbDivDest.TabIndex = 7;
            this.cbDivDest.SelectedIndexChanged += new System.EventHandler(this.cbDivDest_SelectedIndexChanged);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(496, 373);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(98, 32);
            this.btSalir.TabIndex = 8;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // FormConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.cbDivDest);
            this.Controls.Add(this.cbDivOrig);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbDivDest);
            this.Controls.Add(this.lbDivOrig);
            this.Controls.Add(this.lbCantidad);
            this.Name = "FormConv";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbDivOrig;
        private System.Windows.Forms.Label lbDivDest;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.ComboBox cbDivOrig;
        private System.Windows.Forms.ComboBox cbDivDest;
        private System.Windows.Forms.Button btSalir;
    }
}

