namespace CrudProjeto1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            toolStrip1 = new ToolStrip();
            btnMenu = new ToolStripSplitButton();
            toolStripMenuItem1 = new ToolStripMenuItem();
            pesquisaPorCategoriaToolStripMenuItem = new ToolStripMenuItem();
            pesquisaPorQuantidadeToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeInventárioToolStripMenuItem = new ToolStripMenuItem();
            controleDeEstoqueToolStripMenuItem = new ToolStripMenuItem();
            entradaDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            entradaDeProdutosToolStripMenuItem1 = new ToolStripMenuItem();
            entradaManualToolStripMenuItem = new ToolStripMenuItem();
            saídaDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            sáidaManualToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeSaídaToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeVendasToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarProdutosToolStripMenuItem = new ToolStripMenuItem();
            exclusãoDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            statusDoProdutoToolStripMenuItem = new ToolStripMenuItem();
            medicamentosControladosToolStripMenuItem = new ToolStripMenuItem();
            antibióticosToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            tstCodbarras = new ToolStripTextBox();
            toolStripSeparator2 = new ToolStripSeparator();
            btnPesquisar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripSeparator6 = new ToolStripSeparator();
            btnSair = new ToolStripButton();
            a1ToolStripMenuItem = new ToolStripMenuItem();
            b1ToolStripMenuItem = new ToolStripMenuItem();
            b2ToolStripMenuItem = new ToolStripMenuItem();
            c1ToolStripMenuItem = new ToolStripMenuItem();
            c2ToolStripMenuItem = new ToolStripMenuItem();
            c2ToolStripMenuItem1 = new ToolStripMenuItem();
            c3ToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnMenu, toolStripSeparator1, toolStripLabel1, tstCodbarras, toolStripSeparator2, btnPesquisar, toolStripSeparator3, toolStripSeparator4, toolStripSeparator5, toolStripSeparator6, btnSair });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1202, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnMenu
            // 
            btnMenu.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMenu.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, entradaDeProdutosToolStripMenuItem, saídaDeProdutosToolStripMenuItem, cadastroDeProdutosToolStripMenuItem, medicamentosControladosToolStripMenuItem, antibióticosToolStripMenuItem });
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageTransparentColor = Color.Magenta;
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(32, 22);
            btnMenu.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { pesquisaPorCategoriaToolStripMenuItem, pesquisaPorQuantidadeToolStripMenuItem, relatórioDeInventárioToolStripMenuItem, controleDeEstoqueToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 22);
            toolStripMenuItem1.Text = "Estoque";
            // 
            // pesquisaPorCategoriaToolStripMenuItem
            // 
            pesquisaPorCategoriaToolStripMenuItem.Name = "pesquisaPorCategoriaToolStripMenuItem";
            pesquisaPorCategoriaToolStripMenuItem.Size = new Size(195, 22);
            pesquisaPorCategoriaToolStripMenuItem.Text = "Pesquisa por Categoria";
            pesquisaPorCategoriaToolStripMenuItem.Click += pesquisaPorCategoriaToolStripMenuItem_Click;
            // 
            // pesquisaPorQuantidadeToolStripMenuItem
            // 
            pesquisaPorQuantidadeToolStripMenuItem.Name = "pesquisaPorQuantidadeToolStripMenuItem";
            pesquisaPorQuantidadeToolStripMenuItem.Size = new Size(195, 22);
            pesquisaPorQuantidadeToolStripMenuItem.Text = "Relatório de inventário";
            pesquisaPorQuantidadeToolStripMenuItem.Click += pesquisaPorQuantidadeToolStripMenuItem_Click;
            // 
            // relatórioDeInventárioToolStripMenuItem
            // 
            relatórioDeInventárioToolStripMenuItem.Name = "relatórioDeInventárioToolStripMenuItem";
            relatórioDeInventárioToolStripMenuItem.Size = new Size(195, 22);
            relatórioDeInventárioToolStripMenuItem.Text = "Controle de estoque";
            relatórioDeInventárioToolStripMenuItem.Click += relatórioDeInventárioToolStripMenuItem_Click;
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            controleDeEstoqueToolStripMenuItem.Size = new Size(195, 22);
            controleDeEstoqueToolStripMenuItem.Text = "Inativos";
            controleDeEstoqueToolStripMenuItem.Click += controleDeEstoqueToolStripMenuItem_Click;
            // 
            // entradaDeProdutosToolStripMenuItem
            // 
            entradaDeProdutosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { entradaDeProdutosToolStripMenuItem1, entradaManualToolStripMenuItem });
            entradaDeProdutosToolStripMenuItem.Name = "entradaDeProdutosToolStripMenuItem";
            entradaDeProdutosToolStripMenuItem.Size = new Size(221, 22);
            entradaDeProdutosToolStripMenuItem.Text = "Entrada de produtos";
            // 
            // entradaDeProdutosToolStripMenuItem1
            // 
            entradaDeProdutosToolStripMenuItem1.Name = "entradaDeProdutosToolStripMenuItem1";
            entradaDeProdutosToolStripMenuItem1.Size = new Size(190, 22);
            entradaDeProdutosToolStripMenuItem1.Text = "Entrada de Produtos ";
            entradaDeProdutosToolStripMenuItem1.Click += entradaDeProdutosToolStripMenuItem1_Click;
            // 
            // entradaManualToolStripMenuItem
            // 
            entradaManualToolStripMenuItem.Name = "entradaManualToolStripMenuItem";
            entradaManualToolStripMenuItem.Size = new Size(190, 22);
            entradaManualToolStripMenuItem.Text = " Entrada da nota fiscal";
            entradaManualToolStripMenuItem.Click += entradaManualToolStripMenuItem_Click;
            // 
            // saídaDeProdutosToolStripMenuItem
            // 
            saídaDeProdutosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sáidaManualToolStripMenuItem, relatórioDeSaídaToolStripMenuItem, relatórioDeVendasToolStripMenuItem });
            saídaDeProdutosToolStripMenuItem.Name = "saídaDeProdutosToolStripMenuItem";
            saídaDeProdutosToolStripMenuItem.Size = new Size(221, 22);
            saídaDeProdutosToolStripMenuItem.Text = "Saída de produtos";
            // 
            // sáidaManualToolStripMenuItem
            // 
            sáidaManualToolStripMenuItem.Name = "sáidaManualToolStripMenuItem";
            sáidaManualToolStripMenuItem.Size = new Size(187, 22);
            sáidaManualToolStripMenuItem.Text = "Saída em lote";
            sáidaManualToolStripMenuItem.Click += sáidaManualToolStripMenuItem_Click;
            // 
            // relatórioDeSaídaToolStripMenuItem
            // 
            relatórioDeSaídaToolStripMenuItem.Name = "relatórioDeSaídaToolStripMenuItem";
            relatórioDeSaídaToolStripMenuItem.Size = new Size(187, 22);
            relatórioDeSaídaToolStripMenuItem.Text = "Relatório de vencidos";
            relatórioDeSaídaToolStripMenuItem.Click += relatórioDeSaídaToolStripMenuItem_Click;
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            relatórioDeVendasToolStripMenuItem.Size = new Size(187, 22);
            relatórioDeVendasToolStripMenuItem.Text = "Relatório de vendas";
            relatórioDeVendasToolStripMenuItem.Click += relatórioDeVendasToolStripMenuItem_Click;
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            cadastroDeProdutosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarProdutosToolStripMenuItem, exclusãoDeProdutosToolStripMenuItem, statusDoProdutoToolStripMenuItem });
            cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            cadastroDeProdutosToolStripMenuItem.Size = new Size(221, 22);
            cadastroDeProdutosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarProdutosToolStripMenuItem
            // 
            cadastrarProdutosToolStripMenuItem.Name = "cadastrarProdutosToolStripMenuItem";
            cadastrarProdutosToolStripMenuItem.Size = new Size(178, 22);
            cadastrarProdutosToolStripMenuItem.Text = "Cadastrar produtos";
            cadastrarProdutosToolStripMenuItem.Click += cadastrarProdutosToolStripMenuItem_Click;
            // 
            // exclusãoDeProdutosToolStripMenuItem
            // 
            exclusãoDeProdutosToolStripMenuItem.Name = "exclusãoDeProdutosToolStripMenuItem";
            exclusãoDeProdutosToolStripMenuItem.Size = new Size(178, 22);
            exclusãoDeProdutosToolStripMenuItem.Text = "Cadastrar Categoria";
            exclusãoDeProdutosToolStripMenuItem.Click += exclusãoDeProdutosToolStripMenuItem_Click;
            // 
            // statusDoProdutoToolStripMenuItem
            // 
            statusDoProdutoToolStripMenuItem.Name = "statusDoProdutoToolStripMenuItem";
            statusDoProdutoToolStripMenuItem.Size = new Size(178, 22);
            statusDoProdutoToolStripMenuItem.Text = "Status do produto";
            statusDoProdutoToolStripMenuItem.Click += statusDoProdutoToolStripMenuItem_Click;
            // 
            // medicamentosControladosToolStripMenuItem
            // 
            medicamentosControladosToolStripMenuItem.Name = "medicamentosControladosToolStripMenuItem";
            medicamentosControladosToolStripMenuItem.Size = new Size(221, 22);
            medicamentosControladosToolStripMenuItem.Text = "Medicamentos Controlados";
            medicamentosControladosToolStripMenuItem.Click += medicamentosControladosToolStripMenuItem_Click;
            // 
            // antibióticosToolStripMenuItem
            // 
            antibióticosToolStripMenuItem.Name = "antibióticosToolStripMenuItem";
            antibióticosToolStripMenuItem.Size = new Size(221, 22);
            antibióticosToolStripMenuItem.Text = "Antibióticos";
            antibióticosToolStripMenuItem.Click += antibióticosToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(123, 22);
            toolStripLabel1.Text = "Código de barras:";
            // 
            // tstCodbarras
            // 
            tstCodbarras.BorderStyle = BorderStyle.FixedSingle;
            tstCodbarras.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tstCodbarras.MaxLength = 20;
            tstCodbarras.Name = "tstCodbarras";
            tstCodbarras.Size = new Size(130, 25);
            tstCodbarras.Click += tstCodbarras_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnPesquisar
            // 
            btnPesquisar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.ImageTransparentColor = Color.Magenta;
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(23, 22);
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // btnSair
            // 
            btnSair.Alignment = ToolStripItemAlignment.Right;
            btnSair.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageTransparentColor = Color.Magenta;
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(23, 22);
            btnSair.Text = "Saír";
            btnSair.Click += toolStripButton5_Click;
            // 
            // a1ToolStripMenuItem
            // 
            a1ToolStripMenuItem.Name = "a1ToolStripMenuItem";
            a1ToolStripMenuItem.Size = new Size(180, 22);
            a1ToolStripMenuItem.Text = "A1";
            // 
            // b1ToolStripMenuItem
            // 
            b1ToolStripMenuItem.Name = "b1ToolStripMenuItem";
            b1ToolStripMenuItem.Size = new Size(180, 22);
            b1ToolStripMenuItem.Text = "A2";
            // 
            // b2ToolStripMenuItem
            // 
            b2ToolStripMenuItem.Name = "b2ToolStripMenuItem";
            b2ToolStripMenuItem.Size = new Size(180, 22);
            b2ToolStripMenuItem.Text = "A3";
            // 
            // c1ToolStripMenuItem
            // 
            c1ToolStripMenuItem.Name = "c1ToolStripMenuItem";
            c1ToolStripMenuItem.Size = new Size(180, 22);
            c1ToolStripMenuItem.Text = "B1";
            // 
            // c2ToolStripMenuItem
            // 
            c2ToolStripMenuItem.Name = "c2ToolStripMenuItem";
            c2ToolStripMenuItem.Size = new Size(180, 22);
            c2ToolStripMenuItem.Text = "B2";
            // 
            // c2ToolStripMenuItem1
            // 
            c2ToolStripMenuItem1.Name = "c2ToolStripMenuItem1";
            c2ToolStripMenuItem1.Size = new Size(180, 22);
            c2ToolStripMenuItem1.Text = "C2";
            // 
            // c3ToolStripMenuItem
            // 
            c3ToolStripMenuItem.Name = "c3ToolStripMenuItem";
            c3ToolStripMenuItem.Size = new Size(180, 22);
            c3ToolStripMenuItem.Text = "C3";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1202, 633);
            Controls.Add(toolStrip1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form2_FormClosing;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox tstCodbarras;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnPesquisar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton btnSair;
        private ToolStripSplitButton btnMenu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem entradaDeProdutosToolStripMenuItem;
        private ToolStripMenuItem saídaDeProdutosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private ToolStripMenuItem antibióticosToolStripMenuItem;
        private ToolStripMenuItem cadastrarProdutosToolStripMenuItem;
        private ToolStripMenuItem exclusãoDeProdutosToolStripMenuItem;
        private ToolStripMenuItem pesquisaPorCategoriaToolStripMenuItem;
        private ToolStripMenuItem pesquisaPorQuantidadeToolStripMenuItem;
        private ToolStripMenuItem relatórioDeInventárioToolStripMenuItem;
        private ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private ToolStripMenuItem entradaDeProdutosToolStripMenuItem1;
        private ToolStripMenuItem entradaManualToolStripMenuItem;
        private ToolStripMenuItem sáidaManualToolStripMenuItem;
        private ToolStripMenuItem relatórioDeSaídaToolStripMenuItem;
        private ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private ToolStripMenuItem statusDoProdutoToolStripMenuItem;
        private ToolStripMenuItem medicamentosControladosToolStripMenuItem;
        private ToolStripMenuItem a1ToolStripMenuItem;
        private ToolStripMenuItem b1ToolStripMenuItem;
        private ToolStripMenuItem b2ToolStripMenuItem;
        private ToolStripMenuItem c1ToolStripMenuItem;
        private ToolStripMenuItem c2ToolStripMenuItem;
        private ToolStripMenuItem c2ToolStripMenuItem1;
        private ToolStripMenuItem c3ToolStripMenuItem;
    }
}