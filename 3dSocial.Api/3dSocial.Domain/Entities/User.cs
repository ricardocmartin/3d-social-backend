namespace _3dSocial.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public int CenterID { get; set; }

    }
}
