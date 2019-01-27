using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mark : MonoBehaviour {

    public GameObject Boll;
    public GameObject boll;
    private Vector3 vec;
    float Speed = 1.0f;
    bool flg5 = true;

    float Vx2 ;
    float Vy2 ;
    float Vz2 ;
    float Powe = 1.0f;

    // Use this for initialization
    void Start () {
         boll = GameObject.Find("Sphere");
        vec = boll.GetComponent<TestScript>().Vec;
        Vx2 = boll.GetComponent<TestScript>().Vx;
        Vy2 = boll.GetComponent<TestScript>().Vy;
        Vz2 = boll.GetComponent<TestScript>().Vz;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.anyKey && !(Input.GetKey(KeyCode.K)))
        {
            flg5 = true;
            vec = boll.GetComponent<TestScript>().Vec;
            
            Vx2 = boll.GetComponent<TestScript>().Vx;
            Vy2 = boll.GetComponent<TestScript>().Vy;
            Vz2 = boll.GetComponent<TestScript>().Vz;
        }
        //if (Input.GetKey(KeyCode.P))
        //{
        //    Powe += 0.01f;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    Powe -= 0.01f;
        //}
        if (flg5 == true)
        {
            
            for (int i = 1; i < 50; i++)
            {
                //Debug.Log("OK");
                
                GameObject item;

                Vy2 -= 0.05f;

                vec += new Vector3(Vx2, Vy2, Vz2);
                



                Vector3 ivec = boll.transform.position + vec*5f;
                item = Instantiate(Boll, ivec,Quaternion.identity);
            }
            flg5 = false;
        }
	}
}
