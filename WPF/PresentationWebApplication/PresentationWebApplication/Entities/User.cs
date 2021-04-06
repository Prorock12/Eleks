using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace PresentationWebApplication.Entities
{
    public class User
    {
        //private static readonly Regex EmailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        //private static readonly Regex PasswordRegex = new Regex(@"([A-Z]+\w+[0-9]+");

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [MinLength(6)]
        public string Email { get; set; }

        [PasswordPropertyText]
        public string Password { get; set; }
    }
}
