using static System.Windows.Forms.DataFormats;

namespace Vendas.Views.Clientes
{
    partial class ClienteFormView
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
            label1 = new Label();
            lbDocumento = new Label();
            lbNome = new Label();
            lbApelido = new Label();
            lbDataNascimento = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            cbTipoPessoa = new ComboBox();
            tbDocumento = new TextBox();
            tbNome = new TextBox();
            tbApelido = new TextBox();
            chkAtivo = new CheckBox();
            tbEmail = new TextBox();
            tbTelefone = new TextBox();
            tbCep = new TextBox();
            tbLogradouro = new TextBox();
            tbNumero = new TextBox();
            tbComplemento = new TextBox();
            tbBairro = new TextBox();
            cbEstado = new ComboBox();
            label11 = new Label();
            tbId = new TextBox();
            label12 = new Label();
            lbGupo = new Label();
            dtDataNascimento = new DateTimePicker();
            cbCidades = new ComboBox();
            cbGrupo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 14);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de pessoa";
            // 
            // lbDocumento
            // 
            lbDocumento.AutoSize = true;
            lbDocumento.Location = new Point(268, 14);
            lbDocumento.Name = "lbDocumento";
            lbDocumento.Size = new Size(28, 15);
            lbDocumento.TabIndex = 1;
            lbDocumento.Text = "CPF";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(12, 73);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(94, 15);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome completo";
            // 
            // lbApelido
            // 
            lbApelido.AutoSize = true;
            lbApelido.Location = new Point(399, 73);
            lbApelido.Name = "lbApelido";
            lbApelido.Size = new Size(48, 15);
            lbApelido.TabIndex = 3;
            lbApelido.Text = "Apelido";
            // 
            // lbDataNascimento
            // 
            lbDataNascimento.AutoSize = true;
            lbDataNascimento.Location = new Point(456, 14);
            lbDataNascimento.Name = "lbDataNascimento";
            lbDataNascimento.Size = new Size(112, 15);
            lbDataNascimento.TabIndex = 4;
            lbDataNascimento.Text = "Data de nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 136);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 203);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "CEP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 203);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 8;
            label5.Text = "Logradouro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(505, 203);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 9;
            label6.Text = "Número";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(626, 203);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 10;
            label7.Text = "Complemento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 269);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 11;
            label8.Text = "Bairro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(372, 269);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 12;
            label9.Text = "Estado";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(505, 269);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 13;
            label10.Text = "Cidade";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(224, 358);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(85, 38);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvarClick;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(445, 358);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 38);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelarClick;
            // 
            // cbTipoPessoa
            // 
            cbTipoPessoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoPessoa.FormattingEnabled = true;
            cbTipoPessoa.Items.AddRange(new object[] { "Física", "Jurídica" });
            cbTipoPessoa.Location = new Point(130, 32);
            cbTipoPessoa.Name = "cbTipoPessoa";
            cbTipoPessoa.Size = new Size(121, 23);
            cbTipoPessoa.TabIndex = 17;
            cbTipoPessoa.SelectedIndexChanged += CbTipoPessoaSelectedIndexChanged;
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(268, 32);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(170, 23);
            tbDocumento.TabIndex = 18;
            tbDocumento.TextChanged += TbDocumentoTextChanged;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(14, 91);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(366, 23);
            tbNome.TabIndex = 19;
            // 
            // tbApelido
            // 
            tbApelido.Location = new Point(399, 91);
            tbApelido.Name = "tbApelido";
            tbApelido.Size = new Size(389, 23);
            tbApelido.TabIndex = 20;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(641, 34);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 22;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(12, 154);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(239, 23);
            tbEmail.TabIndex = 23;
            // 
            // tbTelefone
            // 
            tbTelefone.Location = new Point(268, 154);
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(241, 23);
            tbTelefone.TabIndex = 24;
            tbTelefone.MaxLength = 15;
            tbTelefone.TextChanged += TbTelefoneTextChanged;
            // 
            // tbCep
            // 
            tbCep.Location = new Point(12, 221);
            tbCep.Name = "tbCep";
            tbCep.Size = new Size(121, 23);
            tbCep.TabIndex = 25;
            // 
            // tbLogradouro
            // 
            tbLogradouro.Location = new Point(149, 221);
            tbLogradouro.Name = "tbLogradouro";
            tbLogradouro.Size = new Size(344, 23);
            tbLogradouro.TabIndex = 26;
            // 
            // tbNumero
            // 
            tbNumero.Location = new Point(505, 221);
            tbNumero.Name = "tbNumero";
            tbNumero.Size = new Size(100, 23);
            tbNumero.TabIndex = 27;
            // 
            // tbComplemento
            // 
            tbComplemento.Location = new Point(626, 221);
            tbComplemento.Name = "tbComplemento";
            tbComplemento.Size = new Size(162, 23);
            tbComplemento.TabIndex = 28;
            // 
            // tbBairro
            // 
            tbBairro.Location = new Point(12, 287);
            tbBairro.Name = "tbBairro";
            tbBairro.Size = new Size(344, 23);
            tbBairro.TabIndex = 29;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(372, 287);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(121, 23);
            cbEstado.TabIndex = 30;
            cbEstado.SelectedIndexChanged += CbEstadoSelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 14);
            label11.Name = "label11";
            label11.Size = new Size(17, 15);
            label11.TabIndex = 32;
            label11.Text = "Id";
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Location = new Point(12, 32);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(526, 136);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 34;
            label12.Text = "Grupo";
            // 
            // lbGupo
            // 
            lbGupo.AutoSize = true;
            lbGupo.Location = new Point(573, 157);
            lbGupo.Name = "lbGupo";
            lbGupo.Size = new Size(0, 15);
            lbGupo.TabIndex = 36;
            // 
            // dtDataNascimento
            // 
            dtDataNascimento.CustomFormat = "dd/MM/yyyy";
            dtDataNascimento.Format = DateTimePickerFormat.Custom;
            dtDataNascimento.Location = new Point(456, 32);
            dtDataNascimento.Name = "dtDataNascimento";
            dtDataNascimento.Size = new Size(149, 23);
            dtDataNascimento.TabIndex = 37;
            // 
            // cbCidades
            // 
            cbCidades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCidades.FormattingEnabled = true;
            cbCidades.Location = new Point(505, 287);
            cbCidades.Name = "cbCidades";
            cbCidades.Size = new Size(283, 23);
            cbCidades.TabIndex = 38;
            // 
            // cbGrupo
            // 
            cbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrupo.FormattingEnabled = true;
            cbGrupo.Location = new Point(526, 154);
            cbGrupo.Name = "cbGrupo";
            cbGrupo.Size = new Size(262, 23);
            cbGrupo.TabIndex = 39;
            // 
            // ClienteFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbGrupo);
            Controls.Add(cbCidades);
            Controls.Add(dtDataNascimento);
            Controls.Add(lbGupo);
            Controls.Add(label12);
            Controls.Add(tbId);
            Controls.Add(label11);
            Controls.Add(cbEstado);
            Controls.Add(tbBairro);
            Controls.Add(tbComplemento);
            Controls.Add(tbNumero);
            Controls.Add(tbLogradouro);
            Controls.Add(tbCep);
            Controls.Add(tbTelefone);
            Controls.Add(tbEmail);
            Controls.Add(chkAtivo);
            Controls.Add(tbApelido);
            Controls.Add(tbNome);
            Controls.Add(tbDocumento);
            Controls.Add(cbTipoPessoa);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbDataNascimento);
            Controls.Add(lbApelido);
            Controls.Add(lbNome);
            Controls.Add(lbDocumento);
            Controls.Add(label1);
            Name = "ClienteFormView";
            Text = "Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbDocumento;
        private Label lbNome;
        private Label lbApelido;
        private Label lbDataNascimento;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnSalvar;
        private Button btnCancelar;
        private ComboBox cbTipoPessoa;
        private TextBox tbDocumento;
        private TextBox tbNome;
        private TextBox tbApelido;
        private CheckBox chkAtivo;
        private TextBox tbEmail;
        private TextBox tbTelefone;
        private TextBox tbCep;
        private TextBox tbLogradouro;
        private TextBox tbNumero;
        private TextBox tbComplemento;
        private TextBox tbBairro;
        private ComboBox cbEstado;
        private Label label11;
        private TextBox tbId;
        private Label label12;
        private Label lbGupo;
        private DateTimePicker dtDataNascimento;
        private ComboBox cbCidades;
        private ComboBox cbGrupo;
    }
}