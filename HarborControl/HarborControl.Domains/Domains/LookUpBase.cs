using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
  public abstract class LookUpBase: EntityBase
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
