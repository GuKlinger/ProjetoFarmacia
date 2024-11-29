namespace CrudProjeto1
{
    partial class Cadastro
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
            groupBox1 = new GroupBox();
            lblSobrenome = new Label();
            lblNome = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            lblSenha = new Label();
            lblUsuario = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSobrenome);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(lblSenha);
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 359);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CADASTRO";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Location = new Point(183, 105);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(100, 23);
            lblSobrenome.TabIndex = 21;
            lblSobrenome.Text = "Sobrenome:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 105);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(59, 23);
            lblNome.TabIndex = 20;
            lblNome.Text = "Nome:";
            lblNome.Click += lblNome_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(183, 131);
            textBox7.MaxLength = 100;
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Último nome";
            textBox7.Size = new Size(147, 30);
            textBox7.TabIndex = 3;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(6, 131);
            textBox6.MaxLength = 100;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Primeiro nome";
            textBox6.Size = new Size(147, 30);
            textBox6.TabIndex = 2;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(183, 39);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(63, 23);
            lblSenha.TabIndex = 13;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(6, 39);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(74, 23);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "Usuário:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 65);
            textBox5.MaxLength = 100;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(147, 30);
            textBox5.TabIndex = 0;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(183, 65);
            textBox4.MaxLength = 100;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 30);
            textBox4.TabIndex = 1;
            textBox4.UseSystemPasswordChar = true;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(116, 321);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 9;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(6, 276);
            maskedTextBox1.Mask = "(00) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(147, 30);
            maskedTextBox1.TabIndex = 5;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 250);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 7;
            label4.Text = "Telefone Celular:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 176);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 6;
            label3.Text = "E-mail Válido:";
            // 
            // textBox3
            // 
            textBox3.CausesValidation = false;
            textBox3.Location = new Point(6, 202);
            textBox3.MaxLength = 300;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(324, 30);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(360, 383);
            Controls.Add(groupBox1);
            Name = "Cadastro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de usuário:";
            FormClosing += Cadastro_FormClosing;
            Load += Cadastro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label lblSobrenome;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblSenha;
        private Label lblUsuario;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label6;
        private Label lblNome;
        private TextBox textBox7;
        private TextBox textBox6;
    }
}