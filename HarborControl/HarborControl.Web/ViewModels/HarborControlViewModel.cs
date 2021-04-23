
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarborControl.Domains;

namespace HarborControl.Web
{
    public class HarborControlViewModel
    {
        public HarborControlViewModel()
        {
                
        }
        public ICollection<HarborQues> HarborQues { get;set;}
        public ICollection<DockedBoats> DockingBoats { get; set; }

    }
}
