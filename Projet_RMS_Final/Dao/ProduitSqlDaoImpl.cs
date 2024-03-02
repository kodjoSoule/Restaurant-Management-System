using Projet_RMS_Final.Model;
using System.Data;
using System.Data.SqlClient;

namespace Projet_RMS_Final.Dao
{
    public class ProduitSqlDaoImpl : IDao<Produit>
    {
        private string connectionString = "Data Source=.;Initial Catalog=dbrms;Integrated Security=True"; // Votre chaîne de connexion à la base de données

        public ProduitSqlDaoImpl()
        {

        }

        public ProduitSqlDaoImpl(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(Produit entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO T_Produits (intitule, prix, quantiteStock, description, image, categorie) VALUES (@intitule, @prix, @quantiteStock, @description, @image, @categorie)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", entity.Id);
                        command.Parameters.AddWithValue("@intitule", entity.Intitule);
                        command.Parameters.AddWithValue("@prix", entity.Prix);
                        command.Parameters.AddWithValue("@quantiteStock", entity.QuantiteStock);
                        command.Parameters.AddWithValue("@description", entity.Description);
                        command.Parameters.AddWithValue("@image", entity.Image);
                        command.Parameters.AddWithValue("@categorie", entity.Categorie);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la création : " + ex.Message);
                }
            }
        }

        public Produit Read(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Produits WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Produit produit = new Produit
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Intitule = reader["intitule"].ToString(),
                                    Prix = Convert.ToDouble(reader["prix"]),
                                    QuantiteStock = Convert.ToInt32(reader["quantiteStock"]),
                                    Description = reader["description"].ToString(),
                                    Image = (byte[])reader["image"],
                                    Categorie = reader["categorie"].ToString()
                                };
                                return produit;
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

        public void Update(Produit entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE T_Produits SET intitule = @intitule, prix = @prix, quantiteStock = @quantiteStock, description = @description,categorie=@categorie, image = @image WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", entity.Id);
                        command.Parameters.AddWithValue("@intitule", entity.Intitule);
                        command.Parameters.AddWithValue("@prix", entity.Prix);
                        command.Parameters.AddWithValue("@quantiteStock", entity.QuantiteStock);
                        command.Parameters.AddWithValue("@description", entity.Description);
                        command.Parameters.AddWithValue("@image", entity.Image);
                        command.Parameters.AddWithValue("@categorie", entity.Categorie);

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
                    string query = "DELETE FROM T_Produits WHERE id = @id";
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

        public List<Produit> List()
        {
            List<Produit> produits = new List<Produit>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM T_Produits";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Produit produit = new Produit
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Intitule = reader["intitule"].ToString(),
                                    Prix = Convert.ToDouble(reader["prix"]),
                                    //QuantiteStock = Convert.ToInt32(reader["quantiteStock"]),
                                    Description = reader["description"].ToString(),
                                    Image = (byte[])reader["image"],
                                    Categorie = reader["categorie"].ToString()
                                };
                                produits.Add(produit);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la récupération de la liste : " + ex.Message);
                }
            }
            return produits;
        }

        public DataTable RetrieveDataFromDatabase()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM T_Produits";
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

        // ... Implémentez les autres méthodes CRUD ici ...
    }
}
