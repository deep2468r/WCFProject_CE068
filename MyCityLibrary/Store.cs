using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MyCityLibrary
{
    [DataContract]
    public class Store
    {

        private int intID;
        private string strName;
        private string strDescription;
        private string strRating;
        private string strCategory;

        [DataMember]
        public int StoreID
        {
            get { return intID; }
            set { intID = value; }
        }

        [DataMember]
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }

        [DataMember]
        public string Description
        {
            get { return strDescription; }
            set { strDescription = value; }
        }

        [DataMember]
        public string Rating
        {
            get { return strRating; }
            set { strRating = value; }
        }

        [DataMember]
        public string Category
        {
            get { return strCategory; }
            set { strCategory = value; }
        }
    }
}
