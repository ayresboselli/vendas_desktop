namespace Vendas.Views.Clientes
{
    partial class ClientesView
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
            tabPage1 = new TabPage();
            btnNovoCliente = new Button();
            lvClientes = new ListView();
            tabPage2 = new TabPage();
            lvGrupos = new ListView();
            btnNovoGrupo = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(4, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 434);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnNovoCliente);
            tabPage1.Controls.Add(lvClientes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(786, 406);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Clientes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNovoCliente
            // 
            btnNovoCliente.Location = new Point(4, 6);
            btnNovoCliente.Name = "btnNovoCliente";
            btnNovoCliente.Size = new Size(75, 23);
            btnNovoCliente.TabIndex = 1;
            btnNovoCliente.Text = "Novo";
            btnNovoCliente.UseVisualStyleBackColor = true;
            btnNovoCliente.Click += BtnNovoClienteClick;
            // 
            // lvClientes
            // 
            lvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvClientes.FullRowSelect = true;
            lvClientes.Location = new Point(6, 35);
            lvClientes.Name = "lvClientes";
            lvClientes.Size = new Size(774, 365);
            lvClientes.TabIndex = 0;
            lvClientes.UseCompatibleStateImageBehavior = false;
            lvClientes.View = View.Details;
            lvClientes.MouseClick += LvClienteMouseClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lvGrupos);
            tabPage2.Controls.Add(btnNovoGrupo);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 406);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Grupos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvGrupos
            // 
            lvGrupos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvGrupos.FullRowSelect = true;
            lvGrupos.Location = new Point(6, 35);
            lvGrupos.Name = "lvGrupos";
            lvGrupos.Size = new Size(774, 365);
            lvGrupos.TabIndex = 1;
            lvGrupos.UseCompatibleStateImageBehavior = false;
            lvGrupos.View = View.Details;
            lvGrupos.MouseClick += lvGruposMouseClick;
            // 
            // btnNovoGrupo
            // 
            btnNovoGrupo.Location = new Point(6, 6);
            btnNovoGrupo.Name = "btnNovoGrupo";
            btnNovoGrupo.Size = new Size(75, 23);
            btnNovoGrupo.TabIndex = 0;
            btnNovoGrupo.Text = "Novo";
            btnNovoGrupo.UseVisualStyleBackColor = true;
            btnNovoGrupo.Click += BtnNovoGrupoClick;
            // 
            // ClientesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "ClientesView";
            Text = "Clientes";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnNovoCliente;
        private ListView lvClientes;
        private ListView lvGrupos;
        private Button btnNovoGrupo;
    }
}