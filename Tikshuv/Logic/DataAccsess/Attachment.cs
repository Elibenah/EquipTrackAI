using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tikshuv.Logic.DataAccsess
{
    public class Attachment
    {
        public string name { get; set; } = "";
        public string? description { get; set; }
        public string? type { get; set; }
        public DateTime dateAdded { get; set; }
        public int? equipmentId { get; set; }

        public bool isCredited { get; set; }
        public bool inMission { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Attachment other)
                return name == other.name;
            return false;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}
