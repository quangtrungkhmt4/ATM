using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        public string custID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        public CustomerDTO() { }

        public CustomerDTO(string id, string name, string email, string phone, string addr) {
            this.custID = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.address = addr;
        }
    }
}
