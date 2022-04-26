namespace GLMainProject
{
    public class User
    {
        public User()
        {

        }

        public string Username { get; set; }
        public string Password { get; set; }
        public enum UserType
        {
            AgentVente,
            AgentCommercial,
            Directeur
        }
    }
}
