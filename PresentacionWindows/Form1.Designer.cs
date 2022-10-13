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
            this.lbResultado = new System.Windows.Forms.Label();
            this.btVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(83, 98);
            this.lbCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(61, 16);
            this.lbCantidad.TabIndex = 0;
            this.lbCantidad.Text = "Cantidad";
            this.lbCantidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDivOrig
            // 
            this.lbDivOrig.AutoSize = true;
            this.lbDivOrig.Location = new System.Drawing.Point(361, 98);
            this.lbDivOrig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDivOrig.Name = "lbDivOrig";
            this.lbDivOrig.Size = new System.Drawing.Size(86, 16);
            this.lbDivOrig.TabIndex = 1;
            this.lbDivOrig.Text = "Divisa origen";
            // 
            // lbDivDest
            // 
            this.lbDivDest.AutoSize = true;
            this.lbDivDest.Location = new System.Drawing.Point(657, 98);
            this.lbDivDest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDivDest.Name = "lbDivDest";
            this.lbDivDest.Size = new System.Drawing.Size(92, 16);
            this.lbDivDest.TabIndex = 2;
            this.lbDivDest.Text = "Divisa destino";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(88, 233);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(131, 39);
            this.btCalcular.TabIndex = 3;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(87, 129);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(160, 22);
            this.tbCantidad.TabIndex = 4;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(366, 250);
            this.tbResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.Size = new System.Drawing.Size(168, 22);
            this.tbResultado.TabIndex = 5;
            this.tbResultado.TextChanged += new System.EventHandler(this.tbResultado_TextChanged);
            // 
            // cbDivOrig
            // 
            this.cbDivOrig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDivOrig.FormattingEnabled = true;
            this.cbDivOrig.Location = new System.Drawing.Point(365, 129);
            this.cbDivOrig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDivOrig.Name = "cbDivOrig";
            this.cbDivOrig.Size = new System.Drawing.Size(160, 24);
            this.cbDivOrig.TabIndex = 6;
            this.cbDivOrig.SelectedIndexChanged += new System.EventHandler(this.cbDivOrig_SelectedIndexChanged);
            // 
            // cbDivDest
            // 
            this.cbDivDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDivDest.FormattingEnabled = true;
            this.cbDivDest.Location = new System.Drawing.Point(661, 129);
            this.cbDivDest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDivDest.Name = "cbDivDest";
            this.cbDivDest.Size = new System.Drawing.Size(160, 24);
            this.cbDivDest.TabIndex = 7;
            this.cbDivDest.SelectedIndexChanged += new System.EventHandler(this.cbDivDest_SelectedIndexChanged);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(690, 366);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(131, 39);
            this.btSalir.TabIndex = 8;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(363, 218);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(69, 16);
            this.lbResultado.TabIndex = 9;
            this.lbResultado.Text = "Resultado";
            this.lbResultado.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btVaciar
            // 
            this.btVaciar.Location = new System.Drawing.Point(86, 366);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(131, 39);
            this.btVaciar.TabIndex = 10;
            this.btVaciar.Text = "Vaciar cantidad";
            this.btVaciar.UseVisualStyleBackColor = true;
            this.btVaciar.Click += new System.EventHandler(this.btVaciar_Click);
            // 
            // FormConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btVaciar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.cbDivDest);
            this.Controls.Add(this.cbDivOrig);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbDivDest);
            this.Controls.Add(this.lbDivOrig);
            this.Controls.Add(this.lbCantidad);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormConv";
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.FormConv_Load);
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
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btVaciar;
    }
}

