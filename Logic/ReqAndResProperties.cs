using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Tikshuv.Logic
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

        internal static StructureType ReadStructure<StructureType>(Stream Stream)
        where StructureType : struct
        {
            int Length = Marshal.SizeOf(typeof(StructureType));
            byte[] Bytes = new byte[Length];
            Stream.Read(Bytes, 0, Length);
            IntPtr Handle = Marshal.AllocHGlobal(Length);
            Marshal.Copy(Bytes, 0, Handle, Length);
            StructureType Result = (StructureType)Marshal.PtrToStructure(Handle, typeof(StructureType));
            Marshal.FreeHGlobal(Handle);
            return Result;
        }

        internal static void WriteStructure(object Structure, Stream Stream)
        {
            int Length = Marshal.SizeOf(Structure);
            byte[] Bytes = new byte[Length];
            IntPtr Handle = Marshal.AllocHGlobal(Length);
            Marshal.StructureToPtr(Structure, Handle, true);
            Marshal.Copy(Handle, Bytes, 0, Length);
            Marshal.FreeHGlobal(Handle);
            Stream.Write(Bytes, 0, Length);
        }

    }
}
