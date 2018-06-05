using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ConfigDTO
    {
        public string configID { get;set;}
        public int minWithDraw { get; set; }
        public int maxWithDraw { get; set; }
        public string dateModified { get; set; }
        public int numPerPage { get; set; }

        public ConfigDTO() { }
        public ConfigDTO(string id, int min, int max, string date, int num) {
            this.configID = id;
            this.minWithDraw = min;
            this.maxWithDraw = max;
            this.numPerPage = num;
        }
    }
}
