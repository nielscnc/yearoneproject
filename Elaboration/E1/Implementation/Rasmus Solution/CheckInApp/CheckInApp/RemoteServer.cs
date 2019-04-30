using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInApp
{
    public class RemoteServer
    {
        //If theres time, make it posible to draw data from external source, as for example a textfile.
        public string RemoteHost { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public RemoteServer(string inputHost, string inputUser, string inputPassword)
        {
            this.RemoteHost = inputHost;
            this.Username = inputUser;
            this.Password = inputPassword;
        }

    }
}
