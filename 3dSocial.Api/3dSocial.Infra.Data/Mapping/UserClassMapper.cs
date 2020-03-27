using _3dSocial.Domain.Entities;
using DapperExtensions.Mapper;

namespace _3dSocial.Infra.Data.Mapping
{
    class UserClassMapper : ClassMapper<User>
    {
        public UserClassMapper()
        {
            Table("tb_demand");

            Map(x => x.Id).Column("ID").Key(KeyType.Identity);
            Map(x => x.Created).Column("Created");
            Map(x => x.Modificated).Column("Modificated");

            Map(x => x.Name).Column("Name");
            Map(x => x.Email).Column("Email");
            Map(x => x.Pass).Column("Pass");
            Map(x => x.CenterID).Column("CenterID");
        }
    }

}
