namespace Calculo_de_Soma_e_mutiplicacao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSoma = new System.Windows.Forms.Label();
            this.lblMulti = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.textBoxValor1 = new System.Windows.Forms.TextBox();
            this.textBoxValor2 = new System.Windows.Forms.TextBox();
            this.textBoxValor3 = new System.Windows.Forms.TextBox();
            this.textBoxValor4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de 4 Números";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primeiro Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Terceiro Número:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quarto Número:";
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.ForeColor = System.Drawing.Color.White;
            this.lblSoma.Location = new System.Drawing.Point(12, 223);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(0, 13);
            this.lblSoma.TabIndex = 5;
            // 
            // lblMulti
            // 
            this.lblMulti.AutoSize = true;
            this.lblMulti.ForeColor = System.Drawing.Color.White;
            this.lblMulti.Location = new System.Drawing.Point(12, 250);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(0, 13);
            this.lblMulti.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(86, 197);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 28);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxValor1
            // 
            this.textBoxValor1.Location = new System.Drawing.Point(93, 69);
            this.textBoxValor1.Name = "textBoxValor1";
            this.textBoxValor1.Size = new System.Drawing.Size(50, 20);
            this.textBoxValor1.TabIndex = 8;
            // 
            // textBoxValor2
            // 
            this.textBoxValor2.Location = new System.Drawing.Point(93, 102);
            this.textBoxValor2.Name = "textBoxValor2";
            this.textBoxValor2.Size = new System.Drawing.Size(50, 20);
            this.textBoxValor2.TabIndex = 9;
            // 
            // textBoxValor3
            // 
            this.textBoxValor3.Location = new System.Drawing.Point(93, 132);
            this.textBoxValor3.Name = "textBoxValor3";
            this.textBoxValor3.Size = new System.Drawing.Size(50, 20);
            this.textBoxValor3.TabIndex = 10;
            // 
            // textBoxValor4
            // 
            this.textBoxValor4.Location = new System.Drawing.Point(93, 162);
            this.textBoxValor4.Name = "textBoxValor4";
            this.textBoxValor4.Size = new System.Drawing.Size(50, 20);
            this.textBoxValor4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(245, 304);
            this.Controls.Add(this.textBoxValor4);
            this.Controls.Add(this.textBoxValor3);
            this.Controls.Add(this.textBoxValor2);
            this.Controls.Add(this.textBoxValor1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMulti);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox textBoxValor1;
        private System.Windows.Forms.TextBox textBoxValor2;
        private System.Windows.Forms.TextBox textBoxValor3;
        private System.Windows.Forms.TextBox textBoxValor4;
    }
}

