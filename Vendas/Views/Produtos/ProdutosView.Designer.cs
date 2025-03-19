using Vendas.Models.Produtos;

namespace Vendas.Views.Produtos
{
    partial class ProdutosView
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
            tabControl1 = new TabControl();
            tpProdutos = new TabPage();
            btnNovoProduto = new Button();
            tpGrupos = new TabPage();
            lvGrupo = new ListView();
            btnNovoGrupo = new Button();
            tpMarcas = new TabPage();
            lvMarca = new ListView();
            btnNovaMarca = new Button();
            lvProduto = new ListView();
            tabControl1.SuspendLayout();
            tpProdutos.SuspendLayout();
            tpGrupos.SuspendLayout();
            tpMarcas.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tpProdutos);
            tabControl1.Controls.Add(tpGrupos);
            tabControl1.Controls.Add(tpMarcas);
            tabControl1.Location = new Point(2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 435);
            tabControl1.TabIndex = 0;
            // 
            // tpProdutos
            // 
            tpProdutos.Controls.Add(lvProduto);
            tpProdutos.Controls.Add(btnNovoProduto);
            tpProdutos.Location = new Point(4, 24);
            tpProdutos.Name = "tpProdutos";
            tpProdutos.Padding = new Padding(3);
            tpProdutos.Size = new Size(789, 407);
            tpProdutos.TabIndex = 0;
            tpProdutos.Text = "Produtos";
            tpProdutos.UseVisualStyleBackColor = true;
            // 
            // btnNovoProduto
            // 
            btnNovoProduto.Location = new Point(6, 7);
            btnNovoProduto.Name = "btnNovoProduto";
            btnNovoProduto.Size = new Size(75, 23);
            btnNovoProduto.TabIndex = 1;
            btnNovoProduto.Text = "Novo";
            btnNovoProduto.UseVisualStyleBackColor = true;
            btnNovoProduto.Click += BtnNovoProdutoClick;
            // 
            // tpGrupos
            // 
            tpGrupos.Controls.Add(lvGrupo);
            tpGrupos.Controls.Add(btnNovoGrupo);
            tpGrupos.Location = new Point(4, 24);
            tpGrupos.Name = "tpGrupos";
            tpGrupos.Padding = new Padding(3);
            tpGrupos.Size = new Size(789, 407);
            tpGrupos.TabIndex = 1;
            tpGrupos.Text = "Grupos";
            tpGrupos.UseVisualStyleBackColor = true;
            // 
            // lvGrupo
            // 
            lvGrupo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvGrupo.FullRowSelect = true;
            lvGrupo.Location = new Point(6, 35);
            lvGrupo.Name = "lvGrupo";
            lvGrupo.Size = new Size(776, 366);
            lvGrupo.TabIndex = 4;
            lvGrupo.UseCompatibleStateImageBehavior = false;
            lvGrupo.View = View.Details;
            lvGrupo.MouseClick += LvGrupoMouseClick;
            // 
            // btnNovoGrupo
            // 
            btnNovoGrupo.Location = new Point(6, 6);
            btnNovoGrupo.Name = "btnNovoGrupo";
            btnNovoGrupo.Size = new Size(75, 23);
            btnNovoGrupo.TabIndex = 3;
            btnNovoGrupo.Text = "Novo";
            btnNovoGrupo.UseVisualStyleBackColor = true;
            btnNovoGrupo.Click += BtnNovoGrupoClick;
            // 
            // tpMarcas
            // 
            tpMarcas.Controls.Add(lvMarca);
            tpMarcas.Controls.Add(btnNovaMarca);
            tpMarcas.Location = new Point(4, 24);
            tpMarcas.Name = "tpMarcas";
            tpMarcas.Padding = new Padding(3);
            tpMarcas.Size = new Size(789, 407);
            tpMarcas.TabIndex = 2;
            tpMarcas.Text = "Marcas";
            tpMarcas.UseVisualStyleBackColor = true;
            // 
            // lvMarca
            // 
            lvMarca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvMarca.FullRowSelect = true;
            lvMarca.Location = new Point(6, 35);
            lvMarca.Name = "lvMarca";
            lvMarca.Size = new Size(776, 369);
            lvMarca.TabIndex = 4;
            lvMarca.UseCompatibleStateImageBehavior = false;
            lvMarca.View = View.Details;
            lvMarca.MouseClick += LvMarcaMouseClick;
            // 
            // btnNovaMarca
            // 
            btnNovaMarca.Location = new Point(6, 6);
            btnNovaMarca.Name = "btnNovaMarca";
            btnNovaMarca.Size = new Size(75, 23);
            btnNovaMarca.TabIndex = 3;
            btnNovaMarca.Text = "Novo";
            btnNovaMarca.UseVisualStyleBackColor = true;
            btnNovaMarca.Click += BtnNovaMarcaClick;
            // 
            // lvProduto
            // 
            lvProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProduto.FullRowSelect= true;
            lvProduto.Location = new Point(6, 36);
            lvProduto.Name = "lvProduto";
            lvProduto.Size = new Size(776, 365);
            lvProduto.TabIndex = 2;
            lvProduto.UseCompatibleStateImageBehavior = false;
            lvProduto.View = View.Details;
            lvProduto.MouseClick += LvProdutoMouseClick;
            // 
            // ProdutosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "ProdutosView";
            Text = "Produtos";
            tabControl1.ResumeLayout(false);
            tpProdutos.ResumeLayout(false);
            tpGrupos.ResumeLayout(false);
            tpMarcas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpProdutos;
        private TabPage tpGrupos;
        private TabPage tpMarcas;
        private Button btnNovoProduto;
        private Button btnNovoGrupo;
        private Button btnNovaMarca;
        private ListView lvMarca;
        private ListView lvGrupo;
        private ListView lvProduto;
    }
}