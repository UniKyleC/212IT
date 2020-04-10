using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager7939147
{
    //set the abstract class contact, so it can be inherited
    public abstract class contact
    {
        //set all the values
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
