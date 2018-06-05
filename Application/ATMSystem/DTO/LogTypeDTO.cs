using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LogTypeDTO
    {
        public string logTypeID { get; set; }
        public string description { get; set; }

        public LogTypeDTO() { }
        public LogTypeDTO(string id, string desc) {
            this.logTypeID = id;
            this.description = desc;
        }

    }
}
