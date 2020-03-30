using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager7939147
{
    public abstract class contact
    {
        public int conID { get; set; }
        public string conFName { get; set; }
        public string conLName { get; set; }

        public string conTel { get; set; }
        public string conEmail { get; set; }
        public string conAddr1 { get; set; }
        public string conAddr2 { get; set; }
        public string conCity { get; set; }
        public string conPostcode { get; set; }

    }
}
