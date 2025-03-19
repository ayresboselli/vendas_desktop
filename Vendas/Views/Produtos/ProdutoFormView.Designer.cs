namespace Vendas.Views.Produtos
{
    partial class ProdutoFormView
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
            btnCancelar = new Button();
            btnSalvar = new Button();
            tbNome = new TextBox();
            tbId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbSKU = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbQuantidade = new TextBox();
            tbUltCusto = new TextBox();
            tbCustoMedio = new TextBox();
            tbPrecoVenda = new TextBox();
            tbMarcaId = new TextBox();
            tbGrupoId = new TextBox();
            lbMarca = new Label();
            lbGrupo = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(283, 311);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 36);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelarClick;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(142, 311);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(89, 36);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvarClick;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(22, 100);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(472, 23);
            tbNome.TabIndex = 3;
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Location = new Point(22, 37);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 13;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 12;
            label1.Text = "Id";
            // 
            // tbSKU
            // 
            tbSKU.Location = new Point(140, 37);
            tbSKU.Name = "tbSKU";
            tbSKU.Size = new Size(155, 23);
            tbSKU.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 19);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 14;
            label3.Text = "SKU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 218);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 15;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 218);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 16;
            label5.Text = "Grupo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 152);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 18;
            label6.Text = "Qtd. Estoque";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(262, 152);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 19;
            label7.Text = "Últ. custo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(140, 152);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 20;
            label8.Text = "Custo médio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(386, 152);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 21;
            label9.Text = "Preço venda";
            // 
            // tbQuantidade
            // 
            tbQuantidade.Location = new Point(22, 170);
            tbQuantidade.Name = "tbQuantidade";
            tbQuantidade.Size = new Size(100, 23);
            tbQuantidade.TabIndex = 4;
            tbQuantidade.KeyPress += TextoInteiroKeyPress;
            // 
            // tbUltCusto
            // 
            tbUltCusto.Location = new Point(262, 170);
            tbUltCusto.Name = "tbUltCusto";
            tbUltCusto.Size = new Size(108, 23);
            tbUltCusto.TabIndex = 6;
            tbUltCusto.KeyPress += MascaraMoedaKeyPress;
            // 
            // tbCustoMedio
            // 
            tbCustoMedio.Location = new Point(140, 170);
            tbCustoMedio.Name = "tbCustoMedio";
            tbCustoMedio.Size = new Size(107, 23);
            tbCustoMedio.TabIndex = 5;
            tbCustoMedio.KeyPress += MascaraMoedaKeyPress;
            // 
            // tbPrecoVenda
            // 
            tbPrecoVenda.Location = new Point(386, 170);
            tbPrecoVenda.Name = "tbPrecoVenda";
            tbPrecoVenda.Size = new Size(108, 23);
            tbPrecoVenda.TabIndex = 7;
            tbPrecoVenda.KeyPress += MascaraMoedaKeyPress;
            // 
            // tbMarcaId
            // 
            tbMarcaId.Location = new Point(22, 236);
            tbMarcaId.Name = "tbMarcaId";
            tbMarcaId.Size = new Size(54, 23);
            tbMarcaId.TabIndex = 8;
            tbMarcaId.TextChanged += TbMarcaIdTextChanged;
            tbMarcaId.KeyPress += TextoInteiroKeyPress;
            // 
            // tbGrupoId
            // 
            tbGrupoId.Location = new Point(262, 236);
            tbGrupoId.Name = "tbGrupoId";
            tbGrupoId.Size = new Size(54, 23);
            tbGrupoId.TabIndex = 9;
            tbGrupoId.TextChanged += TbGrupoIdTextChanged;
            tbGrupoId.KeyPress += TextoInteiroKeyPress;
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Location = new Point(82, 239);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(0, 15);
            lbMarca.TabIndex = 22;
            // 
            // lbGrupo
            // 
            lbGrupo.AutoSize = true;
            lbGrupo.Location = new Point(322, 239);
            lbGrupo.Name = "lbGrupo";
            lbGrupo.Size = new Size(0, 15);
            lbGrupo.TabIndex = 23;
            // 
            // ProdutoFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 390);
            Controls.Add(lbGrupo);
            Controls.Add(lbMarca);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbId);
            Controls.Add(tbSKU);
            Controls.Add(tbNome);
            Controls.Add(tbQuantidade);
            Controls.Add(tbCustoMedio);
            Controls.Add(tbUltCusto);
            Controls.Add(tbPrecoVenda);
            Controls.Add(tbMarcaId);
            Controls.Add(tbGrupoId);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProdutoFormView";
            Text = "Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnSalvar;
        private TextBox tbNome;
        private TextBox tbId;
        private Label label2;
        private Label label1;
        private TextBox tbSKU;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbQuantidade;
        private TextBox tbUltCusto;
        private TextBox tbCustoMedio;
        private TextBox tbPrecoVenda;
        private TextBox tbMarcaId;
        private TextBox tbGrupoId;
        private Label lbMarca;
        private Label lbGrupo;
    }
}