using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Vendas.Models.Clientes;
using Vendas.Models.Gerais;

namespace Vendas.Views.Clientes
{
    public partial class ClienteFormView : Form
    {
        private Cliente? _cliente;

        public ClienteFormView(int? id = null)
        {
            InitializeComponent();
            CarregaEstados();
            CarregaDados(id);
        }

        private void CarregaDados(int? id = null)
        {
            foreach (var item in GrupoCliente.Listar())
            {
                cbGrupo.Items.Add(item.Id.ToString() + " - " + item.Nome);
            }

            if (id != null)
            {
                _cliente = Cliente.Buscar(Convert.ToInt32(id));
                if (_cliente != null)
                {
                    CarregaCidades(_cliente.Estado);

                    tbId.Text = _cliente.Id.ToString();
                    cbGrupo.SelectedItem = _cliente.Grupo.Id.ToString() + " - " + _cliente.Grupo.Nome;
                    cbTipoPessoa.SelectedItem = _cliente.TipoPessoa == 'F' ? "Física" : "Jurídica";
                    tbDocumento.Text = _cliente.Documento;
                    tbNome.Text = _cliente.Nome;
                    tbApelido.Text = _cliente.Apelido;
                    dtDataNascimento.Text = _cliente.DataNascimento.ToString();
                    tbEmail.Text = _cliente.EMail;
                    tbTelefone.Text = _cliente.Telefone;
                    tbCep.Text = _cliente.Cep;
                    tbLogradouro.Text = _cliente.Logradouro;
                    tbNumero.Text = _cliente.Numero.ToString();
                    tbComplemento.Text = _cliente.Complemento;
                    tbBairro.Text = _cliente.Bairro;
                    cbEstado.SelectedItem = _cliente.Estado;
                    cbCidades.SelectedItem = _cliente.Cidade;
                    chkAtivo.Checked = _cliente.Ativo;
                }
            }
            else
            {
                cbTipoPessoa.SelectedItem = "Física";
                dtDataNascimento.Value = new DateTime(2000, 1, 1);
                chkAtivo.Checked = true;
            }
        }

        private void CarregaEstados()
        {
            var requisicaoWeb = WebRequest.CreateHttp("https://servicodados.ibge.gov.br/api/v1/localidades/estados");
            requisicaoWeb.Method = "GET";
            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                Estado[] estados = JsonConvert.DeserializeObject<Estado[]>(objResponse.ToString());

                Array.Sort(estados,
                    delegate (Estado x, Estado y) { return x.Sigla.CompareTo(y.Sigla); });

                foreach (Estado estado in estados)
                {
                    cbEstado.Items.Add(estado.Sigla);
                }
            }
        }

