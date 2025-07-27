using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tikshuv.Logic.DataAccsess
{
    public class EquipmentInMission
    {
        public string serialNumber { get; set; }
        public List<Attachment> attachmentOfEquiment { get; set; }
    }
    public class mission
    {
        public Dictionary<string, List<EquipmentInMission>> itemsInMissions
        { get; set; }
        public string missionName{ get; set; }
        public string date{ get; set; }
        public string creatorName{ get; set; }
        public string creatorPrivateNumber{ get; set; }
        public string lastChangedBy{ get; set; }
        public bool isFixedMission{ get; set; }
        public string missionId{ get; set; }
        public bool isSigned { get; set; }

        #region IDisposable implementation with finalizer
        private bool isDisposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    this.itemsInMissions = null;
                    this.missionName = null;
                    this.date = null;
                    this.creatorName = null;
                    this.creatorPrivateNumber = null;
                    this.lastChangedBy = null;
                    this.isFixedMission = false;

                }
            }
            isDisposed = true;
        }
        #endregion
    }
    public class missionInHistroy : mission
    {
        public string timeAdded { get; set; }
        public string timeUpdated { get; set; }
    }
}
