using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishEffect : MonoBehaviour {

    public GameObject SapphiArtchan;
    public GameObject Enemy;
    public GameObject GhostMaterial;
    public GameObject Ghost;

    Color GhostColor;

    public Camera MainCamera;

    float time;

    // Use this for initialization
    void Start () {
        // ゴーストの大きさを0にする
        Ghost.transform.localScale = new Vector3(0, 0, 0);

        GhostColor = GhostMaterial.GetComponent<Renderer>().material.color;             // ゴーストの色を変数に入れる
        GhostColor.a = 1.0f;                                                    // アルファ値をマックスに戻す
        GhostMaterial.GetComponent<Renderer>().material.color = GhostColor;             // アルファ値をマテリアルに反映させる

        time = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if(GhostColor.a > 0)
        {
            Ghost.transform.localScale += new Vector3(0.15f, 0.15f, 0.15f);
            Ghost.transform.localPosition += new Vector3(0, 0.01f, 0);

            if (Ghost.transform.lossyScale.x > 5.0f)
            {
                GhostColor.a -= 0.01f;                                                   // アルファ値を徐々に減らす
                GhostMaterial.GetComponent<Renderer>().material.color = GhostColor;      // アルファ値をマテリアルに反映させる
            }
        }

        // テスト用
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Ghost.transform.localScale = new Vector3(0, 0, 0);
            GhostColor.a = 1.0f;
            GhostMaterial.GetComponent<Renderer>().material.color = GhostColor;
        }
    }
}
