using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudProjeto1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tstCodbarras_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuCadastrarProduto = new menuCadastroProduto();
            menuCadastrarProduto.Show();
        }

        private void pesquisaPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pesquisaPorQuantidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatórioDeInventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void controleDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entradaDeProdutosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void entradaManualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sáidaManualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatórioDeSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exclusãoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuCadastrarCategoria = new menuCadastroCategorias();
            menuCadastrarCategoria.Show();
        }

        private void statusDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuCadastroStatus = new Form6();
            menuCadastroStatus.Show();
        }

        private void medicamentosControladosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void antibióticosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
