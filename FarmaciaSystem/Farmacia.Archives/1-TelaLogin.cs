using System.Drawing.Text;
using Microsoft.Data.SqlClient;

namespace CrudProjeto1
{
    public partial class CrudProject : Form
    {
        public CrudProject()
        {
            InitializeComponent();
        }

        SqlConnection? sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Treino;Data Source=DESKTOP-JP9P5G6\MSSQLTESTE;TrustServerCertificate=True";
        private string strSql = string.Empty;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string txtLogin = txtbox1.Text;
            string txtSenha = txtbox2.Text;

            strSql = "SELECT COUNT(*) FROM Login WHERE (Usuario = @Usuario OR Email = @Email) AND Senha = @Senha";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.AddWithValue("@Usuario", txtbox1.Text);
            comando.Parameters.AddWithValue("@Email", txtbox1.Text);
            comando.Parameters.AddWithValue("@Senha", txtbox2.Text);

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();

                int login = (int)comando.ExecuteScalar();

                if (login > 0)
                {
                    MessageBox.Show("Login realizado com sucesso!",
                                    "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    var menuRestrito = new Form2();
                    menuRestrito.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos, favor verificar e redigitar novamente!",
                                    "Erro ao verificar as credenciais...",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var menuCadastro = new Cadastro();
            menuCadastro.Show();

            this.Visible = false;
        }

        private void CrudProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
