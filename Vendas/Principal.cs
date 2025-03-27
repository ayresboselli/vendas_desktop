using Vendas.Views.Produtos;
using Vendas.Views.Clientes;

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

        private void ClientesStripMenuItemClick(object sender, EventArgs e)
        {
            var clientes = new ClientesView();
            clientes.Show();
        }
    }
}
