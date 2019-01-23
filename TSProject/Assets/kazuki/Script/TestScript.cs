using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    public Vector3 Vec;
    float Vx = 1.0f;
    float Vy = 0.1f;
    float Vz = 0f;
    float anglex = 0f;
    float angley = 0f;
    float anglez = 0f;
    float Speed = 1.0f;
    bool flg = false;
    // Use this for initialization
    void Start () {

        Vx = Speed * Mathf.Cos(anglex);
        Vy = Speed * Mathf.Sin(angley);
        Vz = Speed * Mathf.Tan(anglez);
        Vec = new Vector3(Vx, Vy, Vz);
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.K))
        {
            flg = true;
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            anglez += 0.01f;
            if (anglez > 1.4) anglez = 1.5f;
           
            Vz = Speed * Mathf.Tan(anglez);
            Vec = new Vector3(Vx, Vy, Vz);

        }else if(Input.GetKey(KeyCode.RightArrow))
        {
            anglez -= 0.01f;
            
            if (anglez < -1.4) anglez = -1.5f;
            Vz = Speed * Mathf.Tan(anglez);
            Vec = new Vector3(Vx, Vy, Vz);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            angley += 0.01f;
            if (angley > 1.4) angley = 1.5f;
            
            Vy = Speed * Mathf.Sin(angley);
            Vec = new Vector3(Vx, Vy, Vz);
        }else if(Input.GetKey(KeyCode.DownArrow))
        {
            angley -= 0.01f;
           
            if (angley < -1.4) angley = -1.5f;
            Vy = Speed * Mathf.Sin(angley);
            Vec = new Vector3(Vx, Vy, Vz);

        }
        if (Input.GetKey(KeyCode.M))
        {
            anglex += 0.01f;
            if (anglex > 1.4) anglex = 1.5f;
           
            Vx = Speed * Mathf.Cos(anglex);
            Vec = new Vector3(Vx, Vy, Vz);
        }else if(Input.GetKey(KeyCode.N))
        {
            anglex -= 0.01f;
            
            if (anglex < -1.4) anglex = -1.5f;
            Vx = Speed * Mathf.Cos(anglex);
            Vec = new Vector3(Vx, Vy, Vz);
        }

        if (flg == true)
        {
            Vy -= 0.01f;
            Vec = new Vector3(Vx, Vy, Vz);

            transform.position += Vec;
        }
	}
}
