using Projet_RMS_Final.Model;
using System.Data;
using System.Data.SqlClient;

namespace Projet_RMS_Final.Dao
{
    public class UtilisateurSqlDaoImpl : IDao<Utilisateur>
    {
        private string connectionString = "Data Source=.;Initial Catalog=dbrms;Integrated Security=True"; // Votre chaîne de connexion à la base de données
        public UtilisateurSqlDaoImpl()
        {

        }
        public UtilisateurSqlDaoImpl(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Authenticate(Utilisateur utilisateur)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Utilisateurs WHERE login = @login AND password = @password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        _ = command.Parameters.AddWithValue("@login", utilisateur.Login);
                        command.Parameters.AddWithValue("@password", utilisateur.Password);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                utilisateur.Id = Convert.ToInt32(reader["id"]);
                                utilisateur.Nom = reader["nom"].ToString();
                                utilisateur.Prenom = reader["prenom"].ToString();
                                utilisateur.Role = reader["role"].ToString();
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur d'authentification : " + ex.Message);
                }
            }
        }

        public void Create(Utilisateur entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO T_Utilisateurs (nom, prenom, email, telephone, login, password, role) VALUES (@nom, @prenom, @email, @telephone, @login, @password, @role)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nom", entity.Nom);
                        command.Parameters.AddWithValue("@prenom", entity.Prenom);
                        command.Parameters.AddWithValue("@email", entity.Email);
                        command.Parameters.AddWithValue("@telephone", entity.Telephone);
                        command.Parameters.AddWithValue("@login", entity.Login);
                        command.Parameters.AddWithValue("@password", entity.Password);
                        command.Parameters.AddWithValue("@role", entity.Role);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la création : " + ex.Message);
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
                    string query = "DELETE FROM T_Utilisateurs WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la suppression : " + ex.Message);
                }
            }
        }

        public List<Utilisateur> List()
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Utilisateurs";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Utilisateur utilisateur = new Utilisateur
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Nom = reader["nom"].ToString(),
                                    Prenom = reader["prenom"].ToString(),
                                    Email = reader["email"].ToString(),
                                    Telephone = reader["telephone"].ToString(),
                                    Login = reader["login"].ToString(),
                                    Password = reader["password"].ToString(),
                                    Role = reader["role"].ToString()
                                };
                                utilisateurs.Add(utilisateur);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la récupération de la liste : " + ex.Message);
                }
            }
            return utilisateurs;
        }
        public DataTable RetrieveDataFromDatabase()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM T_Utilisateurs";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public Utilisateur Read(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Utilisateurs WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Utilisateur utilisateur = new Utilisateur
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Nom = reader["nom"].ToString(),
                                    Prenom = reader["prenom"].ToString(),
                                    Email = reader["email"].ToString(),
                                    Telephone = reader["telephone"].ToString(),
                                    Login = reader["login"].ToString(),
                                    Password = reader["password"].ToString(),
                                    Role = reader["role"].ToString()
                                };
                                return utilisateur;
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

        public void Update(Utilisateur entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE T_Utilisateurs SET nom = @nom, prenom = @prenom, email = @email, "
                                 + "telephone = @telephone, login = @login, password = @password, role = @role "
                                 + "WHERE id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", entity.Id);
                        command.Parameters.AddWithValue("@nom", entity.Nom);
                        command.Parameters.AddWithValue("@prenom", entity.Prenom);
                        command.Parameters.AddWithValue("@email", entity.Email);
                        command.Parameters.AddWithValue("@telephone", entity.Telephone);
                        command.Parameters.AddWithValue("@login", entity.Login);
                        command.Parameters.AddWithValue("@password", entity.Password);
                        command.Parameters.AddWithValue("@role", entity.Role);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Utilisateur mis à jour avec succès.");
                        }
                        else
                        {
                            Console.WriteLine("Aucune mise à jour n'a été effectuée.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la mise à jour : " + ex.Message);
                }
            }
        }


    }
}
