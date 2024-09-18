using System.ComponentModel.DataAnnotations;

namespace  MyMvcAuthApp.Models;
public class Brand{
    public int Id { get; set; }


    [Required]
    public string ? Name { get; set; }
    public DateTime Create_At { get; set; } = DateTime.Now;
    public DateTime Update_At { get; set; } = DateTime.Now;
}