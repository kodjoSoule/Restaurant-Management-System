using Projet_RMS_Final.Model;
using System.Data.SqlClient;

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
        public List<Tuple<Commande, Client, Produit, LigneCommande>> GetAllLinkedData()
        {
            List<Tuple<Commande, Client, Produit, LigneCommande>> linkedData = new List<Tuple<Commande, Client, Produit, LigneCommande>>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query2 = @"
                SELECT 
                    c.Id AS CommandeId, c.Date AS CommandeDate, c.Status AS CommandeStatus,
                    cl.Id AS ClientId, cl.Nom AS ClientNom, cl.Prenom AS ClientPrenom, cl.Email AS ClientEmail,
                    p.Id AS ProduitId, p.Intitule AS ProduitNom, p.Prix AS ProduitPrix
                FROM T_LignesCommande lc
                INNER JOIN T_Commandes c ON lc.commande_id = c.Id
                INNER JOIN T_Clients cl ON c.client_id = cl.Id
                INNER JOIN T_Produits p ON lc.produit_id = p.Id";

                    string query3 = @"
                            SELECT 
                            c.Id AS CommandeId, 
                            p.Intitule AS Produit,
                            p.Prix AS PrixUnitaire,
                            lc.quantite AS Quantite,
                            CONVERT(VARCHAR(16), c.Date, 120) AS CommandeDate,
                            c.Status AS CommandeStatus,
                            cl.Nom AS ClientNom,
                            cl.Prenom AS ClientPrenom,
                            cl.telephone AS ClientTelephone,
                            lc.quantite * p.Prix AS MontantTotal
                            FROM T_LignesCommande lc
                            INNER JOIN T_Commandes c ON lc.commande_id = c.Id
                            INNER JOIN T_Clients cl ON c.client_id = cl.Id
                            INNER JOIN T_Produits p ON lc.produit_id = p.Id;
                            ";

                    string query = @"
                        SELECT 
                        c.Id AS CommandeId, 
                        p.Intitule AS ProduitNom,
                        p.Id AS ProduitId,
                        p.Prix AS PrixUnitaire,
                        lc.id as ligneCommandeID,
                        lc.quantite AS Quantite,
                        CONVERT(VARCHAR(16), c.Date, 120) AS CommandeDate,
                        c.Status AS CommandeStatus,
                        cl.Id AS ClientId,
                        cl.Telephone   AS ClientTelephone,
                        cl.Nom AS ClientNom,
                        cl.Prenom AS ClientPrenom,
                        cl.Telephone AS ClientTelephone,
                        lc.Quantite * p.Prix AS MontantTotal,
                        c.MontantTotalCommande as MontantTotalCommande
                        FROM T_LignesCommande lc
                        INNER JOIN T_Commandes c ON lc.commande_id = c.Id
                        INNER JOIN T_Clients cl ON c.client_id = cl.Id
                        INNER JOIN T_Produits p ON lc.produit_id = p.Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Client client = new Client
                                {
                                    Id = Convert.ToInt32(reader["ClientId"]),
                                    Nom = reader["ClientNom"].ToString(),
                                    Prenom = reader["ClientPrenom"].ToString(),
                                    Email = reader["ClientTelephone"].ToString()
                                };
                                Commande commande = new Commande
                                {
                                    Id = Convert.ToInt32(reader["CommandeId"]),
                                    Date = Convert.ToDateTime(reader["CommandeDate"]),
                                    Status = reader["CommandeStatus"].ToString(),
                                    MontantTotalCommande = (double)reader["MontantTotalCommande"],
                                    Client = client

                                };

                                Produit produit = new Produit
                                {
                                    Id = Convert.ToInt32(reader["ProduitId"]),
                                    Intitule = reader["ProduitNom"].ToString(),
                                    Prix = Convert.ToDouble(reader["PrixUnitaire"]),
                                };
                                LigneCommande ligneCommande = new LigneCommande
                                {
                                    //lc.id as ligneCommandeID
                                    Id = Convert.ToInt32(reader["ligneCommandeID"]),
                                    Commande = commande,
                                    Produit = produit,
                                    Quantite = Convert.ToInt32(reader["Quantite"])
                                };


                                linkedData.Add(new Tuple<Commande, Client, Produit, LigneCommande>(commande, client, produit, ligneCommande));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erreur lors de la récupération des données liées : " + ex.Message);
                }
            }

            return linkedData;
        }

        public void Create(LigneCommande entity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO T_LignesCommande (produit_id, commande_id, Quantite) VALUES (@IdProduit, @IdCommande, @Quantite)";
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
                                    Quantite = Convert.ToInt32(reader["Quantite"])
                                };

                                // Récupérer le produit associé
                                int produitId = Convert.ToInt32(reader["produit_id"]);
                                ProduitSqlDaoImpl produitSqlDaoImpl = new ProduitSqlDaoImpl();
                                Produit produit = produitSqlDaoImpl.Read(produitId);
                                ligneCommande.Produit = produit;

                                // Récupérer la commande associée
                                int commandeId = Convert.ToInt32(reader["commande_id"]);
                                CommandeSqlDaoImpl commandeSqlDaoImpl = new CommandeSqlDaoImpl();
                                Commande commande = commandeSqlDaoImpl.Read(commandeId);
                                ligneCommande.Commande = commande;

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

        public LigneCommande Read1(int id)
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
                                    Produit = null,
                                    Commande = null,
                                    Quantite = Convert.ToInt32(reader["Quantite"])
                                };
                                int produitId = Convert.ToInt32(reader["produit_id"]);
                                int commandeId = Convert.ToInt32(reader["commande_id"]);

                                // Ici, vous devez récupérer les objets Produit et Commande à partir de leur ID
                                ProduitSqlDaoImpl produitSqlDaoImpl = new ProduitSqlDaoImpl();
                                CommandeSqlDaoImpl commandeSqlDaoImpl = new CommandeSqlDaoImpl();
                                Produit produit = produitSqlDaoImpl.Read(produitId);
                                Commande commande = commandeSqlDaoImpl.Read(commandeId);

                                // Maintenant, attribuez les objets récupérés aux propriétés correspondantes
                                ligneCommande.Produit = produit;
                                ligneCommande.Commande = commande;

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
