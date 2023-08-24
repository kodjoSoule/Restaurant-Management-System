
using Projet_RMS_Final.Dao;

namespace Projet_RMS_Final.Model
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Login
        {
            get; set;
        }
        public string Password { get; set; }
        public string Role { get; set; }
        public Utilisateur(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
        public Utilisateur()
        {
            Id = 0;
            Nom = string.Empty;
            Prenom = string.Empty;
            Email = string.Empty;
            Telephone = string.Empty;
            Login = string.Empty;
            Password = string.Empty;
            Role = string.Empty;
        }
        public Utilisateur(string nom, string prenom, string email, string telephone, Role role)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Email = email;
            this.Telephone = telephone;

            this.Login = prenom.Trim().ToLower() + "." + nom.Trim().ToLower();
            this.Password = "p@Ss3R";
            this.Role = role.ToString();
        }
        public bool Authenticate()
        {

            UtilisateurSqlDaoImpl utilisateurHbnDaoImpl = new UtilisateurSqlDaoImpl();
            bool isAuthenticate = utilisateurHbnDaoImpl.Authenticate(this);
            return isAuthenticate;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Nom}";
        }



    }
}
