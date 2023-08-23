using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Projet_RMS_Final.Model;

namespace Projet_RMS_Final.Dao
{
    public class CommandeSqlDaoImpl : IDao<Commande>
    {
        private string connectionString = "Data Source=.;Initial Catalog=dbrms;Integrated Security=True"; // Votre chaîne de connexion à la base de données

        public CommandeSqlDaoImpl()
        {

        }

        public CommandeSqlDaoImpl(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public Commande Create1(Commande entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO T_Commandes (Date, Status, Quantite, MontantTotalProduits, MontantTotalCommande) VALUES (@Date, @Status, @Quantite, @MontantTotalProduits, @MontantTotalCommande); SELECT SCOPE_IDENTITY()";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Date", entity.Date);
                        command.Parameters.AddWithValue("@Status", entity.Status);
                        command.Parameters.AddWithValue("@Quantite", entity.Quantite);
                        command.Parameters.AddWithValue("@MontantTotalProduits", entity.MontantTotalProduits);
                        command.Parameters.AddWithValue("@MontantTotalCommande", entity.MontantTotalCommande);

                        int insertedId = Convert.ToInt32(command.ExecuteScalar());

                        entity.Id = insertedId;

                        return entity;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la création : " + ex.Message);
                }
            }
        }

        public void Create(Commande entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO T_Commandes (Date, Status, Quantite, MontantTotalProduits, MontantTotalCommande) VALUES (@Date, @Status, @Quantite, @MontantTotalProduits, @MontantTotalCommande)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Date", entity.Date);
                        command.Parameters.AddWithValue("@Status", entity.Status);
                        command.Parameters.AddWithValue("@Quantite", entity.Quantite);
                        command.Parameters.AddWithValue("@MontantTotalProduits", entity.MontantTotalProduits);
                        command.Parameters.AddWithValue("@MontantTotalCommande", entity.MontantTotalCommande);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la création : " + ex.Message);
                }
            }
        }

        public Commande Read(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Commandes WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Commande commande = new Commande
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Date = Convert.ToDateTime(reader["Date"]),
                                    Status = reader["Status"].ToString(),
                                    Quantite = Convert.ToInt32(reader["Quantite"]),
                                    MontantTotalProduits = Convert.ToDouble(reader["MontantTotalProduits"]),
                                    MontantTotalCommande = Convert.ToDouble(reader["MontantTotalCommande"])
                                };
                                return commande;
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

        public List<Commande> List()
        {
            List<Commande> commandes = new List<Commande>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Commandes";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Commande commande = new Commande
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Date = Convert.ToDateTime(reader["Date"]),
                                    Status = reader["Status"].ToString(),
                                    Quantite = Convert.ToInt32(reader["Quantite"]),
                                    MontantTotalProduits = Convert.ToDouble(reader["MontantTotalProduits"]),
                                    MontantTotalCommande = Convert.ToDouble(reader["MontantTotalCommande"])
                                };
                                commandes.Add(commande);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la récupération de la liste : " + ex.Message);
                }
            }
            return commandes;
        }

        public void Update(Commande entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE T_Commandes SET Date = @Date, Status = @Status, Quantite = @Quantite, MontantTotalProduits = @MontantTotalProduits, MontantTotalCommande = @MontantTotalCommande WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", entity.Id);
                        command.Parameters.AddWithValue("@Date", entity.Date);
                        command.Parameters.AddWithValue("@Status", entity.Status);
                        command.Parameters.AddWithValue("@Quantite", entity.Quantite);
                        command.Parameters.AddWithValue("@MontantTotalProduits", entity.MontantTotalProduits);
                        command.Parameters.AddWithValue("@MontantTotalCommande", entity.MontantTotalCommande);

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
                    string query = "DELETE FROM T_Commandes WHERE Id = @Id";
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
