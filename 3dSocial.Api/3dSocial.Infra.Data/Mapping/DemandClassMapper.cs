using _3dSocial.Domain.Entities;
using DapperExtensions.Mapper;

namespace _3dSocial.Infra.Data.Mapping
{
    class DemandClassMapper : ClassMapper<Demand>
    {
        public DemandClassMapper()
        {
            Table("tb_demand");

            Map(x => x.Id).Column("ID").Key(KeyType.Identity);
            Map(x => x.Created).Column("Created");
            Map(x => x.Modificated).Column("Modificated");

            Map(x => x.CenterID).Column("CenterID");
            Map(x => x.ProjectID).Column("ProjectID");
            Map(x => x.TotalDelivered).Column("TotalDelivered");
            Map(x => x.TotalNeed).Column("TotalNeed");
            Map(x => x.Observations).Column("Observations");
        }
    }

}
