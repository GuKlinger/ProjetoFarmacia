namespace CrudProjeto1
{
    partial class menuCadastroProduto
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
            txtSku = new TextBox();
            txtDescricao = new TextBox();
            cboxCategoria = new ComboBox();
            cboxStatus = new ComboBox();
            cboxQuantidade = new ComboBox();
            txtBase = new TextBox();
            txtVenda = new TextBox();
            txtDesconto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // txtSku
            // 
            txtSku.Location = new Point(12, 134);
            txtSku.Name = "txtSku";
            txtSku.Size = new Size(269, 23);
            txtSku.TabIndex = 0;
            txtSku.TextChanged += textBox1_TextChanged;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(287, 134);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(542, 23);
            txtDescricao.TabIndex = 1;
            txtDescricao.TextChanged += textBox2_TextChanged;
            // 
            // cboxCategoria
            // 
            cboxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxCategoria.FormattingEnabled = true;
            cboxCategoria.Location = new Point(12, 218);
            cboxCategoria.Name = "cboxCategoria";
            cboxCategoria.Size = new Size(269, 23);
            cboxCategoria.TabIndex = 2;
            cboxCategoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cboxStatus
            // 
            cboxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxStatus.FormattingEnabled = true;
            cboxStatus.Location = new Point(287, 218);
            cboxStatus.Name = "cboxStatus";
            cboxStatus.Size = new Size(269, 23);
            cboxStatus.TabIndex = 3;
            cboxStatus.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cboxQuantidade
            // 
            cboxQuantidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxQuantidade.FormattingEnabled = true;
            cboxQuantidade.Location = new Point(562, 218);
            cboxQuantidade.Name = "cboxQuantidade";
            cboxQuantidade.Size = new Size(267, 23);
            cboxQuantidade.TabIndex = 4;
            cboxQuantidade.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(12, 309);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(269, 23);
            txtBase.TabIndex = 5;
            // 
            // txtVenda
            // 
            txtVenda.Location = new Point(287, 309);
            txtVenda.Name = "txtVenda";
            txtVenda.Size = new Size(269, 23);
            txtVenda.TabIndex = 6;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(562, 309);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(267, 23);
            txtDesconto.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(151, 17);
            label1.TabIndex = 1000;
            label1.Text = "SKU (Código de Barras):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(287, 114);
            label2.Name = "label2";
            label2.Size = new Size(142, 17);
            label2.TabIndex = 2000;
            label2.Text = "Descrição do produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 198);
            label3.Name = "label3";
            label3.Size = new Size(143, 17);
            label3.TabIndex = 3000;
            label3.Text = "Categoria do produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(287, 198);
            label4.Name = "label4";
            label4.Size = new Size(123, 17);
            label4.TabIndex = 4000;
            label4.Text = "Status do produto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(562, 198);
            label5.Name = "label5";
            label5.Size = new Size(160, 17);
            label5.TabIndex = 5000;
            label5.Text = "Quantidade por unidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(12, 289);
            label6.Name = "label6";
            label6.Size = new Size(73, 17);
            label6.TabIndex = 6000;
            label6.Text = "Valor base:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(287, 289);
            label7.Name = "label7";
            label7.Size = new Size(101, 17);
            label7.TabIndex = 7000;
            label7.Text = "Valor de venda:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(562, 289);
            label8.Name = "label8";
            label8.Size = new Size(184, 17);
            label8.TabIndex = 8000;
            label8.Text = "Valor com desconto máximo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(12, 28);
            label9.Name = "label9";
            label9.Size = new Size(356, 45);
            label9.TabIndex = 16;
            label9.Text = "Cadastro de Produtos";
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Location = new Point(635, 392);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 36);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(735, 392);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 36);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.Location = new Point(535, 392);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 36);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // menuCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(841, 450);
            Controls.Add(btnLimpar);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDesconto);
            Controls.Add(txtVenda);
            Controls.Add(txtBase);
            Controls.Add(cboxQuantidade);
            Controls.Add(cboxStatus);
            Controls.Add(cboxCategoria);
            Controls.Add(txtDescricao);
            Controls.Add(txtSku);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "menuCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de produtos";
            Load += menuCadastroProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSku;
        private TextBox txtDescricao;
        private ComboBox cboxCategoria;
        private ComboBox cboxStatus;
        private ComboBox cboxQuantidade;
        private TextBox txtBase;
        private TextBox txtVenda;
        private TextBox txtDesconto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnLimpar;
    }
}