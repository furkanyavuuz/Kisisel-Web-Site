using System.ComponentModel.DataAnnotations;

namespace KisiselWebSitesi.Models.Classes
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
    }
}