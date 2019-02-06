using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishEffect : MonoBehaviour {

    public GameObject SapphiArtchan;
    public GameObject Enemy;
    public GameObject GhostMaterial;
    public GameObject Ghost;
    public Text[] GhostBaster;

    Color GhostColor;

    public Camera MainCamera;

    float InitCameraPositionY;

    byte EffectFlg = 0;

    // テスト用変数
    Vector3 testVector;

    // Use this for initialization
    void Start () {
        // ゴーストの大きさを0にする
        Ghost.transform.localScale = new Vector3(0, 0, 0);

        GhostColor = GhostMaterial.GetComponent<Renderer>().material.color;             // ゴーストの色を変数に入れる
        GhostColor.a = 1.0f;                                                    // アルファ値をマックスに戻す
        GhostMaterial.GetComponent<Renderer>().material.color = GhostColor;             // アルファ値をマテリアルに反映させる

        InitCameraPositionY = MainCamera.transform.position.y;      // カメラの初期位置を保存

        SapphiArtchan.gameObject.SetActive(false);                 // SetActiveをfalseに

        // フォントの透明度を0に設定
        for(int i = 0; i < GhostBaster.Length; i++)
        {
            GhostBaster[i].GetComponent<Text>().color = new Color(GhostBaster[i].GetComponent<Text>().color.r, GhostBaster[i].GetComponent<Text>().color.g, GhostBaster[i].GetComponent<Text>().color.b, 0);
        }
        // テスト用
        testVector = Ghost.transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        switch(EffectFlg)
        {
            case 0:
                if (GhostColor.a > 0)
                {
                    Ghost.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
                    Ghost.transform.localPosition += new Vector3(0, 0.01f, 0);
                    MainCamera.transform.localPosition += new Vector3(0, 0.01f, 0);

                    if (Ghost.transform.localScale.x > 5.0f)
                    {
                        GhostColor.a -= 0.01f;                                                   // アルファ値を徐々に減らす
                        GhostMaterial.GetComponent<Renderer>().material.color = GhostColor;      // アルファ値をマテリアルに反映させる
                    }
                }
                else
                {
                    StartCoroutine("EffectFlgChange");
                }

                break;

            case 1:
                if(MainCamera.transform.position.y > InitCameraPositionY)
                {
                    MainCamera.transform.localPosition += new Vector3(0, -0.1f, 0);
                }
                else
                {
                    StartCoroutine("WinPoseCoroutine");
                }
                break;
        }

        // テスト用
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Ghost.transform.localPosition = testVector;
            Ghost.transform.localScale = new Vector3(0, 0, 0);
            GhostColor.a = 1.0f;
            GhostMaterial.GetComponent<Renderer>().material.color = GhostColor;
            MainCamera.transform.localPosition = new Vector3(MainCamera.transform.position.x, InitCameraPositionY, MainCamera.transform.position.z);
        }
    }

    private IEnumerator EffectFlgChange()
    {
        yield return new WaitForSeconds(0.5f);
        EffectFlg = 1;

        // 表示キャラを切り替え
        SapphiArtchan.SetActive(true);
        Enemy.SetActive(false);
    }

    private IEnumerator WinPoseCoroutine()
    {
        yield return new WaitForSeconds(1.0f);

        Animator WinPoseStart = SapphiArtchan.GetComponent<Animator>();
        WinPoseStart.SetTrigger("Trigger");
        EffectFlg = 2;

    }
}
