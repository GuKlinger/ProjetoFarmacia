namespace ProjetoFarmacia
{
    partial class Form1
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
            label1 = new Label();
            txtCategoria = new TextBox();
            txtObservação = new TextBox();
            btnLimpar = new Button();
            btnCancelar = new Button();
            btnSalvar = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(12, 28);
            label9.Name = "label9";
            label9.Size = new Size(326, 45);
            label9.TabIndex = 18;
            label9.Text = "Cadastro de Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 24;
            label1.Text = "Status";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(12, 134);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(403, 23);
            txtCategoria.TabIndex = 23;
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
            txtObservação.TabIndex = 25;
            txtObservação.Text = "Observação: Cadastrar os Status conforme a situação do produto com a loja e o mercado. Ex.: Inativo, Ativo, Em falta e etc...";
            txtObservação.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.Location = new Point(535, 392);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 36);
            btnLimpar.TabIndex = 27;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(735, 392);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 36);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Location = new Point(635, 392);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 36);
            btnSalvar.TabIndex = 28;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(446, 134);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 27);
            checkBox1.TabIndex = 30;
            checkBox1.Text = "Ativo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(841, 450);
            Controls.Add(checkBox1);
            Controls.Add(btnLimpar);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtObservação);
            Controls.Add(label1);
            Controls.Add(txtCategoria);
            Controls.Add(label9);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private TextBox txtCategoria;
        private TextBox txtObservação;
        private Button btnLimpar;
        private Button btnCancelar;
        private Button btnSalvar;
        private CheckBox checkBox1;
    }
}