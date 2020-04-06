namespace _3dSocial.Domain.Entities
{
    public class Center : BaseEntity
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string AddressNumber { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Ddd { get; set; }
        public string Email { get; set; }
        public bool AllowShowInfo { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Document { get; set; }
    }
}
