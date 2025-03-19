using System.Globalization;
using Vendas.Models.Produtos;

namespace Vendas.Views.Produtos
{
    public partial class ProdutosView : Form
    {
        private int _idProduto;
        private int _idMarca;
        private int _idGrupo;

        public ProdutosView()
        {
            InitializeComponent();

            // Produto
            lvProduto.Columns.Add("Id", 50);
            lvProduto.Columns.Add("SKU", 150);
            lvProduto.Columns.Add("Nome", 150);
            lvProduto.Columns.Add("Grupo", 150);
            lvProduto.Columns.Add("Marca", 150);
            lvProduto.Columns.Add("Quantidade", 150);
            lvProduto.Columns.Add("Preço de Venda", 150);

            // Grupos
            lvGrupo.Columns.Add("Id", 50);
            lvGrupo.Columns.Add("Nome", 150);

            // Marcas
            lvMarca.Columns.Add("Id", 50);
            lvMarca.Columns.Add("Nome", 150);

            AtualizaGrids();
        }

        private void AtualizaGrids()
        {
            // Produto
            lvProduto.Items.Clear();

            int i = 0;
            foreach (var item in Models.Produtos.Produto.Listar())
            {
                ListViewItem row = new ListViewItem();
                row.SubItems[0].Text = item.Id.ToString();
                row.SubItems.Add(item.SKU);
                row.SubItems.Add(item.Nome);
                row.SubItems.Add(
                    item.Grupo.Id.ToString() +
                    " - " +
                    item.Grupo.Nome
                );
                row.SubItems.Add(
                    item.Marca.Id.ToString() +
                    " - " +
                    item.Marca.Nome
                );
                row.SubItems.Add(item.Quantidade.ToString());
                row.SubItems.Add(item.PrecoVenda?.ToString("C2", CultureInfo.CurrentCulture));
                
                if (i % 2 != 0)
                    row.BackColor = Color.Gainsboro;

                lvProduto.Items.Add(row);

                i++;
            }

            // Grupos
            lvGrupo.Items.Clear();

            i = 0;
            foreach (var item in GrupoProduto.Listar())
            {
                ListViewItem row = new ListViewItem();
                row.SubItems[0].Text = item.Id.ToString();
                row.SubItems.Add(item.Nome);

                if (i % 2 != 0)
                    row.BackColor = Color.Gainsboro;

                lvGrupo.Items.Add(row);

                i++;
            }

            // Marcas
            lvMarca.Items.Clear();

            i = 0;
            foreach (var item in Marca.Listar())
            {
                ListViewItem row = new ListViewItem();
                row.SubItems[0].Text = item.Id.ToString();
                row.SubItems.Add(item.Nome);

                if (i % 2 != 0)
                    row.BackColor = Color.Gainsboro;

                lvMarca.Items.Add(row);

                i++;
            }
        }

        // Produto
        private void LvProdutoMouseClick(object sender, MouseEventArgs e)
        {
            _idProduto = Convert.ToInt32(lvProduto.SelectedItems[0].SubItems[0].Text);

            if (e.Button == MouseButtons.Right)
            {
                if (lvProduto.FocusedItem != null && lvProduto.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    var contextMenu = new ContextMenuStrip();

                    var editMenuItem = new ToolStripMenuItem("Editar");
                    editMenuItem.Click += EditarProdutoClick;
                    contextMenu.Items.Add(editMenuItem);

                    var deleteMenuItem = new ToolStripMenuItem("Deletar");
                    deleteMenuItem.ForeColor = Color.Red;
                    deleteMenuItem.Click += ExcluirProdutoClick;
                    contextMenu.Items.Add(deleteMenuItem);

                    contextMenu.Show(lvProduto, new Point(e.X, e.Y));
                }
            }
        }

        private void BtnNovoProdutoClick(object sender, EventArgs e)
        {
            var produto = new ProdutoFormView();
            produto.Show();
            produto.FormClosed += FormClosed;
        }

        private void EditarProdutoClick(object sender, EventArgs e)
        {
            var produto = new ProdutoFormView(_idProduto);
            produto.Show();
            produto.FormClosed += FormClosed;
        }

