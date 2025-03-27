using Vendas.Models.Clientes;

namespace Vendas.Views.Clientes
{
    public partial class ClientesView : Form
    {
        private int _idGrupo;
        private int _idCliente;

        public ClientesView()
        {
            InitializeComponent();

            // Clientes
            lvClientes.Columns.Add("Id", 50);
            lvClientes.Columns.Add("TipoPessoa");
            lvClientes.Columns.Add("Nome");
            lvClientes.Columns.Add("Grupo");
            lvClientes.Columns.Add("Apelido");
            lvClientes.Columns.Add("EMail");
            lvClientes.Columns.Add("Telefone");
            lvClientes.Columns.Add("Cidade");
            lvClientes.Columns.Add("Estado");
            lvClientes.Columns.Add("Ativo");

            // Grupos
            lvGrupos.Columns.Add("Id", 50);
            lvGrupos.Columns.Add("Nome", 150);

            AtualizaGrids();
        }

        private void AtualizaGrids()
        {

            // Clientes
            lvClientes.Items.Clear();

            int i = 0;
            foreach (var item in Cliente.Listar())
            {
                ListViewItem row = new ListViewItem();
                row.SubItems[0].Text = item.Id.ToString();
                row.SubItems.Add(item.TipoPessoa=='F'?"Física":"Jurídica");
                row.SubItems.Add(item.Nome);
                row.SubItems.Add(
                    item.Grupo.Id + " - " + item.Grupo.Nome
                );
                row.SubItems.Add(item.Apelido);
                row.SubItems.Add(item.EMail);
                row.SubItems.Add(item.Telefone);
                row.SubItems.Add(item.Cidade);
                row.SubItems.Add(item.Estado);
                row.SubItems.Add(item.Ativo==true?"Ativo":"Inativo");

                if (item.Ativo == false)
                    row.ForeColor = Color.DarkRed;

                if (i % 2 != 0)
                    row.BackColor = Color.Gainsboro;

                lvClientes.Items.Add(row);

                i++;
            }

            // Grupos
            lvGrupos.Items.Clear();

            i = 0;
            foreach (var item in GrupoCliente.Listar())
            {
                ListViewItem row = new ListViewItem();
                row.SubItems[0].Text = item.Id.ToString();
                row.SubItems.Add(item.Nome);

                if (i % 2 != 0)
                    row.BackColor = Color.Gainsboro;

                lvGrupos.Items.Add(row);

                i++;
            }

        }


        // Clientes
        private void LvClienteMouseClick(object sender, MouseEventArgs e)
        {
            _idCliente = Convert.ToInt32(lvClientes.SelectedItems[0].SubItems[0].Text);

            if (e.Button == MouseButtons.Right)
            {
                if (lvClientes.FocusedItem != null && lvClientes.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    var contextMenu = new ContextMenuStrip();

                    var editMenuItem = new ToolStripMenuItem("Editar");
                    editMenuItem.Click += EditarProdutoClick;
                    contextMenu.Items.Add(editMenuItem);

                    var deleteMenuItem = new ToolStripMenuItem("Deletar");
                    deleteMenuItem.ForeColor = Color.Red;
                    deleteMenuItem.Click += ExcluirProdutoClick;
                    contextMenu.Items.Add(deleteMenuItem);

                    contextMenu.Show(lvClientes, new Point(e.X, e.Y));
                }
            }
        }

        private void BtnNovoClienteClick(object sender, EventArgs e)
        {
            var cliente = new ClienteFormView();
            cliente.Show();
            cliente.FormClosed += FormClosed;
        }

        private void EditarProdutoClick(object sender, EventArgs e)
        {
            var cliente = new ClienteFormView(_idCliente);
            cliente.Show();
            cliente.FormClosed += FormClosed;
        }

        private void ExcluirProdutoClick(object sender, EventArgs e)
        {
            var cliente = Cliente.Buscar(_idCliente);
            if (cliente != null && (MessageBox.Show("Tem certeza que deseja excluir o cliente " + cliente.Nome + "?", "Deletar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes))
            {
                cliente.Deletar();
                AtualizaGrids();
                MessageBox.Show("Cliente excluído comm sucesso!");
            }
        }


        // Grupo
        private void lvGruposMouseClick(object sender, MouseEventArgs e)
        {
            _idGrupo = Convert.ToInt32(lvGrupos.SelectedItems[0].SubItems[0].Text);

            if (e.Button == MouseButtons.Right)
            {
                if (lvGrupos.FocusedItem != null && lvGrupos.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    var contextMenu = new ContextMenuStrip();

                    var editMenuItem = new ToolStripMenuItem("Editar");
                    editMenuItem.Click += EditarGrupoClick;
                    contextMenu.Items.Add(editMenuItem);

                    var deleteMenuItem = new ToolStripMenuItem("Deletar");
                    deleteMenuItem.ForeColor = Color.Red;
                    deleteMenuItem.Click += ExcluirGrupoClick;
                    contextMenu.Items.Add(deleteMenuItem);

                    contextMenu.Show(lvGrupos, new Point(e.X, e.Y));
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
            var grupo = GrupoCliente.Buscar(_idGrupo);
            if (grupo != null)
            {
                if (grupo.Clientes.Count > 0)
                {
                    MessageBox.Show("Não é possível excluir grupos relacionados a clientes!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
