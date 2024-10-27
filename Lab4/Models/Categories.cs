namespace Lab4.Models
{
    public class Categories
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Products> Products { get; set; } = new List<Products>();
    }
}
