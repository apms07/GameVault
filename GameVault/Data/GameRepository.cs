using GameVault.Models;
using MySqlConnector;

namespace GameVault.Data;

public class GameRepository
{
    private readonly string _connectionString;

    public GameRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Game> Search(string text = "")
    {
        var games = new List<Game>();
        using var conn = new MySqlConnection(_connectionString);
        conn.Open();

        using var cmd = new MySqlCommand(
            @"SELECT id, title, platform, genre, game_condition, price, quantity, release_year
              FROM games
              WHERE title LIKE @text OR platform LIKE @text
              ORDER BY title", conn);
        cmd.Parameters.AddWithValue("@text", $"%{text}%");

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            games.Add(new Game
            {
                Id = reader.GetInt32("id"),
                Title = reader.GetString("title"),
                Platform = reader.GetString("platform"),
                Genre = reader.IsDBNull(reader.GetOrdinal("genre"))
                    ? "" : reader.GetString("genre"),
                Condition = reader.GetString("game_condition"),
                Price = reader.GetDecimal("price"),
                Quantity = reader.GetInt32("quantity"),
                ReleaseYear = reader.IsDBNull(reader.GetOrdinal("release_year"))
                    ? null : reader.GetInt32("release_year")
            });
        }
        return games;
    }

    public void Add(Game g)
    {
        using var conn = new MySqlConnection(_connectionString);
        conn.Open();

        using var cmd = new MySqlCommand(
            @"INSERT INTO games (title, platform, genre, game_condition, price, quantity, release_year)
              VALUES (@title, @platform, @genre, @condition, @price, @quantity, @year)", conn);
        FillParameters(cmd, g);
        cmd.ExecuteNonQuery();
    }

    public void Update(Game g)
    {
        using var conn = new MySqlConnection(_connectionString);
        conn.Open();

        using var cmd = new MySqlCommand(
            @"UPDATE games
              SET title=@title, platform=@platform, genre=@genre,
                  game_condition=@condition, price=@price,
                  quantity=@quantity, release_year=@year
              WHERE id=@id", conn);
        FillParameters(cmd, g);
        cmd.Parameters.AddWithValue("@id", g.Id);
        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var conn = new MySqlConnection(_connectionString);
        conn.Open();

        using var cmd = new MySqlCommand("DELETE FROM games WHERE id=@id", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
    }

    private static void FillParameters(MySqlCommand cmd, Game g)
    {
        cmd.Parameters.AddWithValue("@title", g.Title);
        cmd.Parameters.AddWithValue("@platform", g.Platform);
        cmd.Parameters.AddWithValue("@genre", g.Genre);
        cmd.Parameters.AddWithValue("@condition", g.Condition);
        cmd.Parameters.AddWithValue("@price", g.Price);
        cmd.Parameters.AddWithValue("@quantity", g.Quantity);
        cmd.Parameters.AddWithValue("@year", (object?)g.ReleaseYear ?? DBNull.Value);
    }
}