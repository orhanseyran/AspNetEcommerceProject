namespace MyMvcAuthApp.Models;

public class Cargo
{
    public int Id { get; set; }
    public string ? CargoName { get; set; }
    public string ? CargoImg { get; set; }

    public string ? CargoWebSite { get; set; }

    public string ? CargoPhone { get; set; }

    public string ? CargoDescription { get; set; }

            public DateTime Create_At { get; set; } = DateTime.Now;
        public DateTime Update_At { get; set; } = DateTime.Now;

}