        private void CarregaCidades(string? uf)
        {
            cbCidades.Items.Clear();

            if (uf != null)
            {
                var requisicaoWeb = WebRequest.CreateHttp($"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{uf}/municipios");
                requisicaoWeb.Method = "GET";
                using (var resposta = requisicaoWeb.GetResponse())
                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();
                    Cidade[] cidades = JsonConvert.DeserializeObject<Cidade[]>(objResponse.ToString());

                    Array.Sort(cidades,
                        delegate (Cidade x, Cidade y) { return x.Nome.CompareTo(y.Nome); });

                    foreach (Cidade cidade in cidades)
                    {
                        cbCidades.Items.Add(cidade.Nome);
                    }
                }
            }
        }

        private void CbEstadoSelectedIndexChanged(object sender, EventArgs e)
        {
            var estados = (ComboBox)sender;
            string sigla = estados.SelectedItem.ToString();
            CarregaCidades(sigla);
        }

        private void CbTipoPessoaSelectedIndexChanged(object sender, EventArgs e)
        {
            var tipoPessoa = (ComboBox)sender;
            string tipo = tipoPessoa.SelectedItem.ToString();

            if (tipo == "Física")
            {
                lbDocumento.Text = "CPF";
                lbDataNascimento.Text = "Data de nascimento";//"Data de registro";
                lbNome.Text = "Nome completo";
                lbApelido.Text = "Apelido";
                tbDocumento.MaxLength = 14;
            }
            else
            {
                lbDocumento.Text = "CNPJ";
                lbDataNascimento.Text = "Data de registro";
                lbNome.Text = "Razão social";
                lbApelido.Text = "Nome fantasía";
                tbDocumento.MaxLength = 18;
            }
        }

        private void BtnSalvarClick(object sender, EventArgs e)
        {
            bool erro = false;

            if (string.IsNullOrEmpty(tbNome.Text))
            {
                MessageBox.Show("Preencha o campo nome", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erro = true;
            }
            else if (cbGrupo.SelectedItem == null)
            {
                MessageBox.Show("Selecione um grupo", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erro = true;
            }
            else if (tbEmail.Text != "" && !new EmailAddressAttribute().IsValid(tbEmail.Text))
            {
                MessageBox.Show("E-mail inválido", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erro = true;
            }

            if (!erro)
            {
                var cliente = new Cliente();

                cliente.Id = tbId.Text != "" ? Convert.ToInt16(tbId.Text) : 0;
                cliente.TipoPessoa = cbTipoPessoa.SelectedItem.ToString().ToCharArray()[0];
                cliente.Documento = tbDocumento.Text;
                cliente.Nome = tbNome.Text;
                cliente.Apelido = tbApelido.Text;
                cliente.DataNascimento = DateOnly.ParseExact(dtDataNascimento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                cliente.EMail = tbEmail.Text;
                cliente.Telefone = tbTelefone.Text;
                cliente.GrupoId = Convert.ToInt32(cbGrupo.SelectedItem.ToString().Split(" - ")[0]);
                cliente.Cep = tbCep.Text;
                cliente.Logradouro = tbLogradouro.Text;
                cliente.Numero = tbNumero.Text != "" ? Convert.ToInt32(tbNumero.Text) : null;
                cliente.Complemento = tbComplemento.Text;
                cliente.Bairro = tbBairro.Text;
                cliente.Estado = cbEstado.SelectedItem?.ToString();
                cliente.Cidade = cbCidades.SelectedItem?.ToString();
                cliente.Ativo = chkAtivo.Checked;

                cliente.Salvar();

                Close();
            }
        }

        private void BtnCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void TbDocumentoTextChanged(object sender, EventArgs e)
        {
            var documento = (TextBox)sender;
            var caracteres = Regex.Replace(documento.Text, @"[^\d]", "").ToCharArray();

            string texto = "";
            for (int i = 0; i < caracteres.Length; i++)
            {
                // CPF
                if (cbTipoPessoa.SelectedItem.ToString() == "Física")
                {
                    switch (i)
                    {
                        case 3:
                        case 6:
                            texto += ".";
                            break;
                        case 9:
                            texto += "-";
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 2:
                        case 5:
                            texto += ".";
                            break;
                        case 8:
                            texto += "/";
                            break;
                        case 12:
                            texto += "-";
                            break;
                    }
                }

                texto += caracteres[i];
            }

            tbDocumento.Text = texto;
            tbDocumento.SelectionStart = texto.Length;
            tbDocumento.SelectionLength = 0;
        }

        private void TbTelefoneTextChanged(object sender, EventArgs e)
        {
            var telefone = (TextBox)sender;
            var caracteres = Regex.Replace(telefone.Text, @"[^\d]", "").ToCharArray();
            
            string texto = "";
            for (int i = 0; i < caracteres.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        texto += "(";
                        break;
                    case 2:
                        texto += ") ";
                        break;
                    case 7:
                        texto += " ";
                        break;
                }

                texto += caracteres[i];
            }

            tbTelefone.Text = texto;
            tbTelefone.SelectionStart = texto.Length;
            tbTelefone.SelectionLength = 0;
        }
    }
}
