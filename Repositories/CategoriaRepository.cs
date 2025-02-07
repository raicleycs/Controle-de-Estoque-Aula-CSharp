using System.Collections.Generic;
using System.Data.SQLite;
using ControleDeEstoque.Models;
using ControleDeEstoque.Database;

namespace ControleDeEstoque.Repositories
{
    public class CategoriaRepository
    {
        public List<Categoria> GetAll()
        {
            var categorias = new List<Categoria>();

            using (var connection = Database.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Categorias";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categorias.Add(new Categoria
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1)
                        });
                    }
                }
            }

            return categorias;
        }

        public void Add(Categoria categoria)
        {
            using (var connection = Database.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Categorias (Nome) VALUES (@nome)";
                command.Parameters.AddWithValue("@nome", categoria.Nome);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Categoria categoria)
        {
            using (var connection = Database.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "UPDATE Categorias SET Nome = @nome WHERE Id = @id";
                command.Parameters.AddWithValue("@nome", categoria.Nome);
                command.Parameters.AddWithValue("@id", categoria.Id);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = Database.GetConnection())
            {
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Categorias WHERE Id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
