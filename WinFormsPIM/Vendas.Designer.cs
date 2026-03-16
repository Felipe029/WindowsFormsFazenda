namespace WinFormsPIM
{
    partial class Vendas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoPessoaLabel;
            System.Windows.Forms.Label codigoVendaLabel1;
            System.Windows.Forms.Label codigoProdutoLabel1;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valorPagoLabel;
            System.Windows.Forms.Label codigoStatusLabel;
            System.Windows.Forms.Label dataVencimentoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.TxtDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.contaAReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CboStatus = new System.Windows.Forms.ComboBox();
            this.statusDePagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFDP = new System.Windows.Forms.Button();
            this.btnFV = new System.Windows.Forms.Button();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtValorItens = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.itemVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.CboProduto = new System.Windows.Forms.ComboBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.DtvItens = new System.Windows.Forms.DataGridView();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.CboPessoa = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazendaDataSet = new WinFormsPIM.FazendaDataSet();
            this.clientesTableAdapter = new WinFormsPIM.FazendaDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new WinFormsPIM.FazendaDataSetTableAdapters.TableAdapterManager();
            codigoPessoaLabel = new System.Windows.Forms.Label();
            codigoVendaLabel1 = new System.Windows.Forms.Label();
            codigoProdutoLabel1 = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valorPagoLabel = new System.Windows.Forms.Label();
            codigoStatusLabel = new System.Windows.Forms.Label();
            dataVencimentoLabel = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaAReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDePagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            codigoPessoaLabel.ForeColor = System.Drawing.Color.White;
            codigoPessoaLabel.Location = new System.Drawing.Point(115, 26);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(57, 18);
            codigoPessoaLabel.TabIndex = 9;
            codigoPessoaLabel.Text = "Cliente:";
            // 
            // codigoVendaLabel1
            // 
            codigoVendaLabel1.AutoSize = true;
            codigoVendaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            codigoVendaLabel1.ForeColor = System.Drawing.Color.Black;
            codigoVendaLabel1.Location = new System.Drawing.Point(61, 35);
            codigoVendaLabel1.Name = "codigoVendaLabel1";
            codigoVendaLabel1.Size = new System.Drawing.Size(87, 15);
            codigoVendaLabel1.TabIndex = 10;
            codigoVendaLabel1.Text = "Codigo Venda:";
            // 
            // codigoProdutoLabel1
            // 
            codigoProdutoLabel1.AutoSize = true;
            codigoProdutoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            codigoProdutoLabel1.ForeColor = System.Drawing.Color.Black;
            codigoProdutoLabel1.Location = new System.Drawing.Point(95, 65);
            codigoProdutoLabel1.Name = "codigoProdutoLabel1";
            codigoProdutoLabel1.Size = new System.Drawing.Size(53, 15);
            codigoProdutoLabel1.TabIndex = 11;
            codigoProdutoLabel1.Text = "Produto:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            quantidadeLabel.ForeColor = System.Drawing.Color.Black;
            quantidadeLabel.Location = new System.Drawing.Point(74, 96);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(74, 15);
            quantidadeLabel.TabIndex = 12;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            valorLabel.ForeColor = System.Drawing.Color.Black;
            valorLabel.Location = new System.Drawing.Point(103, 128);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(38, 15);
            valorLabel.TabIndex = 13;
            valorLabel.Text = "Valor:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            valorLabel1.ForeColor = System.Drawing.Color.Black;
            valorLabel1.Location = new System.Drawing.Point(177, 393);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(38, 15);
            valorLabel1.TabIndex = 14;
            valorLabel1.Text = "Valor:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            descontoLabel.ForeColor = System.Drawing.Color.Black;
            descontoLabel.Location = new System.Drawing.Point(153, 422);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(62, 15);
            descontoLabel.TabIndex = 15;
            descontoLabel.Text = "Desconto:";
            // 
            // valorPagoLabel
            // 
            valorPagoLabel.AutoSize = true;
            valorPagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            valorPagoLabel.ForeColor = System.Drawing.Color.Black;
            valorPagoLabel.Location = new System.Drawing.Point(147, 449);
            valorPagoLabel.Name = "valorPagoLabel";
            valorPagoLabel.Size = new System.Drawing.Size(68, 15);
            valorPagoLabel.TabIndex = 16;
            valorPagoLabel.Text = "Valor Final:";
            // 
            // codigoStatusLabel
            // 
            codigoStatusLabel.AutoSize = true;
            codigoStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            codigoStatusLabel.ForeColor = System.Drawing.Color.Black;
            codigoStatusLabel.Location = new System.Drawing.Point(417, 392);
            codigoStatusLabel.Name = "codigoStatusLabel";
            codigoStatusLabel.Size = new System.Drawing.Size(130, 15);
            codigoStatusLabel.TabIndex = 20;
            codigoStatusLabel.Text = "Forma de Pagamento:";
            // 
            // dataVencimentoLabel
            // 
            dataVencimentoLabel.AutoSize = true;
            dataVencimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataVencimentoLabel.Location = new System.Drawing.Point(426, 424);
            dataVencimentoLabel.Name = "dataVencimentoLabel";
            dataVencimentoLabel.Size = new System.Drawing.Size(121, 15);
            dataVencimentoLabel.TabIndex = 22;
            dataVencimentoLabel.Text = "Data de Vencimento:";
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovaVenda.Location = new System.Drawing.Point(427, 22);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(105, 27);
            this.btnNovaVenda.TabIndex = 3;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.BtnFinalizar);
            this.groupBox.Controls.Add(dataVencimentoLabel);
            this.groupBox.Controls.Add(this.TxtDataVencimento);
            this.groupBox.Controls.Add(codigoStatusLabel);
            this.groupBox.Controls.Add(this.CboStatus);
            this.groupBox.Controls.Add(this.btnExcluir);
            this.groupBox.Controls.Add(this.btnFDP);
            this.groupBox.Controls.Add(this.btnFV);
            this.groupBox.Controls.Add(valorPagoLabel);
            this.groupBox.Controls.Add(this.txtValorPago);
            this.groupBox.Controls.Add(descontoLabel);
            this.groupBox.Controls.Add(this.txtDesconto);
            this.groupBox.Controls.Add(valorLabel1);
            this.groupBox.Controls.Add(this.txtValorItens);
            this.groupBox.Controls.Add(valorLabel);
            this.groupBox.Controls.Add(this.txtValor);
            this.groupBox.Controls.Add(quantidadeLabel);
            this.groupBox.Controls.Add(this.txtQuantidade);
            this.groupBox.Controls.Add(codigoProdutoLabel1);
            this.groupBox.Controls.Add(this.CboProduto);
            this.groupBox.Controls.Add(codigoVendaLabel1);
            this.groupBox.Controls.Add(this.txtCodigoVenda);
            this.groupBox.Controls.Add(this.DtvItens);
            this.groupBox.Controls.Add(this.btnNovoItem);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(1, 59);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(690, 508);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Nova Venda";
            this.groupBox.Visible = false;
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Enabled = false;
            this.BtnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnFinalizar.Location = new System.Drawing.Point(553, 450);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(121, 25);
            this.BtnFinalizar.TabIndex = 24;
            this.BtnFinalizar.Text = "Finalizar";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // TxtDataVencimento
            // 
            this.TxtDataVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contaAReceberBindingSource, "DataVencimento", true));
            this.TxtDataVencimento.Enabled = false;
            this.TxtDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TxtDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtDataVencimento.Location = new System.Drawing.Point(553, 421);
            this.TxtDataVencimento.Name = "TxtDataVencimento";
            this.TxtDataVencimento.Size = new System.Drawing.Size(121, 21);
            this.TxtDataVencimento.TabIndex = 23;
            // 
            // contaAReceberBindingSource
            // 
            this.contaAReceberBindingSource.DataSource = typeof(Info.DAL.ContaAReceber);
            // 
            // CboStatus
            // 
            this.CboStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contaAReceberBindingSource, "CodigoStatus", true));
            this.CboStatus.DataSource = this.statusDePagamentoBindingSource;
            this.CboStatus.DisplayMember = "Status";
            this.CboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboStatus.Enabled = false;
            this.CboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CboStatus.FormattingEnabled = true;
            this.CboStatus.Location = new System.Drawing.Point(553, 389);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(121, 23);
            this.CboStatus.TabIndex = 21;
            this.CboStatus.ValueMember = "CodigoStatus";
            this.CboStatus.SelectedIndexChanged += new System.EventHandler(this.CboStatus_SelectedIndexChanged);
            // 
            // statusDePagamentoBindingSource
            // 
            this.statusDePagamentoBindingSource.DataSource = typeof(Info.DAL.StatusDePagamento);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(405, 123);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 27);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir Item";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFDP
            // 
            this.btnFDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFDP.ForeColor = System.Drawing.Color.Black;
            this.btnFDP.Location = new System.Drawing.Point(18, 404);
            this.btnFDP.Name = "btnFDP";
            this.btnFDP.Size = new System.Drawing.Size(120, 25);
            this.btnFDP.TabIndex = 18;
            this.btnFDP.Text = "Finalizar Pedido";
            this.btnFDP.UseVisualStyleBackColor = true;
            this.btnFDP.Click += new System.EventHandler(this.btnFDP_Click_1);
            // 
            // btnFV
            // 
            this.btnFV.Enabled = false;
            this.btnFV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFV.ForeColor = System.Drawing.Color.Black;
            this.btnFV.Location = new System.Drawing.Point(18, 433);
            this.btnFV.Name = "btnFV";
            this.btnFV.Size = new System.Drawing.Size(120, 25);
            this.btnFV.TabIndex = 18;
            this.btnFV.Text = "Finalizar Venda";
            this.btnFV.UseVisualStyleBackColor = true;
            this.btnFV.Click += new System.EventHandler(this.btnFV_Click);
            // 
            // txtValorPago
            // 
            this.txtValorPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true));
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtValorPago.Location = new System.Drawing.Point(220, 446);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.ReadOnly = true;
            this.txtValorPago.Size = new System.Drawing.Size(111, 21);
            this.txtValorPago.TabIndex = 17;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(Info.DAL.Venda);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDesconto.Location = new System.Drawing.Point(220, 418);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(111, 21);
            this.txtDesconto.TabIndex = 16;
            this.txtDesconto.Text = "0";
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // txtValorItens
            // 
            this.txtValorItens.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.txtValorItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtValorItens.Location = new System.Drawing.Point(220, 389);
            this.txtValorItens.Name = "txtValorItens";
            this.txtValorItens.ReadOnly = true;
            this.txtValorItens.Size = new System.Drawing.Size(111, 21);
            this.txtValorItens.TabIndex = 15;
            // 
            // txtValor
            // 
            this.txtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemVendaBindingSource, "Valor", true));
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtValor.Location = new System.Drawing.Point(154, 125);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(132, 21);
            this.txtValor.TabIndex = 14;
            // 
            // itemVendaBindingSource
            // 
            this.itemVendaBindingSource.DataSource = typeof(Info.DAL.ItemVenda);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemVendaBindingSource, "Quantidade", true));
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtQuantidade.Location = new System.Drawing.Point(154, 94);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(133, 21);
            this.txtQuantidade.TabIndex = 13;
            // 
            // CboProduto
            // 
            this.CboProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemVendaBindingSource, "Nome", true));
            this.CboProduto.DataSource = this.produtosBindingSource;
            this.CboProduto.DisplayMember = "Nome";
            this.CboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CboProduto.FormattingEnabled = true;
            this.CboProduto.Location = new System.Drawing.Point(154, 62);
            this.CboProduto.Name = "CboProduto";
            this.CboProduto.Size = new System.Drawing.Size(177, 23);
            this.CboProduto.TabIndex = 12;
            this.CboProduto.ValueMember = "Nome";
            this.CboProduto.SelectedIndexChanged += new System.EventHandler(this.CboProduto_SelectedIndexChanged);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataSource = typeof(Info.DAL.Produtos);
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CodigoVenda", true));
            this.txtCodigoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCodigoVenda.Location = new System.Drawing.Point(154, 32);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.ReadOnly = true;
            this.txtCodigoVenda.Size = new System.Drawing.Size(133, 21);
            this.txtCodigoVenda.TabIndex = 11;
            // 
            // DtvItens
            // 
            this.DtvItens.AllowUserToAddRows = false;
            this.DtvItens.AllowUserToDeleteRows = false;
            this.DtvItens.AutoGenerateColumns = false;
            this.DtvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProduto,
            this.Nome,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.DtvItens.DataSource = this.itemVendaBindingSource;
            this.DtvItens.Location = new System.Drawing.Point(14, 171);
            this.DtvItens.Name = "DtvItens";
            this.DtvItens.ReadOnly = true;
            this.DtvItens.Size = new System.Drawing.Size(660, 201);
            this.DtvItens.TabIndex = 9;
            this.DtvItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtvItens_CellFormatting);
            // 
            // CodigoProduto
            // 
            this.CodigoProduto.DataPropertyName = "CodigoProduto";
            this.CodigoProduto.HeaderText = "Código";
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.ReadOnly = true;
            this.CodigoProduto.Width = 70;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Produto";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 158;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 123;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 133;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 133;
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.ForeColor = System.Drawing.Color.Black;
            this.btnNovoItem.Location = new System.Drawing.Point(294, 123);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(105, 27);
            this.btnNovoItem.TabIndex = 9;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // CboPessoa
            // 
            this.CboPessoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoPessoa", true));
            this.CboPessoa.DataSource = this.clientesBindingSource;
            this.CboPessoa.DisplayMember = "Nome";
            this.CboPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CboPessoa.FormattingEnabled = true;
            this.CboPessoa.Location = new System.Drawing.Point(178, 23);
            this.CboPessoa.Name = "CboPessoa";
            this.CboPessoa.Size = new System.Drawing.Size(243, 26);
            this.CboPessoa.TabIndex = 10;
            this.CboPessoa.ValueMember = "Id";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.fazendaDataSet;
            // 
            // fazendaDataSet
            // 
            this.fazendaDataSet.DataSetName = "FazendaDataSet";
            this.fazendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WinFormsPIM.FazendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(692, 567);
            this.Controls.Add(codigoPessoaLabel);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.CboPessoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaAReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDePagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox CboPessoa;
        private FazendaDataSet fazendaDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private FazendaDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private FazendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView DtvItens;
        private System.Windows.Forms.BindingSource itemVendaBindingSource;
        private System.Windows.Forms.TextBox txtCodigoVenda;
        private System.Windows.Forms.ComboBox CboProduto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtValorItens;
        private System.Windows.Forms.Button btnFDP;
        private System.Windows.Forms.Button btnFV;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox CboStatus;
        private System.Windows.Forms.BindingSource contaAReceberBindingSource;
        private System.Windows.Forms.DateTimePicker TxtDataVencimento;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.BindingSource statusDePagamentoBindingSource;
    }
}