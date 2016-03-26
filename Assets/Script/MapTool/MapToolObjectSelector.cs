using UnityEngine;
using System;
using System.Collections;

public enum MapToolObjectType
{ 
    Basic = 0,
    Danger,
    End,
    Obstacle,
    Portal,
    Start
}

public class MapToolObjectSelector : MonoBehaviour {

    private MapToolObjectType selectedType = MapToolObjectType.Basic;
    public MapToolObjectType SelectType { get { return SelectType; } }

    private void OnClickSlot(GameObject btn)
    {
        selectedType = (MapToolObjectType)Enum.Parse(typeof(MapToolObjectType), btn.name);  
    }
}
