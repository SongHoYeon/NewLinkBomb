using UnityEngine;
using System;
using System.Collections;

public class MapToolGridManager : MonoBehaviour {
    [SerializeField]
    private UIGrid grid;
    [SerializeField]
    private UIInput widthInput;
    [SerializeField]
    private UIInput heightInput;

    private int width;
    private int height;

    private GameObject slotPrefab;

    void Awake()
    {
        slotPrefab = Resources.Load("UI_Prefab/MapTool_Slot") as GameObject;

        SetColumnLimit();
        SetGrid();
    }

    public void OnChangeWidth()
    {
        width = int.Parse(widthInput.label.text);
        
        SetGrid();
    }

    public void OnChangeHeight()
    {
        height = int.Parse(heightInput.label.text);

        SetColumnLimit();
        SetGrid();
    }

    private void SetGrid()
    {
        if (width != 0 && height != 0)
        {
            grid.transform.DestroyChildren();

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    NGUITools.AddChild(grid.gameObject, slotPrefab);
            
            grid.Reposition();
        }
    }

    private void SetColumnLimit()
    {
        grid.maxPerLine = height;
    }
}
