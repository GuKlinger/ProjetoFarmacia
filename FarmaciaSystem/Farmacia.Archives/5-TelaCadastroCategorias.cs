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
    public partial class menuCadastroCategorias : Form
    {
        public menuCadastroCategorias()
        {
            InitializeComponent();
        }

        SqlConnection? sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Treino;Data Source=DESKTOP-JP9P5G6\MSSQLTESTE;TrustServerCertificate=True";
        private string strSql = string.Empty;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into Categorias (Nome_Categoria, Nome_SubCategoria) values (@Nome_Categoria, @Nome_SubCategoria)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("Nome_Categoria", SqlDbType.VarChar).Value = txtCategoria.Text;
            comando.Parameters.Add("Nome_SubCategoria", SqlDbType.VarChar).Value = txtSubcategoria.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Categoria cadastrada com sucesso.",
                                "Sucesso!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCategoria.Clear();
            txtSubcategoria.Clear();
        }
    }
}
