namespace Lab4.Models
{
    public class Suppliers
    {
        public int ID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddressLine1 { get; set; }
        public string SupplierAddressLine2 { get; set; }

        // Navigation property to represent the many-to-many relationship with Product
        public virtual ICollection<Products> Products { get; set; } = new List<Products>();
    }
}
