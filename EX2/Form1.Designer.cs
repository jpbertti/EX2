namespace EX2
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLista1 = new System.Windows.Forms.Button();
            this.lblLista1 = new System.Windows.Forms.Label();
            this.lblLista2 = new System.Windows.Forms.Label();
            this.lblLista2sub = new System.Windows.Forms.Label();
            this.lblLista3sub = new System.Windows.Forms.Label();
            this.lblLista3 = new System.Windows.Forms.Label();
            this.lblLista4sub = new System.Windows.Forms.Label();
            this.lblLista4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLista5 = new System.Windows.Forms.Label();
            this.btnLista2 = new System.Windows.Forms.Button();
            this.btnLista3 = new System.Windows.Forms.Button();
            this.btnLista4 = new System.Windows.Forms.Button();
            this.btnLista5 = new System.Windows.Forms.Button();
            this.lsbLista1 = new System.Windows.Forms.ListBox();
            this.lsbLista2 = new System.Windows.Forms.ListBox();
            this.lsbLista3 = new System.Windows.Forms.ListBox();
            this.lsbLista4 = new System.Windows.Forms.ListBox();
            this.lsbLista5 = new System.Windows.Forms.ListBox();
            this.lblLista1sub = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(375, 478);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(91, 36);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpar.Location = new System.Drawing.Point(545, 478);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 36);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLista1
            // 
            this.btnLista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista1.Location = new System.Drawing.Point(78, 374);
            this.btnLista1.Name = "btnLista1";
            this.btnLista1.Size = new System.Drawing.Size(91, 36);
            this.btnLista1.TabIndex = 2;
            this.btnLista1.Text = "Mostrar";
            this.btnLista1.UseVisualStyleBackColor = true;
            this.btnLista1.Click += new System.EventHandler(this.btnLista1_Click);
            // 
            // lblLista1
            // 
            this.lblLista1.AutoSize = true;
            this.lblLista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista1.Location = new System.Drawing.Point(56, 54);
            this.lblLista1.Name = "lblLista1";
            this.lblLista1.Size = new System.Drawing.Size(136, 16);
            this.lblLista1.TabIndex = 3;
            this.lblLista1.Text = "Lista de 1 até 1000";
            // 
            // lblLista2
            // 
            this.lblLista2.AutoSize = true;
            this.lblLista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista2.Location = new System.Drawing.Point(235, 54);
            this.lblLista2.Name = "lblLista2";
            this.lblLista2.Size = new System.Drawing.Size(160, 16);
            this.lblLista2.TabIndex = 4;
            this.lblLista2.Text = "Lista de 1001 até 2000";
            // 
            // lblLista2sub
            // 
            this.lblLista2sub.AutoSize = true;
            this.lblLista2sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista2sub.Location = new System.Drawing.Point(235, 70);
            this.lblLista2sub.Name = "lblLista2sub";
            this.lblLista2sub.Size = new System.Drawing.Size(168, 16);
            this.lblLista2sub.TabIndex = 5;
            this.lblLista2sub.Text = "Somente números impares";
            // 
            // lblLista3sub
            // 
            this.lblLista3sub.AutoSize = true;
            this.lblLista3sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista3sub.Location = new System.Drawing.Point(430, 70);
            this.lblLista3sub.Name = "lblLista3sub";
            this.lblLista3sub.Size = new System.Drawing.Size(154, 16);
            this.lblLista3sub.TabIndex = 7;
            this.lblLista3sub.Text = "Somente números pares";
            // 
            // lblLista3
            // 
            this.lblLista3.AutoSize = true;
            this.lblLista3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista3.Location = new System.Drawing.Point(430, 54);
            this.lblLista3.Name = "lblLista3";
            this.lblLista3.Size = new System.Drawing.Size(160, 16);
            this.lblLista3.TabIndex = 6;
            this.lblLista3.Text = "Lista de 2000 até 3000";
            // 
            // lblLista4sub
            // 
            this.lblLista4sub.AutoSize = true;
            this.lblLista4sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista4sub.Location = new System.Drawing.Point(615, 70);
            this.lblLista4sub.Name = "lblLista4sub";
            this.lblLista4sub.Size = new System.Drawing.Size(189, 15);
            this.lblLista4sub.TabIndex = 9;
            this.lblLista4sub.Text = "Somente números multiplos de 3";
            // 
            // lblLista4
            // 
            this.lblLista4.AutoSize = true;
            this.lblLista4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista4.Location = new System.Drawing.Point(615, 54);
            this.lblLista4.Name = "lblLista4";
            this.lblLista4.Size = new System.Drawing.Size(160, 16);
            this.lblLista4.TabIndex = 8;
            this.lblLista4.Text = "Lista de 3001 até 4000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(830, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dobrando o valor";
            // 
            // lblLista5
            // 
            this.lblLista5.AutoSize = true;
            this.lblLista5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista5.Location = new System.Drawing.Point(830, 54);
            this.lblLista5.Name = "lblLista5";
            this.lblLista5.Size = new System.Drawing.Size(168, 16);
            this.lblLista5.TabIndex = 10;
            this.lblLista5.Text = "Lista de 4001 até 50000";
            // 
            // btnLista2
            // 
            this.btnLista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista2.Location = new System.Drawing.Point(264, 374);
            this.btnLista2.Name = "btnLista2";
            this.btnLista2.Size = new System.Drawing.Size(91, 36);
            this.btnLista2.TabIndex = 17;
            this.btnLista2.Text = "Mostrar";
            this.btnLista2.UseVisualStyleBackColor = true;
            this.btnLista2.Click += new System.EventHandler(this.btnLista2_Click);
            // 
            // btnLista3
            // 
            this.btnLista3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista3.Location = new System.Drawing.Point(457, 374);
            this.btnLista3.Name = "btnLista3";
            this.btnLista3.Size = new System.Drawing.Size(91, 36);
            this.btnLista3.TabIndex = 18;
            this.btnLista3.Text = "Mostrar";
            this.btnLista3.UseVisualStyleBackColor = true;
            this.btnLista3.Click += new System.EventHandler(this.btnLista3_Click);
            // 
            // btnLista4
            // 
            this.btnLista4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista4.Location = new System.Drawing.Point(652, 374);
            this.btnLista4.Name = "btnLista4";
            this.btnLista4.Size = new System.Drawing.Size(91, 36);
            this.btnLista4.TabIndex = 19;
            this.btnLista4.Text = "Mostrar";
            this.btnLista4.UseVisualStyleBackColor = true;
            this.btnLista4.Click += new System.EventHandler(this.btnLista4_Click);
            // 
            // btnLista5
            // 
            this.btnLista5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista5.Location = new System.Drawing.Point(868, 374);
            this.btnLista5.Name = "btnLista5";
            this.btnLista5.Size = new System.Drawing.Size(91, 36);
            this.btnLista5.TabIndex = 20;
            this.btnLista5.Text = "Mostrar";
            this.btnLista5.UseVisualStyleBackColor = true;
            this.btnLista5.Click += new System.EventHandler(this.btnLista5_Click);
            // 
            // lsbLista1
            // 
            this.lsbLista1.FormattingEnabled = true;
            this.lsbLista1.Location = new System.Drawing.Point(59, 132);
            this.lsbLista1.Name = "lsbLista1";
            this.lsbLista1.Size = new System.Drawing.Size(156, 212);
            this.lsbLista1.TabIndex = 21;
            // 
            // lsbLista2
            // 
            this.lsbLista2.FormattingEnabled = true;
            this.lsbLista2.Location = new System.Drawing.Point(238, 132);
            this.lsbLista2.Name = "lsbLista2";
            this.lsbLista2.Size = new System.Drawing.Size(156, 212);
            this.lsbLista2.TabIndex = 22;
            // 
            // lsbLista3
            // 
            this.lsbLista3.FormattingEnabled = true;
            this.lsbLista3.Location = new System.Drawing.Point(428, 132);
            this.lsbLista3.Name = "lsbLista3";
            this.lsbLista3.Size = new System.Drawing.Size(156, 212);
            this.lsbLista3.TabIndex = 23;
            // 
            // lsbLista4
            // 
            this.lsbLista4.FormattingEnabled = true;
            this.lsbLista4.Location = new System.Drawing.Point(618, 132);
            this.lsbLista4.Name = "lsbLista4";
            this.lsbLista4.Size = new System.Drawing.Size(156, 212);
            this.lsbLista4.TabIndex = 24;
            // 
            // lsbLista5
            // 
            this.lsbLista5.FormattingEnabled = true;
            this.lsbLista5.Location = new System.Drawing.Point(833, 132);
            this.lsbLista5.Name = "lsbLista5";
            this.lsbLista5.Size = new System.Drawing.Size(156, 212);
            this.lsbLista5.TabIndex = 25;
            // 
            // lblLista1sub
            // 
            this.lblLista1sub.AutoSize = true;
            this.lblLista1sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista1sub.Location = new System.Drawing.Point(56, 70);
            this.lblLista1sub.Name = "lblLista1sub";
            this.lblLista1sub.Size = new System.Drawing.Size(67, 16);
            this.lblLista1sub.TabIndex = 26;
            this.lblLista1sub.Text = "De 1 em 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 569);
            this.Controls.Add(this.lblLista1sub);
            this.Controls.Add(this.lsbLista5);
            this.Controls.Add(this.lsbLista4);
            this.Controls.Add(this.lsbLista3);
            this.Controls.Add(this.lsbLista2);
            this.Controls.Add(this.lsbLista1);
            this.Controls.Add(this.btnLista5);
            this.Controls.Add(this.btnLista4);
            this.Controls.Add(this.btnLista3);
            this.Controls.Add(this.btnLista2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLista5);
            this.Controls.Add(this.lblLista4sub);
            this.Controls.Add(this.lblLista4);
            this.Controls.Add(this.lblLista3sub);
            this.Controls.Add(this.lblLista3);
            this.Controls.Add(this.lblLista2sub);
            this.Controls.Add(this.lblLista2);
            this.Controls.Add(this.lblLista1);
            this.Controls.Add(this.btnLista1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLista1;
        private System.Windows.Forms.Label lblLista1;
        private System.Windows.Forms.Label lblLista2;
        private System.Windows.Forms.Label lblLista2sub;
        private System.Windows.Forms.Label lblLista3sub;
        private System.Windows.Forms.Label lblLista3;
        private System.Windows.Forms.Label lblLista4sub;
        private System.Windows.Forms.Label lblLista4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLista5;
        private System.Windows.Forms.Button btnLista2;
        private System.Windows.Forms.Button btnLista3;
        private System.Windows.Forms.Button btnLista4;
        private System.Windows.Forms.Button btnLista5;
        private System.Windows.Forms.ListBox lsbLista1;
        private System.Windows.Forms.ListBox lsbLista2;
        private System.Windows.Forms.ListBox lsbLista3;
        private System.Windows.Forms.ListBox lsbLista4;
        private System.Windows.Forms.ListBox lsbLista5;
        private System.Windows.Forms.Label lblLista1sub;
    }
}

