using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    public Vector3 Vec;
    public float Vx = 1.0f;
    public float Vy = 0.1f;
    public float Vz = 0f;
    float anglex = 1.5f;
    float angley = 0f;
    float anglez = 0f;
    float Speed = 0.1f;
    float Pow = 0;

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
            if (angley > 1.40f) angley = 1.4f;
            
            Vy = Speed * Mathf.Sin(angley);
            if ((Vy == Pow || Vy < Pow  ) && angley == 1.4f)
            {
                Vy += (Pow - Vy);
                Debug.Log(Vy+"いち");
                Debug.Log("1");
            }
            if ((Vy == Pow || Vy < Pow ) && angley != 1.4f)
            {
                Vy += (Pow - Vy);
                Debug.Log(Vy + "に");
                Debug.Log("2");
            }
            if (angley != 1.40f)
            {
                Vec = new Vector3(Vx, Vy, Vz);
                Debug.Log(angley);
                Debug.Log("3");
            }
        }else if(Input.GetKey(KeyCode.DownArrow))
        {
            angley -= 0.01f;
            if (angley < -1.4f)  angley = -1.4f;

            Vy = Speed * Mathf.Sin(angley);
            if ((Vy == Pow || Vy < Pow || Vy > Pow) && angley == -1.4f)
                Vy -= (Pow - Vy);
            if ((Vy == Pow || Vy < Pow || Vy > Pow) && angley != -1.4f)
                 Vy -= (Pow - Vy);
            if (angley != -1.40f)
                Vec = new Vector3(Vx, Vy, Vz);
            Debug.Log(angley);
        }
        if (Input.GetKey(KeyCode.M))
        {
            anglex += 0.01f;
            if (anglex > 1.4) anglex = 1.4f;
           
            Vx = Speed * Mathf.Cos(anglex);
            Vec = new Vector3(Vx, Vy, Vz);
            Debug.Log(anglex);
        }else if(Input.GetKey(KeyCode.N))
        {
            anglex -= 0.01f;
            
            if (anglex < 0) anglex = 0f;
            Vx = Speed * Mathf.Cos(anglex);
            Vec = new Vector3(Vx, Vy, Vz);
            Debug.Log(anglex);
        }

        if(Input.GetKey(KeyCode.P))
        {
            Vy *= 1.01f;
            Pow = Vy;
        }
        if (Input.GetKey(KeyCode.U))
        {
            Vy *= 0.99f;
            Pow = Vy;
        }
        if (flg == true)
        {
            Vy -= 0.01f;
            Vec = new Vector3(Vx, Vy, Vz);
            

            transform.position += Vec;
        }
	}
}
