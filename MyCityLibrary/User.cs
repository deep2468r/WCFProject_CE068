using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MyCityLibrary
{
    [DataContract]
    public class User
    {

        private string strUserID;
        private string strPassword;


        [DataMember]
        public string UserID
        {
            get { return strUserID; }
            set { strUserID = value; }
        }

        [DataMember]
        public string Password
        {
            get { return strPassword; }
            set { strPassword = value; }
        }

    }
}
