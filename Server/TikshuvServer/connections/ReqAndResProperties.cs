using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml.Linq;

namespace TikshuvServer
{
    [Serializable]
    public class requestObject
    {
        public string requestSubject { get; set; }
        public string request { get; set; }
        public string ID { get; set; }
        public object data { get; set; }
        public bool authorized { get; set; }


    }
    [Serializable]
    public class responseObject
    {
        public string requestSubject { get; set; }
        public string request { get; set; }
        public string ID { get; set; }
        public object data { get; set; }
        public bool authorized { get; set; }

    }
    
}