        private void ExcluirProdutoClick(object sender, EventArgs e)
        {
            var produto = Models.Produtos.Produto.Buscar(_idProduto);
            if (produto != null && (MessageBox.Show("Tem certeza que deseja excluir o produto " + produto.Nome + "?", "Deletar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes))
            {
                produto.Deletar();
                AtualizaGrids();
                MessageBox.Show("Produto excluído comm sucesso!");
            }
        }


        // Marca
        private void LvMarcaMouseClick(object sender, MouseEventArgs e)
        {
            _idMarca = Convert.ToInt32(lvMarca.SelectedItems[0].SubItems[0].Text);

            if (e.Button == MouseButtons.Right)
            {
                if (lvMarca.FocusedItem != null && lvMarca.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    var contextMenu = new ContextMenuStrip();

                    var editMenuItem = new ToolStripMenuItem("Editar");
                    editMenuItem.Click += EditarMarcaClick;
                    contextMenu.Items.Add(editMenuItem);

                    var deleteMenuItem = new ToolStripMenuItem("Deletar");
                    deleteMenuItem.ForeColor = Color.Red;
                    deleteMenuItem.Click += ExcluirMarcaClick;
                    contextMenu.Items.Add(deleteMenuItem);

                    contextMenu.Show(lvMarca, new Point(e.X, e.Y));
                }
            }
        }

        private void BtnNovaMarcaClick(object sender, EventArgs e)
        {
            var marca = new MarcaFormView();
            marca.Show();
            marca.FormClosed += FormClosed;
        }

        private void EditarMarcaClick(object sender, EventArgs e)
        {
            var marca = new MarcaFormView(_idMarca);
            marca.Show();
            marca.FormClosed += FormClosed;
        }

        private void ExcluirMarcaClick(object sender, EventArgs e)
        {
            var marca = Marca.Buscar(_idMarca);
            if(marca != null)
            {
                if (marca.Produtos.Count > 0)
                {
                    MessageBox.Show("Não é possível excluir marcas relacionadas a produtos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Tem certeza que deseja excluir a marca " + marca.Nome + "?", "Deletar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    marca.Deletar();
                    AtualizaGrids();
                    MessageBox.Show("Marca excluída comm sucesso!");
                }
            }
        }


        // Grupo
        private void LvGrupoMouseClick(object sender, MouseEventArgs e)
        {
            _idGrupo = Convert.ToInt32(lvGrupo.SelectedItems[0].SubItems[0].Text);

            if (e.Button == MouseButtons.Right)
            {
                if (lvGrupo.FocusedItem != null && lvGrupo.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    var contextMenu = new ContextMenuStrip();

                    var editMenuItem = new ToolStripMenuItem("Editar");
                    editMenuItem.Click += EditarGrupoClick;
                    contextMenu.Items.Add(editMenuItem);

                    var deleteMenuItem = new ToolStripMenuItem("Deletar");
                    deleteMenuItem.ForeColor = Color.Red;
                    deleteMenuItem.Click += ExcluirGrupoClick;
                    contextMenu.Items.Add(deleteMenuItem);

                    contextMenu.Show(lvGrupo, new Point(e.X, e.Y));
                }
            }
        }

        private void BtnNovoGrupoClick(object sender, EventArgs e)
        {
            var grupo = new GrupoFormView();
            grupo.Show();
            grupo.FormClosed += FormClosed;
        }

        private void EditarGrupoClick(object sender, EventArgs e)
        {
            var grupo = new GrupoFormView(_idGrupo);
            grupo.Show();
            grupo.FormClosed += FormClosed;
        }

        private void ExcluirGrupoClick(object sender, EventArgs e)
        {
            var grupo = GrupoProduto.Buscar(_idGrupo);
            if (grupo != null)
            {
                if (grupo.Produtos.Count > 0)
                {
                    MessageBox.Show("Não é possível excluir grupos relacionados a produtos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (MessageBox.Show("Tem certeza que deseja excluir o grupo " + grupo.Nome + "?", "Deletar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    grupo.Deletar();
                    AtualizaGrids();
                    MessageBox.Show("Grupo excluído comm sucesso!");
                }
            }
        }



        private void FormClosed(object sender, EventArgs e)
        {
            AtualizaGrids();
        }
    }
}
