using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.ErpNext.ViewModel
{
    public class InfoSupportEditViewModel
    {
        public string Title { get; set; }

        public string Context { get; set; }

        public string ManagerEMPNO { get; set; }

        public ICollection<string> Attachments { get; set; }
    }
}
