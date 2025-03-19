using Vendas.Models.Produtos;

namespace Vendas.Views.Produtos
{
    public partial class MarcaFormView : Form
    {
        private Marca? _marca;

        public MarcaFormView(int? id = null)
        {
            InitializeComponent();

            if (id != null)
            {
                _marca = Marca.Buscar(Convert.ToInt32(id));
                if (_marca != null)
                {
                    tbId.Text = _marca.Id.ToString();
                    tbNome.Text = _marca.Nome;
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
                var marca = new Marca();
                marca.Id = tbId.Text != "" ? Convert.ToInt16(tbId.Text) : 0;
                marca.Nome = tbNome.Text;
                marca.Salvar();

                Close();
            }
        }

        private void BtnCancelarClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
