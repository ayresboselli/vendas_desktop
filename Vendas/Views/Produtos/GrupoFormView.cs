using Vendas.Models.Produtos;

namespace Vendas.Views.Produtos
{
    public partial class GrupoFormView : Form
    {
        private GrupoProduto? _grupo;

        public GrupoFormView(int? id = null)
        {
            InitializeComponent();

            if(id != null)
            {
                _grupo = GrupoProduto.Buscar(Convert.ToInt32(id));
                if (_grupo != null)
                { 
                    tbId.Text = _grupo.Id.ToString();
                    tbNome.Text = _grupo.Nome;
                }
            }
        }

        private void BtnSalvarClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("Preencha o campo nome", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var grupo = new GrupoProduto();
                grupo.Id = tbId.Text != "" ? Convert.ToInt16(tbId.Text) : 0;
                grupo.Nome = tbNome.Text;
                grupo.Salvar();

                Close();
            }
        }

        private void BtnCancelarClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
