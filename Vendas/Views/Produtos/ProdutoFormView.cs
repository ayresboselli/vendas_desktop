using Vendas.Models.Produtos;

namespace Vendas.Views.Produtos
{
    public partial class ProdutoFormView : Form
    {
        private Models.Produtos.Produto _produto;

        public ProdutoFormView(int? id = null)
        {
            InitializeComponent();

            if(id != null)
            {
                _produto = Produto.Buscar(Convert.ToInt32(id));

                tbId.Text = _produto.Id.ToString();
                tbSKU.Text = _produto.SKU;
                tbNome.Text = _produto.Nome;
                tbQuantidade.Text = _produto.Quantidade.ToString();
                tbCustoMedio.Text = _produto.CustoMedio.ToString("N2");
                tbUltCusto.Text = _produto.UltimoCusto.ToString("N2");
                tbPrecoVenda.Text = _produto.PrecoVenda?.ToString("N2");
                tbMarcaId.Text = _produto.MarcaId.ToString();
                tbGrupoId.Text = _produto.GrupoId.ToString();
            }
        }

        private void MascaraMoedaKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextoInteiroKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbMarcaIdTextChanged(object sender, EventArgs e)
        {
            if (tbMarcaId.Text != "")
            {
                var marca = Marca.Buscar(Convert.ToInt32(tbMarcaId.Text));
                if (marca != null)
                {
                    lbMarca.Text = marca.Nome;
                    lbMarca.ForeColor = Color.Black;
                }
                else
                {
                    lbMarca.Text = "Marca não encontrada";
                    lbMarca.ForeColor = Color.Red;
                }
            }
            else
            {
                lbMarca.Text = "";
            }
        }

        private void TbGrupoIdTextChanged(object sender, EventArgs e)
        {
            if (tbGrupoId.Text != "")
            {
                var grupo = GrupoProduto.Buscar(Convert.ToInt32(tbGrupoId.Text));
                if (grupo != null)
                {
                    lbGrupo.Text = grupo.Nome;
                    lbGrupo.ForeColor = Color.Black;
                }
                else
                {
                    lbGrupo.Text = "Grupo não encontrado";
                    lbGrupo.ForeColor = Color.Red;
                }
            }
            else
            {
                lbGrupo.Text = "";
            }
        }

        private void BtnSalvarClick(object sender, EventArgs e)
        {
            bool erro = false;
            if (string.IsNullOrEmpty(tbSKU.Text))
            {
                MessageBox.Show("Preencha o campo SKU", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erro = true;
            }
            else if (string.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("Preencha o campo nome", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erro = true;
            }
            else if (string.IsNullOrEmpty(tbQuantidade.Text))
            {
                MessageBox.Show("Preencha a quantidade de produtos", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erro = true;
            }
            else if (string.IsNullOrEmpty(tbCustoMedio.Text))
            {
                MessageBox.Show("Preencha o custo médio", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erro = true;
            }
            else if (string.IsNullOrEmpty(tbUltCusto.Text))
            {
                MessageBox.Show("Preencha o último custo", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erro = true;
            }
            //else if (string.IsNullOrEmpty(tbPrecoVenda.Text))
            //{
            //    MessageBox.Show("Preencha o preço de venda", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    erro = true;
            //}
            else if (string.IsNullOrEmpty(tbMarcaId.Text) || lbMarca.ForeColor == Color.Red)
            {
                MessageBox.Show("Selecione a marca", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erro = true;
            }
            else if (string.IsNullOrEmpty(tbGrupoId.Text) || lbGrupo.ForeColor == Color.Red)
            {
                MessageBox.Show("Selecione o grupo", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erro = true;
            }

            if (!erro)
            {
                var produto = new Produto();
                produto.Id = tbId.Text != "" ? Convert.ToInt16(tbId.Text) : 0;
                produto.SKU = tbSKU.Text;
                produto.Nome = tbNome.Text;
                produto.Quantidade = Convert.ToInt32(tbQuantidade.Text);
                produto.CustoMedio = Convert.ToDecimal(tbCustoMedio.Text);
                produto.UltimoCusto = Convert.ToDecimal(tbUltCusto.Text);
                produto.PrecoVenda = Convert.ToDecimal(tbPrecoVenda.Text);
                produto.MarcaId = Convert.ToInt32(tbMarcaId.Text);
                produto.GrupoId = Convert.ToInt32(tbGrupoId.Text);
                produto.Salvar();

                Close();
            }
        }

        private void BtnCancelarClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
