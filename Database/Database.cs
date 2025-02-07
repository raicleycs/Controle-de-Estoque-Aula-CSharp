using System.Data.SQLite;

namespace ControleDeEstoque.Database
{
    public class Database
    {
        private const string ConnectionString = "Data Source=Database/estoque.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static void Initialize()
        {
            using (var connection = GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Categorias (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Produtos (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nome TEXT NOT NULL,
                        Quantidade INTEGER NOT NULL,
                        Preco REAL NOT NULL,
                        CategoriaId INTEGER,
                        FOREIGN KEY (CategoriaId) REFERENCES Categorias(Id)
                    );

                    CREATE TABLE IF NOT EXISTS Movimentacoes (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        ProdutoId INTEGER NOT NULL,
                        Quantidade INTEGER NOT NULL,
                        Tipo TEXT NOT NULL, -- Entrada ou Saída
                        Data TEXT NOT NULL,
                        FOREIGN KEY (ProdutoId) REFERENCES Produtos(Id)
                    );
                ";
                command.ExecuteNonQuery();
            }
        }
    }
}
