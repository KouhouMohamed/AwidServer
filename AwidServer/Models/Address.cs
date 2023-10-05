namespace AwidServer.Models
{
    public class Address
    {

        /// <summary>
        /// Identifiant de l'address
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// La ville
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Le boulvard
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Le code postal
        /// </summary>
        public int ZipCode { get; set; }

        /// <summary>
        /// Le complement de l'address
        /// </summary>
    }
}
