using UnityEngine;
using System.Collections;

public class ButtonMove : MonoBehaviour {

    float a, b = 0.0f;
    public GameObject MovePoint;
    public GameObject OtherButton1, OtherButton2;

	void Start () {
	    
	}
	
	void Update () {
	}

    public void OnClickChapterButton()
    {
        StartCoroutine("PositionPlus");
        StartCoroutine("AlphaDown");
    }

    public IEnumerator PositionPlus()
    {
        while (a < 1)
        {
            a += 0.01f;
            transform.position = Vector3.Lerp(transform.position, MovePoint.transform.position, a);
            yield return new WaitForSeconds(0.02f);
        }
    }

    public IEnumerator AlphaDown()
    {
        while(b < 1)
        {
            b += 0.02f;
            OtherButton1.GetComponent<UISprite>().alpha -= b;
            OtherButton2.GetComponent<UISprite>().alpha -= b;
            yield return new WaitForSeconds(0.02f);
        }

        OtherButton1.SetActive(false);
        OtherButton2.SetActive(false);
    }
}
