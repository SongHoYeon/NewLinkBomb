using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GlobalGameData {
    private static GlobalGameData instance = null;

    public static GlobalGameData Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GlobalGameData();
            }

            return instance;
        }
    }

    public int width { get; set;}
    public int height { get; set; }

    public int totalStageCount { get; set; }
}
