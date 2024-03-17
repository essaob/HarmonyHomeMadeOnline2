using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HarmonyHomeMadeOnline.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string userName { get; set; }
        public string userPass { get; set; }
        public string userEmail { get; set; }
        [Key]
        public int id { get; set; }

    }
}
