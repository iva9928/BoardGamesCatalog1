
using BoardGamesCatalog.Data.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Repositories
{
    public class BoardGamesRepository
    {
        private readonly string conectionString = "Data Source=DESKTOP-QQ34EL6\\SQLEXPRESS;Initial Catalog=BoardGamesGatalog;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Boardgame> GetBoardGames()
        {
            List<Boardgame> boardgames = new List<Boardgame>();
            try
            {
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM Boardgames ORDER BY Id ASC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                Boardgame boardgame = new Boardgame();
                                boardgame.Id = reader.GetInt32(0);
                                boardgame.Name = reader.GetString(1);
                                boardgame.YearPublished = reader.GetInt32(2);
                                boardgame.Rating = reader.GetDecimal(3);
                                boardgame.CategoryId = reader.GetInt32(4);
                                boardgame.PublisherId = reader.GetInt32(5);
                                boardgame.PlayerRangeId = reader.GetInt32(6);

                                boardgames.Add(boardgame);
                            }

                        }

                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("");

            }
            return boardgames;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Boardgame? GetBoardGame(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    //ccc
                    connection.Open();

                    string sql = "SELECT * FROM Boardgames WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                Boardgame boardgame = new Boardgame();
                                boardgame.Id = reader.GetInt32(0);
                                boardgame.Name = reader.GetString(1);
                                boardgame.YearPublished = reader.GetInt32(2);
                                boardgame.Rating = reader.GetDecimal(3);
                                boardgame.CategoryId = reader.GetInt32(4);
                                boardgame.PublisherId = reader.GetInt32(5);
                                boardgame.PlayerRangeId = reader.GetInt32(6);

                                return boardgame;
                            }

                        }
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("");

            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="boardgame"></param>
        public void CreateBoardGame(Boardgame boardgame)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO Boardgames" +
                        "(Name, YearPublished, Rating, CategoryId, PublisherId, PlayersRangeId )VALUES " +
                        "(@Name, @YearPublished, @Rating, @CategoryId, @PublisherId, @PlayersRangeId );";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", boardgame.Name);
                        command.Parameters.AddWithValue("@YearPublished", boardgame.YearPublished);
                        command.Parameters.AddWithValue("@Rating", boardgame.Rating);
                        command.Parameters.AddWithValue("@CategoryId", boardgame.CategoryId);
                        command.Parameters.AddWithValue("@PublisherId", boardgame.PublisherId);
                        command.Parameters.AddWithValue("@PlayersRangeId", boardgame.PlayerRangeId);

                        command.ExecuteNonQuery();
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("");

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="boardgame"></param>
        public void UpdateBoardGame(Boardgame boardgame)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();

                    string sql = "UPDATE Boardgames " +
                        "SET Name = @Name, YearPublished = @YearPublished, Rating = @Rating, " +
                        "CategoryId = @CategoryId, PublisherId = @PublisherId, PlayersRangeId = @PlayersRangeId " +
                        "WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", boardgame.Name);
                        command.Parameters.AddWithValue("@YearPublished", boardgame.YearPublished);
                        command.Parameters.AddWithValue("@Rating", boardgame.Rating);
                        command.Parameters.AddWithValue("@CategoryId", boardgame.CategoryId);
                        command.Parameters.AddWithValue("@PublisherId", boardgame.PublisherId);
                        command.Parameters.AddWithValue("@PlayersRangeId", boardgame.PlayerRangeId);

                        command.Parameters.AddWithValue("@Id", boardgame.Id);

                        command.ExecuteNonQuery();
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("");

            }
        }


        public void DeleteBoardGame(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM Boardgames WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@Id", id);

                        command.ExecuteNonQuery();
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("");

            }
        }
    }

}
