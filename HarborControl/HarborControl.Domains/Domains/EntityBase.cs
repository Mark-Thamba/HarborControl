using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
  public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
