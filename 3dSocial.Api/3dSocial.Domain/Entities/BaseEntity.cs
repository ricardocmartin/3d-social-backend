using System;
using System.Collections.Generic;
using System.Text;

namespace _3dSocial.Domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Created = DateTime.Now;
            Modificated = DateTime.Now;
        }

        public virtual int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modificated { get; set; }
    }
}
