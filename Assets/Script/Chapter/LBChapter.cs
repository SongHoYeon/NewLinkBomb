using UnityEngine;
using System.Collections;

public class LBChapter : MonoBehaviour {

    float a = 0.0f;
    public GameObject MovePoint;

	void Start () {
	    
	}
	
	void Update () {
	}

    public void OnClickChapter_1(){
        StartCoroutine("Aplus");
        transform.position = Vector3.Lerp(transform.position, MovePoint.transform.position, a);
    }

    IEnumerator Aplus()
    {
        a += 0.05f;
        yield return new WaitForSeconds(0.1f);
    }
}
