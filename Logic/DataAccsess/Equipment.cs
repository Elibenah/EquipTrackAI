using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace Tikshuv.Logic.DataAccsess
{
    public class Equipment : IDisposable
    {
        [JsonProperty("type")]
        public virtual string type { get; set; }
        [JsonProperty("catalogNumber")]
        public string? catalogNumber { get; set; }

        [JsonProperty("serialNumber")]
        public string? serialNumber { get; set; }

        [JsonProperty("history")]
        public Object? missionHistory { get; set; }

        [JsonProperty("specialAttributes")]
        public Dictionary <string, object> ?specialAttributes { get; set; }

        [JsonProperty("avaialabiltyReliabilty")]
        public string ?avaialabiltyReliabilty { get; set; }

        [JsonProperty("lastChange")]
        public DateTime lastChange { get; set; }

        [JsonProperty("fixedMissionName")]
        public string ?fixedMissionName { get; set; }

        [JsonProperty("tempMissionName")]
        public string ?tempMissionName { get; set; }

        [JsonProperty("currentMissionName")]
        public string ?currentMissionName { get; set; }

        [JsonProperty("location")]
        public string ?location { get; set; }

        public List<Attachment> ?Addons { get; set; }
        public int id { get; set; }



        public virtual void Build()
        { }
        public void GetProperties()
        {

        }
        public static bool checkIfItemExists(string serialNumber)
        {
            //Form1.existsItemsList
            foreach (KeyValuePair<string, List<Equipment>> itemType in publicData.existItemsByType)
            {
                foreach (Equipment item in itemType.Value)
                {
                    if (item.serialNumber == serialNumber) return true;
                }
            }
            return false;
        }
        public static Equipment getSpecificEquipmentBySN (string type, string serialNumber)
        {
            foreach(Equipment item in publicData.existItemsByType[type])
            {
                if (item.serialNumber == serialNumber) return item;
            }
            return null;
        }
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
                    if (this.specialAttributes != null) this.specialAttributes = null;
                    if (this.type != null) this.type = null;
                    if (this.catalogNumber != null) this.catalogNumber = null;
                    if (this.serialNumber != null) this.serialNumber = null;
                    if (this.missionHistory != null) this.missionHistory = null;
                    if (this.avaialabiltyReliabilty != null) this.avaialabiltyReliabilty = null;
                    if (this.fixedMissionName != null) this.fixedMissionName = null;
                    if (this.tempMissionName != null) this.tempMissionName = null;
                    if (this.currentMissionName != null) this.currentMissionName = null;
                }
            }
            isDisposed = true;
        }
        #endregion
        public class specialAddons
        {
            [JsonProperty("specialAttributes")]
            public Dictionary<string, object> specialAttributes
            { get; set; }

            
            public virtual void Build()
            { }
            public void GetProperties()
            {

            }
            bool disposed;
            protected virtual void Dispose(bool disposing)
            {
                if (!disposed)
                {
                    if (disposing)
                    {
                        //dispose managed resources
                    }
                }
                //dispose unmanaged resources
                disposed = true;
            }
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }
    }
}
