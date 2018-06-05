using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class ConfigBUL
    {
        ConfigDAL config = new ConfigDAL();

        public int getNumPerPage() {
            return config.getNumPerPage();
        }
    }
}
