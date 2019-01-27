using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishEffect : MonoBehaviour {

    public GameObject SapphiArtchan;
    public GameObject Enemy;
    public GameObject Ghost;

    Color GhostColor;

    float time;

    // Use this for initialization
    void Start () {
        // ゴーストの大きさを0にする
        Ghost.transform.localScale = new Vector3(0, 0, 0);

        GhostColor = Ghost.GetComponent<Renderer>().material.color;             // ゴーストの色を変数に入れる
        GhostColor.a = 1.0f;                                                    // アルファ値をマックスに戻す
        Ghost.GetComponent<Renderer>().material.color = GhostColor;             // アルファ値をマテリアルに反映させる

        time = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if(GhostColor.a > 0)
        {
            GhostColor.a -= 0.01f;                                                   // アルファ値を徐々に減らす
            Ghost.GetComponent<Renderer>().material.color = GhostColor;             // アルファ値をマテリアルに反映させる
        }

        // テスト用
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GhostColor.a = 1.0f;
            Ghost.GetComponent<Renderer>().material.color = GhostColor;
        }
    }
}
