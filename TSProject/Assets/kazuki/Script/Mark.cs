using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mark : MonoBehaviour {

    public GameObject Boll;
    public GameObject boll;
    private Vector3 vec;
    bool flg5 = true;
    // Use this for initialization
    void Start () {
         boll = GameObject.Find("Sphere");
        vec = boll.GetComponent<TestScript>().Vec;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.anyKey)
        {
            flg5 = true;

        }
        if (flg5 == true)
        {
            
            for (int i = 1; i < 20; i++)
            {
                Debug.Log("OK");
                
                GameObject item;
                
                vec += new Vector3(0, -0.05f, 0); 
                Vector3 ivec = boll.transform.position + vec*i*5;
                item = Instantiate(Boll, ivec,Quaternion.identity);
            }
            flg5 = false;
        }
	}
}
