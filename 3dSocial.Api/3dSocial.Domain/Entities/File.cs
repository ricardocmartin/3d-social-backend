using System;
using System.Collections.Generic;
using System.Text;

namespace _3dSocial.Domain.Entities
{
    public class File : BaseEntity
    {
        public string Name { get; set; }
        public byte[] Content { get; set; }
    }
}
