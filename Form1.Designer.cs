namespace DesafioA3T1
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
            this.Lbproduto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbnome = new System.Windows.Forms.TextBox();
            this.Cbtipo = new System.Windows.Forms.ComboBox();
            this.Btncadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbproduto
            // 
            this.Lbproduto.AutoSize = true;
            this.Lbproduto.Location = new System.Drawing.Point(41, 67);
            this.Lbproduto.Name = "Lbproduto";
            this.Lbproduto.Size = new System.Drawing.Size(92, 13);
            this.Lbproduto.TabIndex = 0;
            this.Lbproduto.Text = "Nome do produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // Tbnome
            // 
            this.Tbnome.Location = new System.Drawing.Point(140, 64);
            this.Tbnome.Name = "Tbnome";
            this.Tbnome.Size = new System.Drawing.Size(100, 20);
            this.Tbnome.TabIndex = 2;
            // 
            // Cbtipo
            // 
            this.Cbtipo.FormattingEnabled = true;
            this.Cbtipo.Items.AddRange(new object[] {
            "Livro",
            "Caderno",
            "Caneta",
            "Lápis"});
            this.Cbtipo.Location = new System.Drawing.Point(140, 128);
            this.Cbtipo.Name = "Cbtipo";
            this.Cbtipo.Size = new System.Drawing.Size(121, 21);
            this.Cbtipo.TabIndex = 3;
            // 
            // Btncadastrar
            // 
            this.Btncadastrar.Location = new System.Drawing.Point(151, 218);
            this.Btncadastrar.Name = "Btncadastrar";
            this.Btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.Btncadastrar.TabIndex = 4;
            this.Btncadastrar.Text = "Cadastrar";
            this.Btncadastrar.UseVisualStyleBackColor = true;
            this.Btncadastrar.Click += new System.EventHandler(this.Btncadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 342);
            this.Controls.Add(this.Btncadastrar);
            this.Controls.Add(this.Cbtipo);
            this.Controls.Add(this.Tbnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbproduto);
            this.Name = "Form1";
            this.Text = "Cadastro de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbproduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbnome;
        private System.Windows.Forms.ComboBox Cbtipo;
        private System.Windows.Forms.Button Btncadastrar;
    }
}

