//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;
//using System;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.IO;
//using System.Linq;

//public class LoadFileMng : MonoBehaviour
//{
//    private static LoadFileMng instance;
//    private static GameObject container;

//    public static LoadFileMng Instance()
//    {
//        if (!instance)
//        {
//            container = new GameObject();
//            container.name = "LoadFileMng";
//            instance = container.AddComponent(typeof(LoadFileMng)) as LoadFileMng;
//        }
//        return instance;
//    }

//    public delegate void loadSuccessCallback(List<MapToolTileInfo> list);
//    private loadSuccessCallback successCallback;

//    private List<MapToolTileInfo> tileList = new List<MapToolTileInfo>();

//    public void Create(loadSuccessCallback _successCallback)
//    {
//        successCallback = _successCallback;
//    }

//    public void LoadFile(string fileName)
//    {
//        if (File.Exists(Application.dataPath + "/Resources/SaveDatas/" + fileName + ".dat"))
//        {
//            BinaryFormatter bf = new BinaryFormatter();
//            FileStream file = File.Open(Application.dataPath + "/Resources/SaveDatas/" + fileName + ".dat", FileMode.Open);
//            TileDataType data = (TileDataType)bf.Deserialize(file);

//            file.Close();

//            GlobalGameData.Instance.width = data.width;
//            GlobalGameData.Instance.height = data.height;

//            tileList.Clear();
//            foreach (int type in data.ListMap)
//            {
//                MapToolTileInfo tile = new MapToolTileInfo();
//                tile.Type = (MapToolTileType)System.Enum.Parse(typeof(MapToolTileType), type.ToString());
//                tileList.Add(tile);
//            }

//            successCallback(tileList);
//        }
//        else
//            Debug.Log("error : file not found.");
//    }
//}
