using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RvtVa3c
{
    [DataContract]
    public class Va3cGeometry
    {
        [DataMember]
        public string uuid { get; set; }
        [DataMember]
        public string type { get; set; } // "Geometry"
        [DataMember]
        public Va3cGeometryData data { get; set; }
        //[DataMember] public double scale { get; set; }
        [DataMember]
        public List<Va3cMaterial> materials { get; set; }
    }
}