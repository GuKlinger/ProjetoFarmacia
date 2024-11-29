using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CrudProjeto1
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        SqlConnection? sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Treino;Data Source=DESKTOP-JP9P5G6\MSSQLTESTE;TrustServerCertificate=True";
        private string strSql = string.Empty;

        private bool isFromButton = false;

        private void Cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isFromButton)
            {
                var menuLogin = new CrudProject();
                menuLogin.Show();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            strSql = "insert into Login (Usuario, Senha, Nome, Sobrenome, Email, Telefone) values (@Usuario, @Senha, @Nome, @Sobrenome, @Email, @Telefone)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("Usuario", SqlDbType.VarChar).Value = textBox5.Text;
            comando.Parameters.Add("Senha", SqlDbType.VarChar).Value = textBox4.Text;
            comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = textBox6.Text;
            comando.Parameters.Add("Sobrenome", SqlDbType.VarChar).Value = textBox7.Text;
            comando.Parameters.Add("Email", SqlDbType.VarChar).Value = textBox3.Text;
            comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = maskedTextBox1.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            isFromButton = true;

            var menuLogin = new CrudProject();
            menuLogin.Show();

            this.Close();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
