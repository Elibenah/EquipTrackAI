using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tikshuv.Logic.DataAccsess
{
    public class Signature
    {
        public string signingPerson { get; set; }
        public string signingPersonNumber { get; set;}
        public string stampeerPerson { get; set; }
        public string stampeerPersonNumber { get; set; }
        public string missionName { get; set; } 
        public string missionId { get; set; }
        public string signatureBase64 { get; set; }
        public bool isSigned { get; set; }
        public string date { get; set; }
    }
}
