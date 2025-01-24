using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RvtVa3c
{
    [DataContract]
    public class Va3cGeometryData
    {
        // populate data object properties
        //jason.data.vertices = new object[mesh.Vertices.Count * 3];
        //jason.data.normals = new object[0];
        //jason.data.uvs = new object[0];
        //jason.data.faces = new object[mesh.Faces.Count * 4];
        //jason.data.scale = 1;
        //jason.data.visible = true;
        //jason.data.castShadow = true;
        //jason.data.receiveShadow = false;
        //jason.data.doubleSided = true;

        [DataMember]
        public List<double> vertices { get; set; } // millimetres
        // "morphTargets": []
        [DataMember]
        public List<double> normals { get; set; }
        // "colors": []
        [DataMember]
        public List<double> uvs { get; set; }
        [DataMember]
        public List<int> faces { get; set; } // indices into Vertices + Materials
        [DataMember]
        public double scale { get; set; }
        [DataMember]
        public bool visible { get; set; }
        [DataMember]
        public bool castShadow { get; set; }
        [DataMember]
        public bool receiveShadow { get; set; }
        [DataMember]
        public bool doubleSided { get; set; }
    }

}