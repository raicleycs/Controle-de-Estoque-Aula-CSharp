using System;
using System.Windows.Forms;
using ControleDeEstoque.Repositories;

namespace ControleDeEstoque.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            var categoriaForm = new CategoriaForm();
            categoriaForm.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            var produtoForm = new ProdutoForm();
            produtoForm.ShowDialog();
        }

        private void btnMovimentacoes_Click(object sender, EventArgs e)
        {
            var movimentacaoForm = new MovimentacaoForm();
            movimentacaoForm.ShowDialog();
        }
    }
}
