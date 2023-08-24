using Projet_RMS_Final.Model;
using System.Data.SqlClient;

namespace Projet_RMS_Final.Dao
{
    public class RecetteSqlDaoImpl : IDao<Recette>
    {
        private string connectionString = "Data Source=.;Initial Catalog=dbrms;Integrated Security=True"; // Votre chaîne de connexion à la base de données

        public RecetteSqlDaoImpl()
        {

        }

        public RecetteSqlDaoImpl(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(Recette entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO T_Recettes (Date, Montant, Produit, Quantite) VALUES (@Date, @Montant, @Produit, @Quantite)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Date", entity.Date);
                        command.Parameters.AddWithValue("@Montant", entity.Montant);
                        command.Parameters.AddWithValue("@Produit", entity.Produit);
                        command.Parameters.AddWithValue("@Quantite", entity.Quantite);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la création : " + ex.Message);
                }
            }
        }

        public Recette Read(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Recettes WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Recette recette = new Recette
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Date = Convert.ToDateTime(reader["Date"]),
                                    Montant = Convert.ToDouble(reader["Montant"]),
                                    Produit = reader["Produit"].ToString(),
                                    Quantite = Convert.ToInt32(reader["Quantite"])
                                };
                                return recette;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la lecture : " + ex.Message);
                }
            }
        }

        public List<Recette> List()
        {
            List<Recette> recettes = new List<Recette>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Recettes";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Recette recette = new Recette
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Date = Convert.ToDateTime(reader["Date"]),
                                    Montant = Convert.ToDouble(reader["Montant"]),
                                    Produit = reader["Produit"].ToString(),
                                    Quantite = Convert.ToInt32(reader["Quantite"])
                                };
                                recettes.Add(recette);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la récupération de la liste : " + ex.Message);
                }
            }
            return recettes;
        }

        public void Update(Recette entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE T_Recettes SET Date = @Date, Montant = @Montant, Produit = @Produit, Quantite = @Quantite WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", entity.Id);
                        command.Parameters.AddWithValue("@Date", entity.Date);
                        command.Parameters.AddWithValue("@Montant", entity.Montant);
                        command.Parameters.AddWithValue("@Produit", entity.Produit);
                        command.Parameters.AddWithValue("@Quantite", entity.Quantite);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la mise à jour : " + ex.Message);
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM T_Recettes WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la suppression : " + ex.Message);
                }
            }
        }

        // ... Implémentez les autres méthodes CRUD ici ...
    }
}
