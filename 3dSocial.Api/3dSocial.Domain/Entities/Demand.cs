namespace _3dSocial.Domain.Entities
{
    public class Demand : BaseEntity
    {
        public int CenterID { get; set; }
        public int ProjectID { get; set; }
        public int TotalNeed { get; set; }
        public bool Active { get; set; }
        public int TotalDelivered { get; set; }
        public string Observations { get; set; }

    }
}
