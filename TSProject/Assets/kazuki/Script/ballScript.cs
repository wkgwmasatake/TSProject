using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {

    public GameObject Line;
    public Vector3 vec ;
    float movespeed = 0.5f;
    float rotaX = 1.0f;
    float rotaY = 0f;
    float rotaZ = 0f;

    bool Testflg = true;
    bool flg = false;



	// Use this for initialization
	void Start () {
        vec = new Vector3(rotaX, rotaY, rotaZ).normalized * movespeed;
        
	}
	
	// Update is called once per frame
	void Update () {
        totacontrollX();
        
        if (Input.GetKeyDown(KeyCode.K) )
        {
            flg = true;
            Line.SetActive(false);
        }
        if (flg == true)
        {
            //vec = new Vector3(rotaX, rotaY, rotaZ).normalized * movespeed;
            transform.position += vec;

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "box" && Testflg == true)
        {
            Debug.Log("OK");

            Vector3 d = transform.position - other.transform.position;
                float a = Vector3.Dot(d, other.transform.up);
            Debug.Log(d);
            Debug.Log(transform.localScale.x);
            if (a < transform.localScale.x)
            {
                Debug.Log("OK2");
                Vector3 n = other.transform.up;
                float h = Mathf.Abs(Vector3.Dot(vec, n));
                Vector3 r = vec + 2 * n * h;
                vec = r;
                Testflg = false;
            }
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "box" && Testflg == false)
        {
            Debug.Log("OK3");
            Testflg = true;
        }
    }
    void totacontrollX()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rotaZ += 0.01f;
            vec = new Vector3(rotaX, rotaY, rotaZ).normalized * movespeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotaZ -= 0.01f;
            vec = new Vector3(rotaX, rotaY, rotaZ).normalized * movespeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rotaY -= 0.01f;
            vec = new Vector3(rotaX, rotaY, rotaZ).normalized * movespeed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotaY += 0.01f;
            vec = new Vector3(rotaX, rotaY , rotaZ).normalized * movespeed;
        }
        
    }
}