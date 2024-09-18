namespace MyMvcAuthApp.Models
{
    public class WishList
    {

        public int Id { get; set; } 
        public string ? ProductName { get; set; }
        public string ? ProductImage { get; set; }
        public int ProductId { get; set; }
        public double ProductPrice { get; set; }
        public string ? UserName { get; set; }

        
        public DateTime Create_At { get; set; } = DateTime.Now;
        public DateTime Update_At { get; set; } = DateTime.Now;
    }
}