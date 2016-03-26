//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;
//using System;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.IO;

//[Serializable]
//class TileDataType
//{
//    public int width;
//    public int height;
//    public List<int> ListMap;
//}

//public class SaveFileMng : MonoBehaviour {
//    public void SaveFileForTxt(List<MapToolTileInfo> tileList, string fileName)
//    {
//        BinaryFormatter bf = new BinaryFormatter();
//        FileStream file = File.Create(Application.dataPath + "/Resources/SaveDatas/" + fileName + ".dat");

//        TileDataType data = new TileDataType();
//        data.width = GlobalGameData.Instance.width;
//        data.height = GlobalGameData.Instance.height;

//        data.ListMap = new List<int>();

//        List<int> tmpList = new List<int>();
//        foreach (MapToolTileInfo tile in tileList)
//            tmpList.Add((int)tile.Type);

//        data.ListMap = tmpList;

//        bf.Serialize(file, data);
//        file.Close();
//    }
//}
