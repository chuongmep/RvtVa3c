using System.Runtime.Serialization;

namespace RvtVa3c
{
    /// <summary>
    /// Based on MeshPhongMaterial obtained by
    /// exporting a cube from the three.js editor.
    /// </summary>
    public class Va3cMaterial
    {
        [DataMember]
        public string uuid { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string type { get; set; } // MeshPhongMaterial
        [DataMember]
        public int color { get; set; } // 16777215
        [DataMember]
        public int ambient { get; set; } //16777215
        [DataMember]
        public int emissive { get; set; } // 1
        [DataMember]
        public int specular { get; set; } //1118481
        [DataMember]
        public int shininess { get; set; } // 30
        [DataMember]
        public double opacity { get; set; } // 1
        [DataMember]
        public bool transparent { get; set; } // false
        [DataMember]
        public bool wireframe { get; set; } // false
    }
}