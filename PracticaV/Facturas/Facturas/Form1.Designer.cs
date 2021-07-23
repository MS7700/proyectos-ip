namespace Facturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nudBalance = new System.Windows.Forms.NumericUpDown();
            this.nudMontoRecibido = new System.Windows.Forms.NumericUpDown();
            this.nudMontoPagar = new System.Windows.Forms.NumericUpDown();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoRecibido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(177, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto a pagar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto recibido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Balance pendiente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(182, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // nudBalance
            // 
            this.nudBalance.DecimalPlaces = 2;
            this.nudBalance.Enabled = false;
            this.nudBalance.Location = new System.Drawing.Point(182, 205);
            this.nudBalance.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudBalance.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.Size = new System.Drawing.Size(180, 20);
            this.nudBalance.TabIndex = 8;
            // 
            // nudMontoRecibido
            // 
            this.nudMontoRecibido.DecimalPlaces = 2;
            this.nudMontoRecibido.Location = new System.Drawing.Point(182, 174);
            this.nudMontoRecibido.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMontoRecibido.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudMontoRecibido.Name = "nudMontoRecibido";
            this.nudMontoRecibido.Size = new System.Drawing.Size(180, 20);
            this.nudMontoRecibido.TabIndex = 9;
            // 
            // nudMontoPagar
            // 
            this.nudMontoPagar.DecimalPlaces = 2;
            this.nudMontoPagar.Location = new System.Drawing.Point(182, 139);
            this.nudMontoPagar.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudMontoPagar.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudMontoPagar.Name = "nudMontoPagar";
            this.nudMontoPagar.Size = new System.Drawing.Size(180, 20);
            this.nudMontoPagar.TabIndex = 10;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(243, 254);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 35);
            this.btnProcesar.TabIndex = 11;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(102, 254);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 35);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar balance";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.nudMontoPagar);
            this.Controls.Add(this.nudMontoRecibido);
            this.Controls.Add(this.nudBalance);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoRecibido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontoPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nudBalance;
        private System.Windows.Forms.NumericUpDown nudMontoRecibido;
        private System.Windows.Forms.NumericUpDown nudMontoPagar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnActualizar;
    }
}

