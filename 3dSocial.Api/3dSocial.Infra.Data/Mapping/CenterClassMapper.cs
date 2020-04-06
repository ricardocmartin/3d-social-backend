using _3dSocial.Domain.Entities;
using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3dSocial.Infra.Data.Mapping
{
    class CenterClassMapper : ClassMapper<Center>
    {
        public CenterClassMapper()
        {
            Table("tb_center");

            Map(x => x.Id).Column("ID").Key(KeyType.Identity);
            Map(x => x.Created).Column("Created");
            Map(x => x.Modificated).Column("Modificated");

            Map(x => x.Name).Column("Name");
            Map(x => x.AddressNumber).Column("AddressNumber");
            Map(x => x.City).Column("City");
            Map(x => x.District).Column("District");
            Map(x => x.Street).Column("Street");
            Map(x => x.ZipCode).Column("ZipCode");
            Map(x => x.Document).Column("Document");

            Map(x => x.State).Column("State");
            Map(x => x.Phone).Column("Phone");
            Map(x => x.Ddd).Column("DDD");
            Map(x => x.Email).Column("Email");
            Map(x => x.AllowShowInfo).Column("AllowShowInfo");

        }
    }
}
