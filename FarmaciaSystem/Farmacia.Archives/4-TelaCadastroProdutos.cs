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
    public partial class menuCadastroProduto : Form
    {
        public menuCadastroProduto()
        {
            InitializeComponent();
        }

        SqlConnection? sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Treino;Data Source=DESKTOP-JP9P5G6\MSSQLTESTE;TrustServerCertificate=True";
        private string strSql = string.Empty;

        private void menuCadastroProduto_Load(object sender, EventArgs e)
        {
            strSql = "select Nome_Categoria from Categorias";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            sqlCon.Open();

            try
            {
                SqlDataReader reader = comando.ExecuteReader();

                List<string> categorias = new List<string>();

                while (reader.Read())
                {
                    var categoria = reader["Nome_Categoria"] as string;
                    if (!string.IsNullOrEmpty(categoria))
                    {
                        categorias.Add(categoria);
                    }
                }

                reader.Close();

                cboxCategoria.DataSource = categorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into Cadastros_Produtos (SKU, DESCRICAO, CATEGORIA, STATUS, QUANTIDADES, VALOR_BASE, VALOR_VENDA, VALOR_DESCONTO) values (@SKU, @DESCRICAO, @CATEGORIA, @STATUS, @QUANTIDADES, @VALOR_BASE, @VALOR_VENDA, @VALOR_DESCONTO)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("SKU", SqlDbType.VarChar).Value = txtSku.Text;
            comando.Parameters.Add("DESCRICAO", SqlDbType.VarChar).Value = txtDescricao.Text;
            comando.Parameters.Add("CATEGORIA", SqlDbType.VarChar).Value = cboxCategoria.Text;
            comando.Parameters.Add("STATUS", SqlDbType.VarChar).Value = cboxStatus.Text;
            comando.Parameters.Add("QUANTIDADES", SqlDbType.VarChar).Value = cboxQuantidade;
            comando.Parameters.Add("VALOR_BASE", SqlDbType.VarChar).Value = txtBase;
            comando.Parameters.Add("VALOR_VENDA", SqlDbType.VarChar).Value = txtVenda;
            comando.Parameters.Add("VALOR_DESCONTO", SqlDbType.VarChar).Value = txtDesconto;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com sucesso!",
                                "Sucesso!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSku.Clear();
            txtDescricao.Clear();
            cboxCategoria.ResetText();
            cboxStatus.ResetText();
            cboxQuantidade.ResetText();
            txtBase.Clear();
            txtVenda.Clear();
            txtDesconto.Clear();
        }
    }
}
