using System;
using System.Collections.Generic;
using System.Text;

namespace HarborControl.Domains
{
   public partial class BoatStatuses: LookUpBase
    {
        public BoatStatuses()
        {
            HarborQues = new HashSet<HarborQues>();
            DockedBoats = new HashSet<DockedBoats>();
        }
      //  public string Name { get; set; }



        public virtual ICollection<HarborQues> HarborQues { get; set; }
        public virtual ICollection<DockedBoats> DockedBoats { get; set; }



        //public virtual DockedBoats DockedBoats { get; set; }
        //public Guid  DockedBoatsId { get; set; }

        //public virtual HarborQues HarborQues { get; set; }
        //public Guid HarborQuesId { get; set; }


    }
}
