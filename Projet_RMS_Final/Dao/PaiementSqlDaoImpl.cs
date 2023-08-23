using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Projet_RMS_Final.Model;

namespace Projet_RMS_Final.Dao
{
    public class PaiementSqlDaoImpl : IDao<Paiement>
    {
        private string connectionString = "Data Source=.;Initial Catalog=dbrms;Integrated Security=True"; // Votre chaîne de connexion à la base de données

        public PaiementSqlDaoImpl()
        {

        }

        public PaiementSqlDaoImpl(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(Paiement entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO T_Paiements (MontantPayer, MontantRecue, MontantRendue, DatePaiement, ModePaiement, CommandeId) VALUES (@MontantPayer, @MontantRecue, @MontantRendue, @DatePaiement, @ModePaiement, @CommandeId)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MontantPayer", entity.MontantPayer);
                        command.Parameters.AddWithValue("@MontantRecue", entity.MontantRecue);
                        command.Parameters.AddWithValue("@MontantRendue", entity.MontantRendue);
                        command.Parameters.AddWithValue("@DatePaiement", entity.DatePaiement);
                        command.Parameters.AddWithValue("@ModePaiement", entity.ModePaiement);
                        command.Parameters.AddWithValue("@CommandeId", entity.CommandeId);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la création : " + ex.Message);
                }
            }
        }

        public Paiement Read(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Paiements WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Paiement paiement = new Paiement
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    MontantPayer = Convert.ToDouble(reader["MontantPayer"]),
                                    MontantRecue = Convert.ToDouble(reader["MontantRecue"]),
                                    MontantRendue = Convert.ToDouble(reader["MontantRendue"]),
                                    DatePaiement = Convert.ToDateTime(reader["DatePaiement"]),
                                    ModePaiement = reader["ModePaiement"].ToString(),
                                    CommandeId = Convert.ToInt32(reader["CommandeId"])
                                };
                                return paiement;
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

        public List<Paiement> List()
        {
            List<Paiement> paiements = new List<Paiement>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Paiements";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Paiement paiement = new Paiement
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    MontantPayer = Convert.ToDouble(reader["MontantPayer"]),
                                    MontantRecue = Convert.ToDouble(reader["MontantRecue"]),
                                    MontantRendue = Convert.ToDouble(reader["MontantRendue"]),
                                    DatePaiement = Convert.ToDateTime(reader["DatePaiement"]),
                                    ModePaiement = reader["ModePaiement"].ToString(),
                                    CommandeId = Convert.ToInt32(reader["CommandeId"])
                                };
                                paiements.Add(paiement);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la récupération de la liste : " + ex.Message);
                }
            }
            return paiements;
        }

        public void Update(Paiement entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE T_Paiements SET MontantPayer = @MontantPayer, MontantRecue = @MontantRecue, MontantRendue = @MontantRendue, DatePaiement = @DatePaiement, ModePaiement = @ModePaiement, CommandeId = @CommandeId WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", entity.Id);
                        command.Parameters.AddWithValue("@MontantPayer", entity.MontantPayer);
                        command.Parameters.AddWithValue("@MontantRecue", entity.MontantRecue);
                        command.Parameters.AddWithValue("@MontantRendue", entity.MontantRendue);
                        command.Parameters.AddWithValue("@DatePaiement", entity.DatePaiement);
                        command.Parameters.AddWithValue("@ModePaiement", entity.ModePaiement);
                        command.Parameters.AddWithValue("@CommandeId", entity.CommandeId);

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
                    string query = "DELETE FROM T_Paiements WHERE Id = @Id";
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
