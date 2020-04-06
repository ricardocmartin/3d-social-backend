using System;
using System.Collections.Generic;
using System.Text;

namespace _3dSocial.Application.DTO
{
    public class DemandDTO
    {
        public int ProjectId { get; set; }

        public int CenterId { get; set; }
        public string CenterName { get; set; }
        public string CenterStreet { get; set; }
        public string CenterAddressNumber { get; set; }
        public string CenterDistrict { get; set; }
        public string CenterCity { get; set; }
        public string CenterZipCode { get; set; }
        public string CenterDocument { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Ddd { get; set; }
        public string Email { get; set; }
        public bool AllowShowInfo { get; set; }

        public int DemandId { get; set; }
        public int TotalNeed { get; set; }
        public int TotalDelivered { get; set; }
        public string Observations { get; set; }
    }
}
