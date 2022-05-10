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
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}
