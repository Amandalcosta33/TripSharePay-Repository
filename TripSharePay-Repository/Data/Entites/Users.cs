using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TripSharePay_Repository.Data.Entites
{
    public class users
    {
        public users(string user_name, string name, string user_birthday, string senha)
        {
            this.user_name = user_name;
            this.name = name;
            this.user_birthday = user_birthday;
            this.senha = senha;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }

        [Required]
        public string user_name { get; set; }
        public string name { get; set; }
        public string user_birthday { get; set; }
        public string senha { get; set; }
        public string cpf { get; set; }
    }
}