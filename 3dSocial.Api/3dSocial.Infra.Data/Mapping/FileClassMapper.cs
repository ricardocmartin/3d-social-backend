using _3dSocial.Domain.Entities;
using DapperExtensions.Mapper;

namespace _3dSocial.Infra.Data.Mapping
{
    class FileClassMapper : ClassMapper<File>
    {
        public FileClassMapper()
        {
            Table("tb_file");

            Map(x => x.Id).Column("ID").Key(KeyType.Identity);
            Map(x => x.Created).Column("Created");
            Map(x => x.Modificated).Column("Modificated");

            Map(x => x.Name).Column("Name");
            Map(x => x.Content).Column("Content");
        }
    }
}
