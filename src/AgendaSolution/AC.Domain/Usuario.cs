using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace AC.Domain
{
    public class Usuario
    {
        public int ID { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public bool Status { get; set; }

        public class LoginCollection : List<Login>
        {

        }
    }
}
