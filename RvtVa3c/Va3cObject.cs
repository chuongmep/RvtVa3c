#region Namespaces
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
#endregion // Namespaces

namespace RvtVa3c
{
  /// <summary>
  /// three.js object class, successor of Va3cScene.
  /// The structure and properties defined here were
  /// reverse engineered from JSON files exported 
  /// by the three.js and vA3C editors.
  /// </summary>
  [DataContract]
  public class Va3cContainer
  {

    [DataContract]
    public class Va3cObject
    {
      [DataMember]
      public string uuid { get; set; }
      [DataMember]
      public string name { get; set; } // BIM <document name>
      [DataMember]
      public string type { get; set; } // Object3D
      [DataMember]
      public double[] matrix { get; set; } // [1,0,0,0, 0,1,0,0, 0,0,1,0, 0,0,0,1]
      [DataMember]
      public List<Va3cObject> children { get; set; }

      // The following are only on the children:

      [DataMember]
      public string geometry { get; set; }
      [DataMember]
      public string material { get; set; }
      
      //[DataMember] public List<double> position { get; set; }
      //[DataMember] public List<double> rotation { get; set; }
      //[DataMember] public List<double> quaternion { get; set; }
      //[DataMember] public List<double> scale { get; set; }
      //[DataMember] public bool visible { get; set; }
      //[DataMember] public bool castShadow { get; set; }
      //[DataMember] public bool receiveShadow { get; set; }
      //[DataMember] public bool doubleSided { get; set; }
      
      [DataMember]
      public Dictionary<string, string> userData { get; set; }
    }

    // https://github.com/mrdoob/three.js/wiki/JSON-Model-format-3

    // for the faces, we will use
    // triangle with material
    // 00 00 00 10 = 2
    // 2, [vertex_index, vertex_index, vertex_index], [material_index]     // e.g.:
    //
    //2, 0,1,2, 0

    [DataMember]
    public Metadata metadata { get; set; }
    [DataMember( Name = "object" )]
    public Va3cObject obj { get; set; }
    [DataMember]
    public List<Va3cGeometry> geometries;
    [DataMember]
    public List<Va3cMaterial> materials;
  }
}
