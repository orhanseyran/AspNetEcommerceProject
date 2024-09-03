#nullable enable

namespace MyMvcAuthApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserPhone { get; set; }
        public string? UserAdress { get; set; }
        public string? UserEmail { get; set; }
        public string? UserNote { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string? PaymentType { get; set; }
        public string? PaymentStatus { get; set; }
        public string? OrderStatus { get; set; }
        public string? CargoName { get; set; }
        public string? CargoPhone { get; set; }
        public string? CargoAdress { get; set; }
        public string? CargoDescription { get; set; }
        public string? CargoWebSite { get; set; }
        public string? CargoImg { get; set; }
                public DateTime Create_At { get; set; } = DateTime.Now;
        public DateTime Update_At { get; set; } = DateTime.Now;
    }
}