using UnityEngine;
using System.Collections;

public class LBLogo : MonoBehaviour {
    [SerializeField]
    private UISprite logo;

    private Color OriginColor;
    public float t;
    bool check;
	// Use this for initialization
	void Start () {
        t = 0.0f;
        check = true;
        OriginColor = logo.color;
	}
	
	// Update is called once per frame
	void Update () {
        if (t < 0.0f)
        {
            Application.LoadLevel((int)SceneName.SN.Menu);
        }
        else
        {
            if (check)
            {
                if (t < 1.0f)
                {
                    t += Time.deltaTime / 1.8f;
                    logo.color = new Color(OriginColor.r, OriginColor.g, OriginColor.b, t);
                }
                else if (t > 1.0f)
                {
                    check = false;
                }
            }
            else
            {
                t -= Time.deltaTime / 1.8f;
                logo.color = new Color(OriginColor.r, OriginColor.g, OriginColor.b, t);
            }
        }
	}
}
