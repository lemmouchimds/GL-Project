using System.ComponentModel.DataAnnotations;

namespace GLMainProject
{
    public class User
    {
        public User()
        {

        }
        [Key]
        public int Id { get; set; }
        [StringLength(Consts.MaxStringLength)]
        public string Username { get; set; }
        [StringLength(Consts.MaxStringLength)]
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}
