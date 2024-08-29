namespace MyMvcAuthApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string ? Name { get; set; }
        public string ? Description { get; set; }
        public int ProductId { get; set; }
        public ICollection<Product> ? Products { get; set; }
        public DateTime Create_At { get; set; } = DateTime.Now;
        public DateTime Update_At { get; set; } = DateTime.Now;

    }

}