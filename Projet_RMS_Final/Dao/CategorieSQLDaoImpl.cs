using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Projet_RMS_Final.Dao;
using Projet_RMS_Final.Model;

namespace Projet_RMS_Final.Dao
{
    public class CategorieSqlDaoImpl : IDao<Categorie>
    {
        private string connectionString = "Data Source=.;Initial Catalog=dbrms;Integrated Security=True"; // Votre chaîne de connexion à la base de données

        public CategorieSqlDaoImpl()
        {

        }

        public CategorieSqlDaoImpl(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(Categorie entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO T_Categories (IdCategorie, Libelle, Description) VALUES (@IdCategorie, @Libelle, @Description)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCategorie", entity.IdCategorie);
                        command.Parameters.AddWithValue("@Libelle", entity.Libelle);
                        command.Parameters.AddWithValue("@Description", entity.Description);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la création : " + ex.Message);
                }
            }
        }

        public Categorie Read(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Categories WHERE IdCategorie = @IdCategorie";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCategorie", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Categorie categorie = new Categorie
                                {
                                    IdCategorie = Convert.ToInt32(reader["IdCategorie"]),
                                    Libelle = reader["Libelle"].ToString(),
                                    Description = reader["Description"].ToString()
                                };
                                return categorie;
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

        public List<Categorie> List()
        {
            List<Categorie> categories = new List<Categorie>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Categories";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Categorie categorie = new Categorie
                                {
                                    IdCategorie = Convert.ToInt32(reader["IdCategorie"]),
                                    Libelle = reader["Libelle"].ToString(),
                                    Description = reader["Description"].ToString()
                                };
                                categories.Add(categorie);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la récupération de la liste : " + ex.Message);
                }
            }
            return categories;
        }

        public void Update(Categorie entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE T_Categories SET Libelle = @Libelle, Description = @Description WHERE IdCategorie = @IdCategorie";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCategorie", entity.IdCategorie);
                        command.Parameters.AddWithValue("@Libelle", entity.Libelle);
                        command.Parameters.AddWithValue("@Description", entity.Description);

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
                    string query = "DELETE FROM T_Categories WHERE IdCategorie = @IdCategorie";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCategorie", id);

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
