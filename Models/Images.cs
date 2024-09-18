using System.ComponentModel.DataAnnotations;

namespace MyMvcAuthApp.Models
{
    public class Images
    {
         [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
         public Product Product { get; set; }
    }
}