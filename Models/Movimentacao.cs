namespace ControleDeEstoque.Models
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public string Tipo { get; set; } // Entrada ou Saída
        public string Data { get; set; }
    }
}
