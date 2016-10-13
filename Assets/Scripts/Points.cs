using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {

    // Use this for initialization
    void Start () {

	
	}
	
    IEnumerator slowUpdate()
    {



        yield return new WaitForSeconds(0.5f);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
