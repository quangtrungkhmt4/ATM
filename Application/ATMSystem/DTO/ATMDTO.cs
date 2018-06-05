using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ATMDTO
    {
        public string atmID { get; set; }
        public string branch { get; set; }
        public string address { get; set; }

        public ATMDTO() { }

        public ATMDTO(string id, string branch, string addr) {
            this.atmID = id;
            this.branch = branch;
            this.address = addr;
        }
    }
}
