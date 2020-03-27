using _3dSocial.Domain.Entities;
using DapperExtensions.Mapper;

namespace _3dSocial.Infra.Data.Mapping
{
    class ProjectClassMapper : ClassMapper<Project>
    {
        public ProjectClassMapper()
        {
            Table("tb_project");
            
            Map(x => x.Id).Column("ID").Key(KeyType.Identity);
            Map(x => x.Created).Column("Created");
            Map(x => x.Modificated).Column("Modificated");

            Map(x => x.Name).Column("Name");
            Map(x => x.Description).Column("Description");
            Map(x => x.File).Column("File");
        }
    }
}
