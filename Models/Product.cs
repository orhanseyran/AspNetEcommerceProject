using System.ComponentModel.DataAnnotations;

namespace MyMvcAuthApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string ? UserId {get; set;}
        public string ? UserName {get; set;}
        public string ? Name { get; set; }
        public string ? Description { get; set; }
        public double ? Price { get; set; }
        public string ? ImageUrl { get; set; }
        public double ? stock { get; set; }
        public string ? Brand { get; set; }

        public string ? ShipDetail { get; set; }

        public double ? CargoDesi { get; set; }
        public string ? Cargo { get; set; } = "DENEME";
        public string ? Sehir { get; set; } = "DENEME";

        public string? Category { get; set; } 
         public ICollection<Images> ? Images { get; set; }



        public DateTime Create_At { get; set; } = DateTime.Now;
        public DateTime Update_At { get; set; } = DateTime.Now;





    }
}
