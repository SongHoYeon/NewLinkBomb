using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapToolSlot : MonoBehaviour {
    private static Dictionary<MapToolObjectType, string > pathDic = new Dictionary<MapToolObjectType, string>();

    private static void SlotPathDicCreate()
    {
        pathDic.Add(MapToolObjectType.Basic, "Basic");
        pathDic.Add(MapToolObjectType.Danger, "Danger");
        pathDic.Add(MapToolObjectType.End, "EndPoint_On");
        pathDic.Add(MapToolObjectType.Obstacle, "Obstacle");
        pathDic.Add(MapToolObjectType.Portal, "Portal");
        pathDic.Add(MapToolObjectType.Start, "StartPoint");
    }
    
    public void ChangeObjectType(MapToolObjectType type)
    {
        GetComponent<UISprite>().spriteName = pathDic[type];
    }
}
