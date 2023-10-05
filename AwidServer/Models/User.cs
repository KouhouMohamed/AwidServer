namespace AwidServer.Models
{
    public class User
    {

        /// <summary>
        /// L'identifiant de l'utilisateur
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Le nom
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Le prénom
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// L'email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Le numéro du téléphone
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Si l'utilisateur a les droits admin
        /// </summary>
        public bool IsAdmin { get; set; }

    }
}
