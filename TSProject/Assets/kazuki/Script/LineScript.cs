using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour {

    private Vector3 vec;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject boll = GameObject.Find("Sphere");
        GameObject boll2 = GameObject.Find("Sphere");
        vec = boll2.GetComponent<TestScript>().Vec;
        LineRenderer lineY =GameObject.Find("Line").GetComponent<LineRenderer>();


        lineY.SetPosition(0, boll.transform.position);
        lineY.SetPosition(1, boll2.transform.position+vec*50);
    }
}
