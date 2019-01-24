using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    int Arrow;
    float ab  = 0.5f;
    private int flgOn = 0;
    int cameraflg = 0;
    private float Movez;
    private float Movex = 0.1f;
    private float Movey = 0.1f;
    private float time = 0;

    GameObject Obj;
    Camera  camerapos;
    Rect rect;

    // Use this for initialization
    void Start () {
        Obj = GameObject.Find("Main Camera");
        camerapos = Obj.GetComponent<Camera>();
        camerapos.rect = new Rect(0f, 0f, 1f, 1f);
	}

    // Update is called once per frame
    void Update() {
        //if (cameraflg == 0)
        //Debug.Log("aaaaa");
        //{
        //if (cameraflg == 5)
        //{
        //    Debug.Log("aaa");
        if (Input.GetKey(KeyCode.D) && cameraflg == 0)
        {
            camerapos.rect = new Rect(0f, ab, 0.5f, 0.5f);
            ab += 0.1f;
            cameraflg = 1;
        }
           
        //}
        //}
        //    time += Time.deltaTime;
        //    if (time <= 1)
        //    {

        //        transform.localPosition += new Vector3(0.05f, 0.03f, 0.07f);

        //    }
        //    else if (time <= 3)
        //    {
        //        transform.localEulerAngles += new Vector3(0f, -0.5f, 0f);
        //        transform.localPosition += new Vector3(0.03f, 0f, 0.05f);
        //    }
        //    if (Input.GetKeyDown(KeyCode.LeftArrow))
        //    {
        //        Arrow = 1; flgOn = 1;
        //    }
        //    else if (Input.GetKeyDown(KeyCode.RightArrow))
        //    { 
        //        Arrow = 2; flgOn = 1;
        //    }
        //    else if (Input.GetKeyDown(KeyCode.UpArrow))
        //    {
        //        Arrow = 3; flgOn = 1;
        //    }
        //    else if (Input.GetKeyDown(KeyCode.DownArrow))
        //    {
        //        Arrow = 4; flgOn = 1;
        //    }
        //    if(Input.GetKey(KeyCode.D))
        //    {
        //        Movez = 0.1f;
        //        transform.position += new Vector3(0f, 0f, Movez);
        //    }else if (Input.GetKeyUp(KeyCode.D))
        //    {
        //        Movez = 0f;
        //    }

        //    if (Input.GetKey(KeyCode.S))
        //    {
        //        Movez = -0.1f;
        //        transform.position += new Vector3(0f, 0f, Movez);
        //    }
        //    else if (Input.GetKeyUp(KeyCode.S))
        //    {
        //        Movez = 0f;
        //    }


        //    if (Input.anyKey && (flgOn == 1 || flgOn == 2))
        //        switch (Arrow)
        //        {
        //            case 1:
        //                transform.position += new Vector3(-0.1f, 0f, Movez);
        //                break;

        //            case 2:
        //                transform.position += new Vector3(0.1f, 0f, Movez);
        //                break;

        //            case 3:
        //                transform.position += new Vector3(0f, 0.1f, Movez);
        //                break;

        //            case 4:
        //                transform.position += new Vector3(0f, -0.1f, Movez);
        //                break;
        //        }
        //    else
        //        flgOn = 0;
    }
}
