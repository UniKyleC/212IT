using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager7939147
{
    //inherit the contact class for businesscontact
   public class businessContact : contact
    {
        //add the business-only value, conBTel
        public string conBTel { get; set; }
    }
}
