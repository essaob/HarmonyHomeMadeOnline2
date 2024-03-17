using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HarmonyHomeMadeOnline.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string productImage { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public string productType { get; set; }
        public string productPrice { get; set; }

        public bool productIsinStock { get; set; }

        [Key]
        public int Id { get; set; }

    }
}
