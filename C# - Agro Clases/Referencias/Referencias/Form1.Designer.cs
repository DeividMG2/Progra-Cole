namespace Referencias
{
    partial class Form1
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
            this.btn_valor = new System.Windows.Forms.Button();
            this.btn_referencia = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_valor
            // 
            this.btn_valor.Location = new System.Drawing.Point(32, 314);
            this.btn_valor.Name = "btn_valor";
            this.btn_valor.Size = new System.Drawing.Size(191, 82);
            this.btn_valor.TabIndex = 0;
            this.btn_valor.Text = "Por Valor";
            this.btn_valor.UseVisualStyleBackColor = true;
            this.btn_valor.Click += new System.EventHandler(this.btn_valor_Click);
            // 
            // btn_referencia
            // 
            this.btn_referencia.Location = new System.Drawing.Point(414, 314);
            this.btn_referencia.Name = "btn_referencia";
            this.btn_referencia.Size = new System.Drawing.Size(191, 82);
            this.btn_referencia.TabIndex = 1;
            this.btn_referencia.Text = "Por Referencia";
            this.btn_referencia.UseVisualStyleBackColor = true;
            this.btn_referencia.Click += new System.EventHandler(this.btn_referencia_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 107);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 458);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_referencia);
            this.Controls.Add(this.btn_valor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_valor;
        private System.Windows.Forms.Button btn_referencia;
        private System.Windows.Forms.TextBox textBox1;
    }
}

