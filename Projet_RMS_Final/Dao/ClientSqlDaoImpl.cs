using Projet_RMS_Final.Model;
using System.Data.SqlClient;

namespace Projet_RMS_Final.Dao
{
    public class ClientSqlDaoImpl : IDao<Client>
    {
        private string connectionString = "Data Source=.;Initial Catalog=dbrms;Integrated Security=True"; // Votre chaîne de connexion à la base de données

        public ClientSqlDaoImpl()
        {

        }

        public ClientSqlDaoImpl(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public Client Create1(Client entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO T_Clients (Nom, Prenom, Adresse, Email, Telephone) VALUES (@Nom, @Prenom, @Adresse, @Email, @Telephone); SELECT SCOPE_IDENTITY()";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nom", entity.Nom);
                        command.Parameters.AddWithValue("@Prenom", entity.Prenom);
                        command.Parameters.AddWithValue("@Adresse", entity.Adresse);
                        command.Parameters.AddWithValue("@Email", entity.Email);
                        command.Parameters.AddWithValue("@Telephone", entity.Telephone);

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

        public void Create(Client entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO T_Clients (Nom, Prenom, Adresse, Email, Telephone) VALUES (@Nom, @Prenom, @Adresse, @Email, @Telephone)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nom", entity.Nom);
                        command.Parameters.AddWithValue("@Prenom", entity.Prenom);
                        command.Parameters.AddWithValue("@Adresse", entity.Adresse);
                        command.Parameters.AddWithValue("@Email", entity.Email);
                        command.Parameters.AddWithValue("@Telephone", entity.Telephone);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la création : " + ex.Message);
                }
            }
        }

        public Client Read(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Clients WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Client client = new Client
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Nom = reader["Nom"].ToString(),
                                    Prenom = reader["Prenom"].ToString(),
                                    Adresse = reader["Adresse"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Telephone = reader["Telephone"].ToString()
                                };
                                return client;
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

        public List<Client> List()
        {
            List<Client> clients = new List<Client>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Clients";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Client client = new Client
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Nom = reader["Nom"].ToString(),
                                    Prenom = reader["Prenom"].ToString(),
                                    Adresse = reader["Adresse"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Telephone = reader["Telephone"].ToString()
                                };
                                clients.Add(client);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la récupération de la liste : " + ex.Message);
                }
            }
            return clients;
        }

        public void Update(Client entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE T_Clients SET Nom = @Nom, Prenom = @Prenom, Adresse = @Adresse, Email = @Email, Telephone = @Telephone WHERE Id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", entity.Id);
                        command.Parameters.AddWithValue("@Nom", entity.Nom);
                        command.Parameters.AddWithValue("@Prenom", entity.Prenom);
                        command.Parameters.AddWithValue("@Adresse", entity.Adresse);
                        command.Parameters.AddWithValue("@Email", entity.Email);
                        command.Parameters.AddWithValue("@Telephone", entity.Telephone);

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
                    string query = "DELETE FROM T_Clients WHERE Id = @Id";
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
