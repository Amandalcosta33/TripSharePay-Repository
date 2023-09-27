using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TripSharePay_Repository.Data.Entites
{
    public class users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }

        [Required]
        public string user_name { get; set; }
        public string name { get; set; }
        public string user_birthday { get; set; }
        public string senha { get; set; }
    }
}