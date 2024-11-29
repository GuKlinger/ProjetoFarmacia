namespace CrudProjeto1
{
    partial class CrudProject
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            tsgpBox = new GroupBox();
            btnCadastro = new Button();
            btnEntrar = new Button();
            txtbox2 = new TextBox();
            txtbox1 = new TextBox();
            lblSenha = new Label();
            lblLogin = new Label();
            tsgpBox.SuspendLayout();
            SuspendLayout();
            // 
            // sqlConnection1
            // 
            sqlConnection1.AccessTokenCallback = null;
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // tsgpBox
            // 
            tsgpBox.Controls.Add(btnCadastro);
            tsgpBox.Controls.Add(btnEntrar);
            tsgpBox.Controls.Add(txtbox2);
            tsgpBox.Controls.Add(txtbox1);
            tsgpBox.Controls.Add(lblSenha);
            tsgpBox.Controls.Add(lblLogin);
            tsgpBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsgpBox.ForeColor = SystemColors.ButtonHighlight;
            tsgpBox.Location = new Point(11, 9);
            tsgpBox.Name = "tsgpBox";
            tsgpBox.Size = new Size(337, 369);
            tsgpBox.TabIndex = 0;
            tsgpBox.TabStop = false;
            tsgpBox.Text = "LOGIN";
            // 
            // btnCadastro
            // 
            btnCadastro.FlatStyle = FlatStyle.System;
            btnCadastro.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastro.Location = new Point(208, 324);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(107, 23);
            btnCadastro.TabIndex = 3;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += button2_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatStyle = FlatStyle.System;
            btnEntrar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ActiveCaptionText;
            btnEntrar.Location = new Point(27, 324);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(107, 23);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextAlign = ContentAlignment.TopCenter;
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += button1_Click;
            // 
            // txtbox2
            // 
            txtbox2.Location = new Point(27, 199);
            txtbox2.MaxLength = 100;
            txtbox2.Name = "txtbox2";
            txtbox2.Size = new Size(288, 30);
            txtbox2.TabIndex = 1;
            txtbox2.UseSystemPasswordChar = true;
            txtbox2.TextChanged += textBox2_TextChanged;
            // 
            // txtbox1
            // 
            txtbox1.Location = new Point(27, 97);
            txtbox1.MaxLength = 300;
            txtbox1.Name = "txtbox1";
            txtbox1.Size = new Size(288, 30);
            txtbox1.TabIndex = 0;
            txtbox1.TextChanged += textBox1_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lblSenha.Location = new Point(27, 173);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(63, 23);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            lblSenha.Click += lblSenha_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lblLogin.Location = new Point(27, 71);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(153, 23);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "E-mail ou Usuário:";
            lblLogin.Click += label1_Click;
            // 
            // CrudProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(361, 385);
            Controls.Add(tsgpBox);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "CrudProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrudProject";
            FormClosing += CrudProject_FormClosing;
            tsgpBox.ResumeLayout(false);
            tsgpBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private GroupBox tsgpBox;
        private Label lblSenha;
        private Label lblLogin;
        private TextBox txtbox2;
        private TextBox txtbox1;
        private Button btnCadastro;
        private Button btnEntrar;
    }
}
