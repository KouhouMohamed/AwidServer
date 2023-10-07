namespace AwidServer.Models
{
    public class Product
    {
        // <summary>
        /// L'identifiant du produit
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// La disgnation du produit 
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Le prix du produit
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// La photo du produit
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Si le produit est en stock
        /// </summary>
        public bool IsInStock { get; set; }
    }
}
