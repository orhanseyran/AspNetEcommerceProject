namespace MyMvcAuthApp.Models
{
    public class PTO
    {
        public int Id { get; set; }

        public string ? UserId {get; set;}
        public string ? UserName {get; set;}
        public string ? Name { get; set; }
        public string ? Description { get; set; }
        public double ? Price { get; set; }
        public string ? ImageUrl { get; set; }
        public double ? stock { get; set; }
        public string ? Brand { get; set; }

        public string? Category { get; set; } 

        public double ? Views { get; set; }



        public DateTime Create_At { get; set; } = DateTime.Now;
        public DateTime Update_At { get; set; } = DateTime.Now;


    }
    
}