namespace TikshuvServer.equipmentManagment
{
    public class Attachment
    {
        public string name { get; set; }              // Attachment name
        public string description { get; set; }       // Description of the attachment
        public string type { get; set; }              // Category/type (e.g. Battery, Tool, etc.)
        public DateTime dateAdded { get; set; }       // Date when the attachment was added
        public int? equipmentId { get; set; }         // Optional: related equipment ID

        public bool isCredited { get; set; }          // Whether the attachment is credited
        public bool inMission { get; set; }           // Whether the attachment is currently assigned to a mission

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
