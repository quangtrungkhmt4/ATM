using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OverDraftDTO
    {
        public string odID { get; set; }
        public int value { get; set; }

        public OverDraftDTO() { }

        public OverDraftDTO(string id, int val) {
            this.odID = id;
            this.value = val;
        }
    }
}
