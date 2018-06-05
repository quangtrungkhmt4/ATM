using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WithDrawLimitDTO
    {
        public string wdID { get; set; }
        public int value { get; set; }

        public WithDrawLimitDTO() { }

        public WithDrawLimitDTO(string id, int val) {
            this.wdID = id;
            this.value = val;
        }
    }
}
