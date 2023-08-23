using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Projet_RMS_Final.Model;

namespace Projet_RMS_Final.Dao
{
    public class LigneCommandeSqlDaoImpl : IDao<LigneCommande>
    {
        private string connectionString = "Data Source=.;Initial Catalog=dbrms;Integrated Security=True"; // Votre chaîne de connexion à la base de données

        public LigneCommandeSqlDaoImpl()
        {

        }

        public LigneCommandeSqlDaoImpl(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(LigneCommande entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO T_LignesCommande (IdProduit, IdCommande, Quantite) VALUES (@IdProduit, @IdCommande, @Quantite)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdProduit", entity.Produit.Id);
                        command.Parameters.AddWithValue("@IdCommande", entity.Commande.Id);
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

        public LigneCommande Read(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_LignesCommande WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                LigneCommande ligneCommande = new LigneCommande
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Produit = null, // Remplissez ceci en récupérant le produit associé
                                    Commande = null, // Remplissez ceci en récupérant la commande associée
                                    Quantite = Convert.ToInt32(reader["Quantite"])
                                };
                                return ligneCommande;
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

        public List<LigneCommande> List()
        {
            List<LigneCommande> lignesCommande = new List<LigneCommande>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_LignesCommande";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LigneCommande ligneCommande = new LigneCommande
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Produit = null, // Remplissez ceci en récupérant le produit associé
                                    Commande = null, // Remplissez ceci en récupérant la commande associée
                                    Quantite = Convert.ToInt32(reader["Quantite"])
                                };
                                lignesCommande.Add(ligneCommande);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la récupération de la liste : " + ex.Message);
                }
            }
            return lignesCommande;
        }

        public void Update(LigneCommande entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE T_LignesCommande SET IdProduit = @IdProduit, IdCommande = @IdCommande, Quantite = @Quantite WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", entity.Id);
                        command.Parameters.AddWithValue("@IdProduit", entity.Produit?.Id);
                        command.Parameters.AddWithValue("@IdCommande", entity.Commande?.Id);
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
                    string query = "DELETE FROM T_LignesCommande WHERE Id = @Id";
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
