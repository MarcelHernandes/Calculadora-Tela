namespace CalculadoraTela
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
            this.NumeroUm = new System.Windows.Forms.TextBox();
            this.NumeroDois = new System.Windows.Forms.TextBox();
            this.Somar = new System.Windows.Forms.Button();
            this.Subtrair = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número:";
            // 
            // NumeroUm
            // 
            this.NumeroUm.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroUm.Location = new System.Drawing.Point(123, 107);
            this.NumeroUm.Name = "NumeroUm";
            this.NumeroUm.Size = new System.Drawing.Size(200, 28);
            this.NumeroUm.TabIndex = 3;
            this.NumeroUm.TextChanged += new System.EventHandler(this.NumeroUm_TextChanged);
            // 
            // NumeroDois
            // 
            this.NumeroDois.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroDois.Location = new System.Drawing.Point(125, 151);
            this.NumeroDois.Name = "NumeroDois";
            this.NumeroDois.Size = new System.Drawing.Size(199, 28);
            this.NumeroDois.TabIndex = 4;
            this.NumeroDois.TextChanged += new System.EventHandler(this.NumeroDois_TextChanged);
            // 
            // Somar
            // 
            this.Somar.BackColor = System.Drawing.Color.Moccasin;
            this.Somar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Somar.Location = new System.Drawing.Point(17, 218);
            this.Somar.Name = "Somar";
            this.Somar.Size = new System.Drawing.Size(120, 55);
            this.Somar.TabIndex = 5;
            this.Somar.Text = "Somar";
            this.Somar.UseVisualStyleBackColor = false;
            this.Somar.Click += new System.EventHandler(this.Somar_Click);
            // 
            // Subtrair
            // 
            this.Subtrair.BackColor = System.Drawing.Color.Moccasin;
            this.Subtrair.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtrair.Location = new System.Drawing.Point(143, 218);
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.Size = new System.Drawing.Size(120, 55);
            this.Subtrair.TabIndex = 6;
            this.Subtrair.Text = "Subtrair";
            this.Subtrair.UseVisualStyleBackColor = false;
            this.Subtrair.Click += new System.EventHandler(this.Subtrair_Click);
            // 
            // Dividir
            // 
            this.Dividir.BackColor = System.Drawing.Color.Moccasin;
            this.Dividir.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dividir.Location = new System.Drawing.Point(17, 279);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(120, 59);
            this.Dividir.TabIndex = 7;
            this.Dividir.Text = "Dividir";
            this.Dividir.UseVisualStyleBackColor = false;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // Multiplicar
            // 
            this.Multiplicar.BackColor = System.Drawing.Color.Moccasin;
            this.Multiplicar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicar.Location = new System.Drawing.Point(143, 279);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(120, 59);
            this.Multiplicar.TabIndex = 8;
            this.Multiplicar.Text = "Multiplicar";
            this.Multiplicar.UseVisualStyleBackColor = false;
            this.Multiplicar.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // Resultado
            // 
            this.Resultado.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(28, 361);
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(296, 28);
            this.Resultado.TabIndex = 9;
            this.Resultado.TextChanged += new System.EventHandler(this.Resultado_TextChanged);
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.Color.Moccasin;
            this.Limpar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(269, 218);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(75, 120);
            this.Limpar.TabIndex = 10;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = false;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = "Softer destinado a realizar calculos  básicos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(355, 406);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.Subtrair);
            this.Controls.Add(this.Somar);
            this.Controls.Add(this.NumeroDois);
            this.Controls.Add(this.NumeroUm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(371, 445);
            this.MinimumSize = new System.Drawing.Size(371, 445);
            this.Name = "Form1";
            this.Text = "Página Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumeroUm;
        private System.Windows.Forms.TextBox NumeroDois;
        private System.Windows.Forms.Button Somar;
        private System.Windows.Forms.Button Subtrair;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button Limpar;
    }
}

