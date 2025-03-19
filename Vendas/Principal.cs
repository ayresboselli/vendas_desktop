using Vendas.Views.Produtos;

namespace Vendas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ProdutosStripMenuItemClick(object sender, EventArgs e)
        {
            var produtos = new ProdutosView();
            produtos.Show();
        }
    }
}
