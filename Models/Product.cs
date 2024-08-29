using System.ComponentModel.DataAnnotations;

namespace MyMvcAuthApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ? Name { get; set; }
        public string ? Description { get; set; }
        public decimal ?Price { get; set; }
        public string ? ImageUrl { get; set; }
        public int Category { get; set; }
        public Category ? Categorys { get; set; }


        public DateTime Create_At { get; set; } = DateTime.Now;
        public DateTime Update_At { get; set; } = DateTime.Now;





    }
}
