using System;
using System.Collections.Generic;
using System.Text;

namespace _3dSocial.Domain.Entities
{
    public class Project : BaseEntity 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string File { get; set; }
    }
}
