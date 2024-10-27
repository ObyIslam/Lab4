namespace Lab4.Models
{
    public class Products
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public DateTime DateFirstIssued { get; set; }
        public int QuantityInStock { get; set; }
        public virtual Categories AssociatedCategory { get; set; }

        // Navigation property to represent the many-to-many relationship with Supplier
        public virtual ICollection<Suppliers> Suppliers { get; set; } = new List<Suppliers>();
    }
}
