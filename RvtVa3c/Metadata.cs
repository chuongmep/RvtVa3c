using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RvtVa3c
{
    // https://github.com/mrdoob/three.js/wiki/JSON-Model-format-3

    // for the faces, we will use
    // triangle with material
    // 00 00 00 10 = 2
    // 2, [vertex_index, vertex_index, vertex_index], [material_index]     // e.g.:
    //
    //2, 0,1,2, 0

    public class Metadata
    {
        [DataMember]
        public string type { get; set; } //  "Object"
        [DataMember]
        public double version { get; set; } // 4.3
        [DataMember]
        public string generator { get; set; } //  "RvtVa3c Revit vA3C exporter"
    }

}