using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class Save {
    public List<SerialCube> blocks = new List<SerialCube>();
}

[Serializable]
public class SerialCube {
    public Vector3 pos;
    public Color color;
}

