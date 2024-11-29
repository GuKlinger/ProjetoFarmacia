namespace CrudProjeto1
{
    partial class menuCadastroCategorias
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
            label9 = new Label();
            txtSubcategoria = new TextBox();
            txtCategoria = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtObservação = new TextBox();
            btnLimpar = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(12, 28);
            label9.Name = "label9";
            label9.Size = new Size(386, 45);
            label9.TabIndex = 17;
            label9.Text = "Cadastro de Categorias";
            // 
            // txtSubcategoria
            // 
            txtSubcategoria.Location = new Point(417, 134);
            txtSubcategoria.Name = "txtSubcategoria";
            txtSubcategoria.Size = new Size(412, 23);
            txtSubcategoria.TabIndex = 18;
            txtSubcategoria.TextChanged += textBox1_TextChanged;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(12, 134);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(403, 23);
            txtCategoria.TabIndex = 19;
            txtCategoria.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 20;
            label1.Text = "Categoria principal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(417, 108);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 21;
            label2.Text = "Subcategoria:";
            label2.Click += label2_Click;
            // 
            // txtObservação
            // 
            txtObservação.BackColor = Color.FromArgb(64, 64, 64);
            txtObservação.CausesValidation = false;
            txtObservação.Enabled = false;
            txtObservação.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtObservação.ForeColor = SystemColors.Window;
            txtObservação.Location = new Point(12, 340);
            txtObservação.Name = "txtObservação";
            txtObservação.ReadOnly = true;
            txtObservação.Size = new Size(817, 24);
            txtObservação.TabIndex = 22;
            txtObservação.Text = "Observação: A categoria irá ser usada para pesquisas no sistema, inventário e outras finalidades, cadastre o mais fiel possível.";
            txtObservação.TextAlign = HorizontalAlignment.Center;
            txtObservação.TextChanged += textBox3_TextChanged;
            // 
            // btnLimpar
            // 
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.Location = new Point(535, 392);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 36);
            btnLimpar.TabIndex = 24;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(735, 392);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 36);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Location = new Point(635, 392);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 36);
            btnSalvar.TabIndex = 25;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // menuCadastroCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(841, 450);
            Controls.Add(btnLimpar);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtObservação);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCategoria);
            Controls.Add(txtSubcategoria);
            Controls.Add(label9);
            Name = "menuCadastroCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Categorias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox txtSubcategoria;
        private TextBox txtCategoria;
        private Label label1;
        private Label label2;
        private TextBox txtObservação;
        private Button btnLimpar;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}